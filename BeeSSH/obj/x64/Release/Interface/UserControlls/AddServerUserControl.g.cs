﻿#pragma checksum "..\..\..\..\..\Interface\UserControlls\AddServerUserControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ED9E35BCA821732035B25799A26FE682A7DD2CBC4DC4997DD4548C28C14AAF4F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace BeeSSH.Interface.UserControlls {
    
    
    /// <summary>
    /// AddServerUserControl
    /// </summary>
    public partial class AddServerUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\..\Interface\UserControlls\AddServerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ServerName;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\Interface\UserControlls\AddServerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ServerIP;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\Interface\UserControlls\AddServerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ServerPort;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\Interface\UserControlls\AddServerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Serverusername;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\Interface\UserControlls\AddServerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox ServerPassword;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\Interface\UserControlls\AddServerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RSAKEY;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Interface\UserControlls\AddServerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ServerPassPharse;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Interface\UserControlls\AddServerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton AddBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/BeeSSH;component/interface/usercontrolls/addserverusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Interface\UserControlls\AddServerUserControl.xaml"
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
            this.ServerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ServerIP = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ServerPort = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Serverusername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ServerPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.RSAKEY = ((System.Windows.Controls.RadioButton)(target));
            
            #line 26 "..\..\..\..\..\Interface\UserControlls\AddServerUserControl.xaml"
            this.RSAKEY.Click += new System.Windows.RoutedEventHandler(this.AddRSABtn);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ServerPassPharse = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.AddBtn = ((System.Windows.Controls.RadioButton)(target));
            
            #line 30 "..\..\..\..\..\Interface\UserControlls\AddServerUserControl.xaml"
            this.AddBtn.Click += new System.Windows.RoutedEventHandler(this.AddServerBtn);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

