﻿#pragma checksum "..\..\..\DuplicateErrorDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8619A128F91F4AEA9406D7333F3848F384175282"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BatchRename;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace BatchRename {
    
    
    /// <summary>
    /// DuplicateErrorDialog
    /// </summary>
    public partial class DuplicateErrorDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\DuplicateErrorDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem duplicateTabItems;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\DuplicateErrorDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid FileDuplicateTab;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\DuplicateErrorDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid FolderDuplicateTab;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\DuplicateErrorDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel chooseStackPanel;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\DuplicateErrorDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton copyFile;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\DuplicateErrorDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton keepOldName;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BatchRename;component/duplicateerrordialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DuplicateErrorDialog.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.duplicateTabItems = ((System.Windows.Controls.TabItem)(target));
            return;
            case 2:
            this.FileDuplicateTab = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.FolderDuplicateTab = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.chooseStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.copyFile = ((System.Windows.Controls.RadioButton)(target));
            
            #line 53 "..\..\..\DuplicateErrorDialog.xaml"
            this.copyFile.Checked += new System.Windows.RoutedEventHandler(this.copyFile_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.keepOldName = ((System.Windows.Controls.RadioButton)(target));
            
            #line 54 "..\..\..\DuplicateErrorDialog.xaml"
            this.keepOldName.Checked += new System.Windows.RoutedEventHandler(this.keepOldName_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

