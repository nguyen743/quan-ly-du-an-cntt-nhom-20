﻿#pragma checksum "..\..\..\WindowView\XemLichSuChinhSua.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4E643DE7A92BEBC702A45DE3955B7B60C8EBF8CB3CAFF67AB84D00DBFB5F7AD2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QuanLyNhanVien;
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


namespace QuanLyNhanVien.WindowView {
    
    
    /// <summary>
    /// XemLichSuChinhSua
    /// </summary>
    public partial class XemLichSuChinhSua : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\WindowView\XemLichSuChinhSua.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid lsChinhSuaDtg;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\WindowView\XemLichSuChinhSua.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button thoatBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyNhanVien;component/windowview/xemlichsuchinhsua.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowView\XemLichSuChinhSua.xaml"
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
            this.lsChinhSuaDtg = ((System.Windows.Controls.DataGrid)(target));
            
            #line 31 "..\..\..\WindowView\XemLichSuChinhSua.xaml"
            this.lsChinhSuaDtg.Loaded += new System.Windows.RoutedEventHandler(this.lsChinhSuaDtg_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.thoatBtn = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\WindowView\XemLichSuChinhSua.xaml"
            this.thoatBtn.Click += new System.Windows.RoutedEventHandler(this.thoatBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

