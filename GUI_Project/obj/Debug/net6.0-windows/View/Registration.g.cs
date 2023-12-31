﻿#pragma checksum "..\..\..\..\View\Registration.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "297DE93746767847B721356C503B69BBDE08681B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using GUI_Project;
using GUI_Project.Registration_User_Control;
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
    /// Registration
    /// </summary>
    public partial class Registration : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 81 "..\..\..\..\View\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GUI_Project.Registration_User_Control.My_Text_Box txtAddress;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\View\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePicker;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\View\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GUI_Project.Registration_User_Control.My_Text_Box txtEmail;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\View\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GUI_Project.Registration_User_Control.My_Text_Box txtMobile;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\View\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel txtGender;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\View\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel txtMembership;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI_Project;component/view/registration.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Registration.xaml"
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
            
            #line 13 "..\..\..\..\View\Registration.xaml"
            ((GUI_Project.Registration)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Window_MouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 45 "..\..\..\..\View\Registration.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 47 "..\..\..\..\View\Registration.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 48 "..\..\..\..\View\Registration.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseDown_1);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 49 "..\..\..\..\View\Registration.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseDown_2);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtAddress = ((GUI_Project.Registration_User_Control.My_Text_Box)(target));
            return;
            case 7:
            this.datePicker = ((System.Windows.Controls.DatePicker)(target));
            
            #line 86 "..\..\..\..\View\Registration.xaml"
            this.datePicker.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DatePicker_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtEmail = ((GUI_Project.Registration_User_Control.My_Text_Box)(target));
            return;
            case 9:
            this.txtMobile = ((GUI_Project.Registration_User_Control.My_Text_Box)(target));
            return;
            case 10:
            this.txtGender = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 11:
            
            #line 99 "..\..\..\..\View\Registration.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 100 "..\..\..\..\View\Registration.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 13:
            this.txtMembership = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 14:
            
            #line 107 "..\..\..\..\View\Registration.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 108 "..\..\..\..\View\Registration.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 109 "..\..\..\..\View\Registration.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 123 "..\..\..\..\View\Registration.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Main_menu);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 124 "..\..\..\..\View\Registration.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Registration_2);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 139 "..\..\..\..\View\Registration.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Home_Window);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

