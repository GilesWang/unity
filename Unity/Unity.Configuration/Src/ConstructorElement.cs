﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Microsoft.Practices.ObjectBuilder2;
using Microsoft.Practices.Unity.Configuration.Properties;

namespace Microsoft.Practices.Unity.Configuration
{
    /// <summary>
    /// Configuration element representing a constructor configuration.
    /// </summary>
    public class ConstructorElement : InjectionMemberElement
    {
        private const string ParametersPropertyName = "";

        /// <summary>
        /// The parameters of the constructor to call.
        /// </summary>
        [ConfigurationProperty(ParametersPropertyName, IsDefaultCollection = true)]
        public ParameterElementCollection Parameters
        {
            get { return (ParameterElementCollection) base[ParametersPropertyName]; }
        }

        /// <summary>
        /// Each element must have a unique key, which is generated by the subclasses.
        /// </summary>
        public override string Key
        {
            get { return "constructor"; }
        }

        /// <summary>
        /// Return the set of <see cref="InjectionMember"/>s that are needed
        /// to configure the container according to this configuration element.
        /// </summary>
        /// <param name="container">Container that is being configured.</param>
        /// <param name="fromType">Type that is being registered.</param>
        /// <param name="toType">Type that <paramref name="fromType"/> is being mapped to.</param>
        /// <param name="name">Name this registration is under.</param>
        /// <returns>One or more <see cref="InjectionMember"/> objects that should be
        /// applied to the container registration.</returns>
        public override IEnumerable<InjectionMember> GetInjectionMembers(IUnityContainer container, Type fromType, Type toType, string name)
        {
            var typeToConstruct = toType;

            var constructorToCall = FindConstructorInfo(typeToConstruct);

            GuardIsMatchingConstructor(typeToConstruct, constructorToCall);
            
            return new [] { MakeInjectionMember(container, constructorToCall) };
        }


        private ConstructorInfo FindConstructorInfo(Type typeToConstruct)
        {
            return typeToConstruct.GetConstructors().Where(ConstructorMatches).FirstOrDefault();
        }

        private bool ConstructorMatches(ConstructorInfo candiateConstructor)
        {
            var constructorParams = candiateConstructor.GetParameters();
            
            if(constructorParams.Length != Parameters.Count) return false;

            return Sequence.Zip(Parameters, constructorParams).All(pair => pair.First.Matches(pair.Second));
        }

        private InjectionMember MakeInjectionMember(IUnityContainer container, ConstructorInfo constructorToCall)
        {
            var values = new List<InjectionParameterValue>();
            var parameterInfos = constructorToCall.GetParameters();

            for(int i = 0; i < parameterInfos.Length; ++i)
            {
                values.Add(Parameters[i].GetParameterValue(container, parameterInfos[i].ParameterType));
            }

            return new InjectionConstructor(values.ToArray());
        }

        private void GuardIsMatchingConstructor(Type typeToConstruct, ConstructorInfo ctor)
        {
            if(ctor == null)
            {
                string parameterNames = string.Join(", ", Parameters.Select(p => p.Name).ToArray());

                throw new InvalidOperationException(
                    string.Format(CultureInfo.CurrentUICulture, Resources.NoMatchingConstructor,
                        typeToConstruct.FullName, parameterNames));
            }
        }
    }
}
