﻿#pragma checksum "..\..\ModMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0125A8B9E285DBC9084023870FB10E487FE66547BCF514B210E4F5C7A850A728"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using AssaultCubeClient;
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


namespace AssaultCubeClient {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\ModMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AssaultCubeClient.MainWindow ModMenu;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\ModMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MyGrid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ModMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Attach;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ModMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Ammo_Checkbox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ModMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Health_Checkbox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ModMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Aimbot_Checkbox;
        
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
            System.Uri resourceLocater = new System.Uri("/AssaultCubeClient;component/modmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ModMenu.xaml"
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
            this.ModMenu = ((AssaultCubeClient.MainWindow)(target));
            
            #line 8 "..\..\ModMenu.xaml"
            this.ModMenu.Loaded += new System.Windows.RoutedEventHandler(this.MyWindow_loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MyGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Attach = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\ModMenu.xaml"
            this.Attach.Click += new System.Windows.RoutedEventHandler(this.Attach_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Ammo_Checkbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 15 "..\..\ModMenu.xaml"
            this.Ammo_Checkbox.Checked += new System.Windows.RoutedEventHandler(this.Ammo_Checkbox_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Health_Checkbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 16 "..\..\ModMenu.xaml"
            this.Health_Checkbox.Checked += new System.Windows.RoutedEventHandler(this.Health_Checkbox_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Aimbot_Checkbox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 17 "..\..\ModMenu.xaml"
            this.Aimbot_Checkbox.Checked += new System.Windows.RoutedEventHandler(this.Aimbot_Checkbox_Checked);
            
            #line default
            #line hidden
            
            #line 17 "..\..\ModMenu.xaml"
            this.Aimbot_Checkbox.Unchecked += new System.Windows.RoutedEventHandler(this.Aimbot_Checkbox_Unchecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

