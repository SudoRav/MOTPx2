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

namespace MOTP.View
{
    public partial class Dop : Window
    {
        private Home _home;
        private List<string> _listSave;
        private List<string> _listZas;
        public Dop(Home home, List<string> listSave, List<string> listZas)
        {
            InitializeComponent();
            _home = home;
            _listSave = listSave;
            _listZas = listZas;
        }

        private void ListSave_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string item in _listSave)
                ListSave.Items.Add(item);
        }

        private void ListZas_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string item in _listZas)
                ListZas.Items.Add(item);
        }

        private void ListSave_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _home.ListSelectionWeb(ListSave, _listSave, false);
        }

        private void ListZas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _home.ListSelectionWeb(ListZas, _listZas, false);
        }

        private void BTN_ClrSave_Click(object sender, RoutedEventArgs e)
        {
            _home.ClrList(ListSave, _listSave);
        }

        private void BTN_ClrZas_Click(object sender, RoutedEventArgs e)
        {
            _home.ClrList(ListZas, _listZas);
        }
    }
}
