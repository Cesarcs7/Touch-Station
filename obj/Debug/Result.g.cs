﻿#pragma checksum "..\..\Result.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D25E0C6103098A3EE5D71D8B39AD4D5A440E1F36"
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
    /// Result
    /// </summary>
    public partial class Result : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\Result.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel banner;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Result.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock profileName;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Result.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock date;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\Result.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock time;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\Result.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock id;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\Result.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock desciptionText;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\Result.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock desciptionSpan;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\Result.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image statusImg;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\Result.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock titleLabel;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\Result.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock resultLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/SoftwareStation;component/result.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Result.xaml"
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
            
            #line 31 "..\..\Result.xaml"
            ((System.Windows.Controls.Image)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.profileName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.date = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.time = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.id = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.desciptionText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.desciptionSpan = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.statusImg = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.titleLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.resultLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            
            #line 147 "..\..\Result.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
