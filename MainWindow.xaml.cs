using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestMah
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ViewModel();
        }
    }

    public class ViewModel
    {
        public ViewModel()
        {
            Items.Add(new ItemsViewModel() { Name = "Option A" });
            Items.Add(new ItemsViewModel() { Name = "Option B" });
        }

        public ObservableCollection<ItemsViewModel> Items { get; } = new ObservableCollection<ItemsViewModel>();
    }

    public class ItemsViewModel
    {
        public string Name { get; set; }
    }
}
