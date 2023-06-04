using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Nfz.Template.src.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy TableWindow.xaml
    /// </summary>
    public partial class TableWindow : Window
    {
        public TableWindow()
        {
            InitializeComponent();
            System.Windows.GridLength grid = new System.Windows.GridLength();
            TemplateTable.Columns.Add(new TableColumn() { Width = GridLength.Auto, Background = BorderBrush });

        }
    }
}
