﻿#pragma checksum "..\..\..\Pages\Pagina_Sortimente.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "203D3DC369BDAB3C427ED80B67A179FA37363BFD1AA28668995CD2C22C2D62B7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using SzakacsAndreea_2023_Licenta.DataLayer;
using SzakacsAndreea_2023_Licenta.Pages;


namespace SzakacsAndreea_2023_Licenta.Pages {
    
    
    /// <summary>
    /// Pagina_Sortimente
    /// </summary>
    public partial class Pagina_Sortimente : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Pages\Pagina_Sortimente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelTitle;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Pages\Pagina_Sortimente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox codsortimentTextBox;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Pages\Pagina_Sortimente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sortimentTextBox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Pages\Pagina_Sortimente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox codproducatorTextBox;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Pages\Pagina_Sortimente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox origineTextBox;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Pages\Pagina_Sortimente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdaugaSortiment;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Pages\Pagina_Sortimente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditeazaSortiment;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Pages\Pagina_Sortimente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStergereSortiment;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Pages\Pagina_Sortimente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnulareSortiment;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Pages\Pagina_Sortimente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCautaOrigine;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Pages\Pagina_Sortimente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid sortimenteDataGrid;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\Pages\Pagina_Sortimente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn codSortimentColumn;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\Pages\Pagina_Sortimente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn codProducatorColumn;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\Pages\Pagina_Sortimente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn origineColumn;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Pages\Pagina_Sortimente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn sortimentColumn;
        
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
            System.Uri resourceLocater = new System.Uri("/SzakacsAndreea_2023_Licenta;component/pages/pagina_sortimente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Pagina_Sortimente.xaml"
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
            
            #line 11 "..\..\..\Pages\Pagina_Sortimente.xaml"
            ((SzakacsAndreea_2023_Licenta.Pages.Pagina_Sortimente)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.labelTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.codsortimentTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.sortimentTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.codproducatorTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.origineTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnAdaugaSortiment = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\Pages\Pagina_Sortimente.xaml"
            this.btnAdaugaSortiment.Click += new System.Windows.RoutedEventHandler(this.btnAdaugaSortiment_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnEditeazaSortiment = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\Pages\Pagina_Sortimente.xaml"
            this.btnEditeazaSortiment.Click += new System.Windows.RoutedEventHandler(this.btnEditeazaSortiment_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnStergereSortiment = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\Pages\Pagina_Sortimente.xaml"
            this.btnStergereSortiment.Click += new System.Windows.RoutedEventHandler(this.btnStergereSortiment_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnAnulareSortiment = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\Pages\Pagina_Sortimente.xaml"
            this.btnAnulareSortiment.Click += new System.Windows.RoutedEventHandler(this.btnAnulareSortiment_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtCautaOrigine = ((System.Windows.Controls.TextBox)(target));
            
            #line 105 "..\..\..\Pages\Pagina_Sortimente.xaml"
            this.txtCautaOrigine.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtCautaOrigine_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.sortimenteDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 111 "..\..\..\Pages\Pagina_Sortimente.xaml"
            this.sortimenteDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.sortimenteDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.codSortimentColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 14:
            this.codProducatorColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 15:
            this.origineColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 16:
            this.sortimentColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
