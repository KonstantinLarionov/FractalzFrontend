﻿#pragma checksum "..\..\..\Views\Layout.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3AAA5CA08E47B1B07B190E75A7DE9FA8470D4D258CCADAC80C300D79A5684542"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FractalzFrontend.Views;
using FractalzFrontend.Views.ChatPart;
using FractalzFrontend.Views.NotifyPart;
using FractalzFrontend.Views.TodoPart;
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


namespace FractalzFrontend.Views {
    
    
    /// <summary>
    /// Layout
    /// </summary>
    public partial class Layout : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Views\Layout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel leftbar;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\Layout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button profile;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Views\Layout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button chat;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\Layout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button videochat;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Views\Layout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button events;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Views\Layout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button todo;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Views\Layout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button notify;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Views\Layout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button docs;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Views\Layout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Views\Layout.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel space;
        
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
            System.Uri resourceLocater = new System.Uri("/FractalzFrontend;component/views/layout.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Layout.xaml"
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
            this.leftbar = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.profile = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Views\Layout.xaml"
            this.profile.Click += new System.Windows.RoutedEventHandler(this.SwitchSpace);
            
            #line default
            #line hidden
            return;
            case 3:
            this.chat = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Views\Layout.xaml"
            this.chat.Click += new System.Windows.RoutedEventHandler(this.SwitchSpace);
            
            #line default
            #line hidden
            return;
            case 4:
            this.videochat = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Views\Layout.xaml"
            this.videochat.Click += new System.Windows.RoutedEventHandler(this.SwitchSpace);
            
            #line default
            #line hidden
            return;
            case 5:
            this.events = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\Views\Layout.xaml"
            this.events.Click += new System.Windows.RoutedEventHandler(this.SwitchSpace);
            
            #line default
            #line hidden
            return;
            case 6:
            this.todo = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\Views\Layout.xaml"
            this.todo.Click += new System.Windows.RoutedEventHandler(this.SwitchSpace);
            
            #line default
            #line hidden
            return;
            case 7:
            this.notify = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\Views\Layout.xaml"
            this.notify.Click += new System.Windows.RoutedEventHandler(this.SwitchSpace);
            
            #line default
            #line hidden
            return;
            case 8:
            this.docs = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\Views\Layout.xaml"
            this.docs.Click += new System.Windows.RoutedEventHandler(this.SwitchSpace);
            
            #line default
            #line hidden
            return;
            case 9:
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\..\Views\Layout.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.SwitchSpace);
            
            #line default
            #line hidden
            return;
            case 10:
            this.space = ((System.Windows.Controls.DockPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
