﻿#pragma checksum "..\..\CRM.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2512486EB7327F0A8B3BE0190D7B8AB277D7F33F12FF03B6D70786C020331D1D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CRMFinal;
using CRMFinal.Properties;
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


namespace CRMFinal {
    
    
    /// <summary>
    /// CRMain
    /// </summary>
    public partial class CRMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\CRM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLeads;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\CRM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnContacts;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\CRM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeals;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\CRM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton toggleButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\CRM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CRMFinal.Deals Deals1;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\CRM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CRMFinal.Contacts Contacts1;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\CRM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CRMFinal.Lead Leads1;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\CRM.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar date;
        
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
            System.Uri resourceLocater = new System.Uri("/CRMFinal;component/crm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CRM.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.btnLeads = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\CRM.xaml"
            this.btnLeads.Click += new System.Windows.RoutedEventHandler(this.BtnLeads_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnContacts = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\CRM.xaml"
            this.btnContacts.Click += new System.Windows.RoutedEventHandler(this.BtnContacts_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnDeals = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\CRM.xaml"
            this.btnDeals.Click += new System.Windows.RoutedEventHandler(this.BtnDeals_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.toggleButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 47 "..\..\CRM.xaml"
            this.toggleButton.Click += new System.Windows.RoutedEventHandler(this.ToggleButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Deals1 = ((CRMFinal.Deals)(target));
            return;
            case 6:
            this.Contacts1 = ((CRMFinal.Contacts)(target));
            return;
            case 7:
            this.Leads1 = ((CRMFinal.Lead)(target));
            return;
            case 8:
            this.date = ((System.Windows.Controls.Calendar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

