// Updated by XamlIntelliSenseFileGenerator 01.07.2021 16:13:23
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C026C7E710F0547204BA4B5A32E3463AB1BC67CBDEBEF3366190813FE03DD6E5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Burdock;
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


namespace Burdock
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Burdock;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.AddButton = ((System.Windows.Controls.Button)(target));

#line 20 "..\..\MainWindow.xaml"
                    this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.SearchFilter = ((System.Windows.Controls.TextBox)(target));

#line 22 "..\..\MainWindow.xaml"
                    this.SearchFilter.KeyUp += new System.Windows.Input.KeyEventHandler(this.SearchFilter_KeyUp);

#line default
#line hidden

#line 22 "..\..\MainWindow.xaml"
                    this.SearchFilter.GotFocus += new System.Windows.RoutedEventHandler(this.SearchFilter_GotFocus);

#line default
#line hidden
                    return;
                case 3:
                    this.ProdTypeFilter = ((System.Windows.Controls.ComboBox)(target));

#line 28 "..\..\MainWindow.xaml"
                    this.ProdTypeFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProdTypeFilter_SelectionChanged);

#line default
#line hidden
                    return;
                case 4:
                    this.SortFilter = ((System.Windows.Controls.ComboBox)(target));

#line 46 "..\..\MainWindow.xaml"
                    this.SortFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortFilter_SelectionChanged);

#line default
#line hidden
                    return;
                case 5:
                    this.ListViewProduct = ((System.Windows.Controls.ListView)(target));

#line 49 "..\..\MainWindow.xaml"
                    this.ListViewProduct.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListViewProduct_MouseDoubleClick);

#line default
#line hidden
                    return;
                case 6:
                    this.PrevPage = ((System.Windows.Controls.Button)(target));

#line 87 "..\..\MainWindow.xaml"
                    this.PrevPage.Click += new System.Windows.RoutedEventHandler(this.PrevPage_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.NextPage = ((System.Windows.Controls.Button)(target));

#line 89 "..\..\MainWindow.xaml"
                    this.NextPage.Click += new System.Windows.RoutedEventHandler(this.NextPage_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button EditOrdBtn;
        internal System.Windows.Controls.Button DelOrdBtn;
        internal System.Windows.Controls.Button ExitButton;
        internal System.Windows.Controls.ComboBox DiscountFilterComboBox;
        internal System.Windows.Controls.TextBox SearchFilterTextBox;
        internal System.Windows.Controls.ListView ProductListView;
    }
}

