﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.Unity.InterceptionExtension.Configuration.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.Unity.InterceptionExtension.Configuration.Properties.Resource" +
                            "s", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &lt;injection/&gt; element is not allowed on element named &apos;{0}&apos; because it doesn&apos;t have a type attribute..
        /// </summary>
        internal static string CannotHaveInjectionWithoutTypeName {
            get {
                return ResourceManager.GetString("CannotHaveInjectionWithoutTypeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &lt;lifetime/&gt; element is not allowed on element named &apos;{0}&apos; because it doesn&apos;t have a type attribute..
        /// </summary>
        internal static string CannotHaveLifetimeWithoutTypeName {
            get {
                return ResourceManager.GetString("CannotHaveLifetimeWithoutTypeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type name or alias {0} could not be resolved. Please check your configuration file and verify this type name..
        /// </summary>
        internal static string CouldNotResolveType {
            get {
                return ResourceManager.GetString("CouldNotResolveType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create instance of type {0} with a default constructor..
        /// </summary>
        internal static string ExceptionCannotCreateInstance {
            get {
                return ResourceManager.GetString("ExceptionCannotCreateInstance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type name {0} resolved to type {1} is not compatible with the required type {2}..
        /// </summary>
        internal static string ExceptionResolvedTypeNotCompatible {
            get {
                return ResourceManager.GetString("ExceptionResolvedTypeNotCompatible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The interception behavior element must have at least one of the &apos;name&apos; or &apos;type&apos; attributes..
        /// </summary>
        internal static string MustHaveAtLeastOneBehaviorAttribute {
            get {
                return ResourceManager.GetString("MustHaveAtLeastOneBehaviorAttribute", resourceCulture);
            }
        }
    }
}
