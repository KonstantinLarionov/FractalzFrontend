﻿#pragma checksum "..\..\..\..\Views\ProfilePart\ProfileView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F34C850913A399AD55855456201E42697F27C7B53B2983BCB0E7496F59F0B2E5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FractalzFrontend.Views.ProfilePart;
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


namespace FractalzFrontend.Views.ProfilePart {
    
    
    /// <summary>
    /// ProfileView
    /// </summary>
    public partial class ProfileView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
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
            System.Uri resourceLocater = new System.Uri("/FractalzFrontend;component/views/profilepart/profileview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ProfilePart\ProfileView.xaml"
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
            
            #line 73 "..\..\..\..\Views\ProfilePart\ProfileView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateUserInfo);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 115 "..\..\..\..\Views\ProfilePart\ProfileView.xaml"
            ((MaterialDesignThemes.Wpf.PackIcon)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LinksModalOpen);
#pragma checksum "..\..\..\..\Views\ProfilePart\ProfileView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F34C850913A399AD55855456201E42697F27C7B53B2983BCB0E7496F59F0B2E5"
#pragma checksum "..\..\..\..\Views\ProfilePart\ProfileView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6CA1CB27CACC7BF1180FEA9C20805E1FB8738986842EA4FC120FF4ADF0B689FD"
            #line 73 "..\..\..\..\Views\ProfilePart\ProfileView.xaml"
            #line 115 "..\..\..\..\Views\ProfilePart\ProfileView.xaml"
            ((MaterialDesignThemes.Wpf.PackIcon)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.VkModalOpen);
            #line 115 "..\..\..\..\Views\ProfilePart\ProfileView.xaml"
            ((MaterialDesignThemes.Wpf.PackIcon)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LinksModalOpen);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

