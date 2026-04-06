using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace MOTP.View
{
    public partial class Details : Window
    {
        Home _home;
        public Details(Home home)
        {
            InitializeComponent();
            _home = home;

            try
            {
                TB_Info.Text = _home.tmpval;
                TB_Prim.Text = _home.tmpprm;
                TB_Count.Text = _home.tmpcnt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void TBcount_Loaded(object sender, RoutedEventArgs e)
        {
            TB_Count.Focus();
        }

        private void BTSetKol_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _home.tmpstr = TB_Count.Text;

                int i = _home.tmpsnd.SelectedIndex;
                _home.tmpsnd.Items.RemoveAt(i);
                _home.tmpstt.RemoveAt(i);

                _home.tmpsnd.Items.Insert(i, $"{TB_Prim.Text} {TB_Info.Text} {_home.tmpstr}".Trim());
                _home.tmpstt.Insert(i, $"{TB_Prim.Text} {TB_Info.Text} {_home.tmpstr}".Trim());

                _home.tmpsnd.Items.Refresh();
                _home.tmpsnd.SelectedIndex = -1;

                Close();
            }
            catch
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _home.tmpstr = TB_Count.Text;

                int i = _home.tmpsnd.SelectedIndex;
                _home.tmpsnd.Items.RemoveAt(i);
                _home.tmpstt.RemoveAt(i);

                _home.tmpsnd.Items.Refresh();
                _home.tmpsnd.SelectedIndex = -1;

                Close();
            }
            catch
            {
                Debug.WriteLine(e.ToString());
            }

            Close();
        }

        private void TBcount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BTSetKol_Click(sender, e);

                Close();
            }
        }

        private void BTweb_Click(object sender, RoutedEventArgs e)
        {
            string[] splstr1 = TB_Info.ToString().Trim().Split(' ', '_');
            string[] splstr2 = TB_Info.ToString().Trim().Split(' ');

            Process.Start(new ProcessStartInfo($"https://{splstr1[1]}.zappstore.pro/pallet/{splstr2[1]}") { UseShellExecute = true });
        }

        private void TB_Count_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Count.SelectAll();
        }

        private void TB_Info_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Info.SelectAll();
        }

        private void TB_Prim_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Prim.SelectAll();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            _home.tmpsnd.Items.Refresh();
            _home.tmpsnd.SelectedIndex = -1;
        }

        private void TB_Prim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BTSetKol_Click(sender, e);

                Close();
            }
        }

        private void TB_Info_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BTSetKol_Click(sender, e);

                Close();
            }
        }
    }
}
