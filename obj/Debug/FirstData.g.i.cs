﻿#pragma checksum "..\..\FirstData.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "605E261D20CBE97833D75DB33A7123FB1225EEFA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SoftwareStation;
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


namespace SoftwareStation {
    
    
    /// <summary>
    /// FirstData
    /// </summary>
    public partial class FirstData : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\FirstData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel banner;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\FirstData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox gewicht;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\FirstData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox größe;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\FirstData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton weiblich;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\FirstData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton mänlich;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\FirstData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker calendar;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\FirstData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button weiterFD;
        
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
            System.Uri resourceLocater = new System.Uri("/SoftwareStation;component/firstdata.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FirstData.xaml"
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
            this.banner = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            
            #line 35 "..\..\FirstData.xaml"
            ((System.Windows.Controls.Image)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 45 "..\..\FirstData.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gewicht = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.größe = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.weiblich = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.mänlich = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.calendar = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.weiterFD = ((System.Windows.Controls.Button)(target));
            
            #line 150 "..\..\FirstData.xaml"
            this.weiterFD.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

