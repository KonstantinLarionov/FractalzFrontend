﻿#pragma checksum "..\..\..\..\Views\LoginPart\RegistrationView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AAF5DF47863F3366C45913EBE4B01DCCB1BE8013069D45441C5223C42B0F045B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FractalzFrontend.Views.LoginPart;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace FractalzFrontend.Views.LoginPart {
    
    
    /// <summary>
    /// RegistrationView
    /// </summary>
    public partial class RegistrationView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 89 "..\..\..\..\Views\LoginPart\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Code;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\..\Views\LoginPart\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Reg;
        
        #line default
        #line hidden
        
        
        #line 217 "..\..\..\..\Views\LoginPart\RegistrationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label In;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FractalzFrontend;component/views/loginpart/registrationview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\LoginPart\RegistrationView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Code = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\..\Views\LoginPart\RegistrationView.xaml"
            this.Code.Click += new System.Windows.RoutedEventHandler(this.Code_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Reg = ((System.Windows.Controls.Button)(target));
            
            #line 173 "..\..\..\..\Views\LoginPart\RegistrationView.xaml"
            this.Reg.Click += new System.Windows.RoutedEventHandler(this.Reg_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.In = ((System.Windows.Controls.Label)(target));
            
            #line 218 "..\..\..\..\Views\LoginPart\RegistrationView.xaml"
            this.In.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.In_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
