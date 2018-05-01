﻿#pragma checksum "..\..\Spanish-Word-Frequency-Analyzer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "650A53BB2657DF6FD6D313BCD53EB21D07133F79"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using spanish_nl_analyzer;


namespace spanish_nl_analyzer {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\Spanish-Word-Frequency-Analyzer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CursorPosition;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Spanish-Word-Frequency-Analyzer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock doc_name;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Spanish-Word-Frequency-Analyzer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox file_contents;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Spanish-Word-Frequency-Analyzer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button analyze_button;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Spanish-Word-Frequency-Analyzer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save_button;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Spanish-Word-Frequency-Analyzer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView individual_frequency_results_box;
        
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
            System.Uri resourceLocater = new System.Uri("/spanish-nl-analyzer;component/spanish-word-frequency-analyzer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Spanish-Word-Frequency-Analyzer.xaml"
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
            
            #line 9 "..\..\Spanish-Word-Frequency-Analyzer.xaml"
            ((spanish_nl_analyzer.MainWindow)(target)).PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.Window_PreviewMouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\Spanish-Word-Frequency-Analyzer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.file_browse_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\Spanish-Word-Frequency-Analyzer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.folder_browse_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 16 "..\..\Spanish-Word-Frequency-Analyzer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.exit_menu_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CursorPosition = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.doc_name = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.file_contents = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 8:
            this.analyze_button = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\Spanish-Word-Frequency-Analyzer.xaml"
            this.analyze_button.Click += new System.Windows.RoutedEventHandler(this.analyze_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.save_button = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\Spanish-Word-Frequency-Analyzer.xaml"
            this.save_button.Click += new System.Windows.RoutedEventHandler(this.save_output_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.individual_frequency_results_box = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

