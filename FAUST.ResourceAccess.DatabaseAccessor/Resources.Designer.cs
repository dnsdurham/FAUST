﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Faust.ResourceAccess {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Faust.ResourceAccess.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Creating {0}.
        /// </summary>
        internal static string Accessors_Create {
            get {
                return ResourceManager.GetString("Accessors_Create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created {0}.
        /// </summary>
        internal static string Accessors_Created {
            get {
                return ResourceManager.GetString("Accessors_Created", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleted {0}.
        /// </summary>
        internal static string Accessors_Deleted {
            get {
                return ResourceManager.GetString("Accessors_Deleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleted {0} {1}s.
        /// </summary>
        internal static string Accessors_DeletedMany {
            get {
                return ResourceManager.GetString("Accessors_DeletedMany", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finding many {0}.
        /// </summary>
        internal static string Accessors_FindMany {
            get {
                return ResourceManager.GetString("Accessors_FindMany", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found {0} {1}s.
        /// </summary>
        internal static string Accessors_FoundMany {
            get {
                return ResourceManager.GetString("Accessors_FoundMany", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updated {0} with Id: {1}.
        /// </summary>
        internal static string Accessors_Updated {
            get {
                return ResourceManager.GetString("Accessors_Updated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating {0} with Id: {1}.
        /// </summary>
        internal static string Accessors_Updating {
            get {
                return ResourceManager.GetString("Accessors_Updating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entity to create cannot be null.
        /// </summary>
        internal static string Error_CreateEntityParameterNull {
            get {
                return ResourceManager.GetString("Error_CreateEntityParameterNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entity to delete cannot be null.
        /// </summary>
        internal static string Error_DeleteEntityParameterNull {
            get {
                return ResourceManager.GetString("Error_DeleteEntityParameterNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search parameter cannot be null.
        /// </summary>
        internal static string Error_SearchParameterNull {
            get {
                return ResourceManager.GetString("Error_SearchParameterNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FaustMigrationsHistoryAccessor:  Finding Many.
        /// </summary>
        internal static string FaustMigrationsHistoryAccessor_FindMany {
            get {
                return ResourceManager.GetString("FaustMigrationsHistoryAccessor_FindMany", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FaustMigrationsHistoryAccessor:  Found {0} MigrationHistories.
        /// </summary>
        internal static string FaustMigrationsHistoryAccessor_Found {
            get {
                return ResourceManager.GetString("FaustMigrationsHistoryAccessor_Found", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FaustMigrationsHistoryAccessor:  Initializing.
        /// </summary>
        internal static string FaustMigrationsHistoryAccessor_Initialize {
            get {
                return ResourceManager.GetString("FaustMigrationsHistoryAccessor_Initialize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FaustMigrationHistoryAccessor: Exception {0}\r\n{1}.
        /// </summary>
        internal static string FaustMigrationsHistoryAccessor_InitializeError {
            get {
                return ResourceManager.GetString("FaustMigrationsHistoryAccessor_InitializeError", resourceCulture);
            }
        }
    }
}
