﻿#pragma checksum "..\..\..\..\View\Log_In.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "805FCD6F14815DED9B237488ABE258891E5791AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GUI_Project;
using GUI_Project.ViewModel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace GUI_Project {
    
    
    /// <summary>
    /// Log_In
    /// </summary>
    public partial class Log_In : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 64 "..\..\..\..\View\Log_In.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textEmail;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\View\Log_In.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAdminLoginName;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\View\Log_In.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textPassword;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\View\Log_In.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtAdminLoginPassword;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GUI_Project;component/view/log_in.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Log_In.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 41 "..\..\..\..\View\Log_In.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Main_Menu);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 47 "..\..\..\..\View\Log_In.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 49 "..\..\..\..\View\Log_In.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 50 "..\..\..\..\View\Log_In.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseDown_1);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 51 "..\..\..\..\View\Log_In.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseDown_2);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textEmail = ((System.Windows.Controls.TextBlock)(target));
            
            #line 64 "..\..\..\..\View\Log_In.xaml"
            this.textEmail.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.textEmail_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtAdminLoginName = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\..\..\View\Log_In.xaml"
            this.txtAdminLoginName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtEmail_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textPassword = ((System.Windows.Controls.TextBlock)(target));
            
            #line 77 "..\..\..\..\View\Log_In.xaml"
            this.textPassword.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.textPassword_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtAdminLoginPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 79 "..\..\..\..\View\Log_In.xaml"
            this.txtAdminLoginPassword.PasswordChanged += new System.Windows.RoutedEventHandler(this.txtPassword_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 83 "..\..\..\..\View\Log_In.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Admin_Login);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 116 "..\..\..\..\View\Log_In.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Home);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 117 "..\..\..\..\View\Log_In.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Features);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 118 "..\..\..\..\View\Log_In.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Services);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 119 "..\..\..\..\View\Log_In.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AboutUs);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 120 "..\..\..\..\View\Log_In.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Devoleped_By);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
