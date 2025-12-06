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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr14_eliza.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public List<Items> items = new List<Items> ();
        public Main()
        {
            InitializeComponent();
            items.add(new Item("Шкаф", 20000, "ghjjh_5755763.jpg"));
            LoadItems();
        }
        public void LoadItems()
        {
            parent.Children.Clear ();
            foreach(Item item in items)
            {
                parent.Children.Add(new Elements.Item(item));
            }
        }
    }
}
