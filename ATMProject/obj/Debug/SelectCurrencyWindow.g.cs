﻿#pragma checksum "..\..\SelectCurrencyWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2EEE1D2E71AF2CC7B06DD36DAB879C95854FF919"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ATMProject;
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


namespace ATMProject {
    
    
    /// <summary>
    /// SelectCurrencyWindow
    /// </summary>
    public partial class SelectCurrencyWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\SelectCurrencyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas buttonUK;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\SelectCurrencyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas buttonUS;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\SelectCurrencyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas buttonEU;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\SelectCurrencyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas buttonAUD;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\SelectCurrencyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas buttonPOL;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\SelectCurrencyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas buttonUAE;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\SelectCurrencyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas buttonCH;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\SelectCurrencyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas buttonJP;
        
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
            System.Uri resourceLocater = new System.Uri("/ATMProject;component/selectcurrencywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SelectCurrencyWindow.xaml"
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
            
            #line 10 "..\..\SelectCurrencyWindow.xaml"
            ((ATMProject.SelectCurrencyWindow)(target)).ContentRendered += new System.EventHandler(this.Window_ContentRendered);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\SelectCurrencyWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.exitButtonPush);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonUK = ((System.Windows.Controls.Canvas)(target));
            
            #line 29 "..\..\SelectCurrencyWindow.xaml"
            this.buttonUK.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.cultureButtonPush);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonUS = ((System.Windows.Controls.Canvas)(target));
            
            #line 35 "..\..\SelectCurrencyWindow.xaml"
            this.buttonUS.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.cultureButtonPush);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonEU = ((System.Windows.Controls.Canvas)(target));
            
            #line 41 "..\..\SelectCurrencyWindow.xaml"
            this.buttonEU.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.cultureButtonPush);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonAUD = ((System.Windows.Controls.Canvas)(target));
            
            #line 47 "..\..\SelectCurrencyWindow.xaml"
            this.buttonAUD.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.cultureButtonPush);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonPOL = ((System.Windows.Controls.Canvas)(target));
            
            #line 53 "..\..\SelectCurrencyWindow.xaml"
            this.buttonPOL.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.cultureButtonPush);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonUAE = ((System.Windows.Controls.Canvas)(target));
            
            #line 59 "..\..\SelectCurrencyWindow.xaml"
            this.buttonUAE.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.cultureButtonPush);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonCH = ((System.Windows.Controls.Canvas)(target));
            
            #line 65 "..\..\SelectCurrencyWindow.xaml"
            this.buttonCH.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.cultureButtonPush);
            
            #line default
            #line hidden
            return;
            case 10:
            this.buttonJP = ((System.Windows.Controls.Canvas)(target));
            
            #line 71 "..\..\SelectCurrencyWindow.xaml"
            this.buttonJP.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.cultureButtonPush);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

