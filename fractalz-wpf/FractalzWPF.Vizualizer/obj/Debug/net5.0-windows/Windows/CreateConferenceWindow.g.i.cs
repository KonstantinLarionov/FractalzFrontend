﻿#pragma checksum "..\..\..\..\Windows\CreateConferenceWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "756016B05A2B61B16886255B83159626BF31EBA0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FractalzWPF.Infrastructure.Vizualizer.Windows;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace FractalzWPF.Infrastructure.Vizualizer.Windows {
    
    
    /// <summary>
    /// CreateConferenceWindow
    /// </summary>
    public partial class CreateConferenceWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Windows\CreateConferenceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox confName;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Windows\CreateConferenceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox confToken;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Windows\CreateConferenceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateStart;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Windows\CreateConferenceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.TimePicker timeStart;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Windows\CreateConferenceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox findUserMain;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Windows\CreateConferenceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel mainUsers;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Windows\CreateConferenceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox findUserOther;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Windows\CreateConferenceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel otherUsers;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Windows\CreateConferenceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tb_dayLoop;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FractalzWPF.Infrastructure.Vizualizer;V1.0.0.0;component/windows/createconferenc" +
                    "ewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\CreateConferenceWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.confName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.confToken = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.dateStart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.timeStart = ((MaterialDesignThemes.Wpf.TimePicker)(target));
            return;
            case 5:
            this.findUserMain = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.mainUsers = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.findUserOther = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.otherUsers = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.tb_dayLoop = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 10:
            
            #line 42 "..\..\..\..\Windows\CreateConferenceWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonBase_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

