﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeqingNiuza.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsWindowMaximized {
            get {
                return ((bool)(this["IsWindowMaximized"]));
            }
            set {
                this["IsWindowMaximized"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsCorrectOrder {
            get {
                return ((bool)(this["IsCorrectOrder"]));
            }
            set {
                this["IsCorrectOrder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsLogonTrigger {
            get {
                return ((bool)(this["IsLogonTrigger"]));
            }
            set {
                this["IsLogonTrigger"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsGenshinStartTrigger {
            get {
                return ((bool)(this["IsGenshinStartTrigger"]));
            }
            set {
                this["IsGenshinStartTrigger"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsOversea {
            get {
                return ((bool)(this["IsOversea"]));
            }
            set {
                this["IsOversea"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DialyCheck_AlwaysShowResult {
            get {
                return ((bool)(this["DialyCheck_AlwaysShowResult"]));
            }
            set {
                this["DialyCheck_AlwaysShowResult"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DailyCheck_IsAutoCheckIn {
            get {
                return ((bool)(this["DailyCheck_IsAutoCheckIn"]));
            }
            set {
                this["DailyCheck_IsAutoCheckIn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("01/01/1970 06:00:00")]
        public global::System.DateTime DailyCheck_StartTime {
            get {
                return ((global::System.DateTime)(this["DailyCheck_StartTime"]));
            }
            set {
                this["DailyCheck_StartTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("02:00:00")]
        public global::System.TimeSpan DailyCheck_RandomDelay {
            get {
                return ((global::System.TimeSpan)(this["DailyCheck_RandomDelay"]));
            }
            set {
                this["DailyCheck_RandomDelay"] = value;
            }
        }
    }
}
