using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace HtmlTextBlockTestProj
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string HtmlStr { get { return "The [i][u]quick brown fox[/i][/u] jumps over the [b]lazy dog[/b]"; } }
        public Window1()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void HtmlTextBlock_Loaded(object sender, RoutedEventArgs e)
        {
            AddHandler(Hyperlink.ClickEvent, (RoutedEventHandler)Hyperlink_Click);
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Hyperlink)
            {
                Process.Start((e.OriginalSource as Hyperlink).NavigateUri.AbsoluteUri);
                e.Handled = true;
            }
        }
    }
}
