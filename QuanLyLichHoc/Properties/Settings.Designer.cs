﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyLichHoc.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.11.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;

            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]

        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-UOULN0V\\SQLEXPRESS;Initial Catalog=Lesson_Management_System;I" +
            "ntegrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=T" +
            "rue")]
        public string Lesson_Management_SystemConnectionString {
            get {
                return ((string)(this["Lesson_Management_SystemConnectionString"]));

            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-UOULN0V\\SQLEXPRESS;Initial Catalog=Lesson_Management_System;I" +
            "ntegrated Security=True;TrustServerCertificate=True")]

        public string Lesson_Management_SystemConnectionString1 {
            get {
                return ((string)(this["Lesson_Management_SystemConnectionString1"]));


            }
        }
        
       
    }
}
