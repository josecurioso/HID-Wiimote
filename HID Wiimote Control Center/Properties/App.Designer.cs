﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HIDWiimote.ControlCenter.Properties {
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
    internal class App {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal App() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HIDWiimote.ControlCenter.Properties.App", typeof(App).Assembly);
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
        ///   Looks up a localized string similar to There is a newer Device Driver already installed.
        ///Please use the Control Center that comes with that Driver Package.
        ///
        ///Installed Device Driver: {0}
        ///Compatible Device Driver: {1}.
        /// </summary>
        internal static string NewerInstalledDialog_MainMessage {
            get {
                return ResourceManager.GetString("NewerInstalledDialog_MainMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while: .
        /// </summary>
        internal static string Update_RemoveDeviceDriverErrorDialog_Title {
            get {
                return ResourceManager.GetString("Update_RemoveDeviceDriverErrorDialog_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The new Device Driver was not successfully installed. Please try again..
        /// </summary>
        internal static string Updater_InstallDeviceDriverCheckFailed {
            get {
                return ResourceManager.GetString("Updater_InstallDeviceDriverCheckFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while trying to install the new Device Driver..
        /// </summary>
        internal static string Updater_InstallDeviceDriverException {
            get {
                return ResourceManager.GetString("Updater_InstallDeviceDriverException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Install new Device Driver.
        /// </summary>
        internal static string Updater_InstallDeviceDriverMessage {
            get {
                return ResourceManager.GetString("Updater_InstallDeviceDriverMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The old Device Driver was not successfully removed. Please try again or remove it via &quot;Programs and Features&quot;..
        /// </summary>
        internal static string Updater_RemoveDeviceDriverCheckFailed {
            get {
                return ResourceManager.GetString("Updater_RemoveDeviceDriverCheckFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while trying to uninstall the old Device Driver..
        /// </summary>
        internal static string Updater_RemoveDeviceDriverException {
            get {
                return ResourceManager.GetString("Updater_RemoveDeviceDriverException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove old Device Driver.
        /// </summary>
        internal static string Updater_RemoveDeviceDriverPMessage {
            get {
                return ResourceManager.GetString("Updater_RemoveDeviceDriverPMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This Control Center comes with an driver update.
        ///Would you like to update the HID Wiimote Device Driver?
        ///
        ///Note: This Control Center is only compatible with the updated driver.
        ///
        ///Installed Device Driver: {0}
        ///New Device Driver: {1}.
        /// </summary>
        internal static string UpdaterDialog_MainMessage {
            get {
                return ResourceManager.GetString("UpdaterDialog_MainMessage", resourceCulture);
            }
        }
    }
}
