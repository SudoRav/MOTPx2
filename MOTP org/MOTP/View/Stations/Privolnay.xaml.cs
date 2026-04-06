using MOTP.View;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace MOTP.View.Stations
{
    public partial class Privolnay : UserControl
    {
        Home _home = new Home();
        public Privolnay()
        {
            InitializeComponent();
        }

        private void TBNacl_Loaded(object sender, RoutedEventArgs e)
        {
            TBNacl.Focus();
        }

        private void CBType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _home.SetCB(CBType, TBNacl, TBPlmb);
        }


        private void TBNacl_KeyDown(object sender, KeyEventArgs e)
        {
            TBNacl.Text = TBNacl.Text.Trim();

            if (_home.SetType(e, TBNacl.Text, CBType))
                return;

            if (e.Key == Key.Enter)
            {
                if (!_home.FormStr(TBNacl.Text, CBType.SelectedIndex, false))
                {
                    System.Media.SystemSounds.Hand.Play();
                    _home.ClearEnter(TBNacl, TBPlmb);
                    return;
                }

                if (CBType.SelectedIndex == 0 || CBType.SelectedIndex == 1 || CBType.SelectedIndex == 4 || CBType.SelectedIndex == 5)
                {
                    switch (CBType.SelectedIndex)
                    {
                        case 0:
                            _home.AddProd(Stat.Privolnay._listPal, Stat.Privolnay._listGM, Stat.Privolnay._listMesh, Stat.Privolnay._listCont, Stat.Privolnay._listSave, Stat.Privolnay._listZas,
                                              Stat.Privolnay._listPal, TBNacl, TBPlmb, "паллет", ListPal); break;
                        case 1:
                            _home.AddProd(Stat.Privolnay._listPal, Stat.Privolnay._listGM, Stat.Privolnay._listMesh, Stat.Privolnay._listCont, Stat.Privolnay._listSave, Stat.Privolnay._listZas,
                                              Stat.Privolnay._listGM, TBNacl, TBPlmb, "гм", ListGM); break;

                        case 4:
                            _home.AddProd(Stat.Privolnay._listPal, Stat.Privolnay._listGM, Stat.Privolnay._listMesh, Stat.Privolnay._listCont, Stat.Privolnay._listSave, Stat.Privolnay._listZas,
                                              Stat.Privolnay._listSave, TBNacl, TBPlmb, "сейфпакет"); break;
                        case 5:
                            _home.AddProd(Stat.Privolnay._listPal, Stat.Privolnay._listGM, Stat.Privolnay._listMesh, Stat.Privolnay._listCont, Stat.Privolnay._listSave, Stat.Privolnay._listZas,
                                              Stat.Privolnay._listZas, TBNacl, TBPlmb, "засыл"); break;
                    }
                }

                TBPlmb.Focus();
            }
        }

        private void TBPlmb_KeyDown(object sender, KeyEventArgs e)
        {
            TBPlmb.Text = TBPlmb.Text.Trim();

            if (_home.SetType(e, TBNacl.Text, CBType))
                return;

            if (e.Key == Key.Enter)
            {
                if (!_home.FormStr(TBPlmb.Text, CBType.SelectedIndex, true))
                {
                    System.Media.SystemSounds.Hand.Play();
                    _home.ClearEnter(TBNacl, TBPlmb);
                    return;
                }

                if (CBType.SelectedIndex == 2 || CBType.SelectedIndex == 3)
                {
                    switch (CBType.SelectedIndex)
                    {
                        case 2:
                            _home.AddProd(Stat.Privolnay._listPal, Stat.Privolnay._listGM, Stat.Privolnay._listMesh, Stat.Privolnay._listCont, Stat.Privolnay._listSave, Stat.Privolnay._listZas,
                                              Stat.Privolnay._listMesh, TBNacl, TBPlmb, "мешок", ListMesh); break;
                        case 3:
                            _home.AddProd(Stat.Privolnay._listPal, Stat.Privolnay._listGM, Stat.Privolnay._listMesh, Stat.Privolnay._listCont, Stat.Privolnay._listSave, Stat.Privolnay._listZas,
                                              Stat.Privolnay._listCont, TBNacl, TBPlmb, "контейнер", ListCont); break;
                    }
                }
            }
        }

        private void RTBoooinn_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            RTBoooinn.SelectAll();
        }

        private void RTBMarch_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            RTBMarch.SelectAll();
        }

        private void RTBdt_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            RTBdt.SelectAll();
        }
        private void TB_Auto1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Auto1.SelectAll();
        }

        private void TB_Auto2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TB_Auto2.SelectAll();
        }

        private void ListPal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _home.ListSelectionWeb(ListPal, Stat.Privolnay._listPal, false);
        }

        private void ListGM_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _home.ListSelectionWeb(ListGM, Stat.Privolnay._listGM, false);
        }

        private void ListMesh_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _home.ListSelectionWeb(ListMesh, Stat.Privolnay._listMesh, true);
        }

        private void ListCont_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _home.ListSelectionWeb(ListCont, Stat.Privolnay._listCont, true);
        }

        public void BTN_Otch_Click(object sender, RoutedEventArgs e)
        {
            _home.FormOtch(Stat.Privolnay._listPal, Stat.Privolnay._listGM, Stat.Privolnay._listMesh, Stat.Privolnay._listCont, Stat.Privolnay._listSave, Stat.Privolnay._listZas,
                           TB_Martch2.Text, TB_autoplomb.Text, RTBoooinn, RTBMarch, RTBdt, TB_Auto1.Text, TB_Auto2.Text);
        }

        private void ListPal_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string item in Stat.Privolnay._listPal)
                ListPal.Items.Add(item);
        }

        private void ListGM_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string item in Stat.Privolnay._listGM)
                ListGM.Items.Add(item);
        }

        private void ListMesh_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string item in Stat.Privolnay._listMesh)
                ListMesh.Items.Add(item);
        }

        private void ListCont_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string item in Stat.Privolnay._listCont)
                ListCont.Items.Add(item);
        }


        private void RTBoooinn_Loaded(object sender, RoutedEventArgs e)
        {
            FlowDocument document = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(new Bold(new Run(Stat.Privolnay.oooinn)));
            document.Blocks.Add(paragraph);
            RTBoooinn.Document = document;
        }

        private void TB_FIO_Loaded(object sender, RoutedEventArgs e)
        {
            TB_FIO.Text = Stat.Privolnay.fio;
        }

        private void RTBMarch_Loaded(object sender, RoutedEventArgs e)
        {
            FlowDocument document = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(new Bold(new Run(Stat.Privolnay.march)));
            document.Blocks.Add(paragraph);
            RTBMarch.Document = document;
        }

        private void TB_Martch2_Loaded(object sender, RoutedEventArgs e)
        {
            TB_Martch2.Text = Stat.Privolnay.march2;
        }

        private void RTBdt_Loaded(object sender, RoutedEventArgs e)
        {
            FlowDocument document = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(new Bold(new Run(Stat.Privolnay.dt)));
            document.Blocks.Add(paragraph);
            RTBdt.Document = document;
        }

        private void TB_Auto1_Loaded(object sender, RoutedEventArgs e)
        {
            TB_Auto1.Text = Stat.Privolnay.auto1;
        }

        private void TB_Auto2_Loaded(object sender, RoutedEventArgs e)
        {
            TB_Auto2.Text = Stat.Privolnay.auto2;
        }

        private void BTN_ClrPal_Click(object sender, RoutedEventArgs e)
        {
            _home.ClrList(ListPal, Stat.Privolnay._listPal);
        }

        private void BTN_ClrGM_Click(object sender, RoutedEventArgs e)
        {
            _home.ClrList(ListGM, Stat.Privolnay._listGM);
        }

        private void BTN_ClrMesh_Click(object sender, RoutedEventArgs e)
        {
            _home.ClrList(ListMesh, Stat.Privolnay._listMesh);
        }

        private void BTN_ClrCont_Click(object sender, RoutedEventArgs e)
        {
            _home.ClrList(ListCont, Stat.Privolnay._listCont);
        }

        private void RTBoooinn_LostFocus(object sender, RoutedEventArgs e)
        {
            Stat.Privolnay.oooinn = new TextRange(RTBoooinn.Document.ContentStart, RTBoooinn.Document.ContentEnd).Text;
        }

        private void TB_FIO_LostFocus(object sender, RoutedEventArgs e)
        {
            Stat.Privolnay.fio = TB_FIO.Text;
        }

        private void RTBMarch_LostFocus(object sender, RoutedEventArgs e)
        {
            Stat.Privolnay.march = new TextRange(RTBMarch.Document.ContentStart, RTBMarch.Document.ContentEnd).Text;
        }

        private void TB_Martch2_LostFocus(object sender, RoutedEventArgs e)
        {
            Stat.Privolnay.march2 = TB_Martch2.Text;
        }

        private void RTBdt_LostFocus(object sender, RoutedEventArgs e)
        {
            Stat.Privolnay.dt = new TextRange(RTBdt.Document.ContentStart, RTBdt.Document.ContentEnd).Text;
        }

        private void TB_Auto1_LostFocus(object sender, RoutedEventArgs e)
        {
            Stat.Privolnay.auto1 = TB_Auto1.Text;
        }

        private void TB_Auto2_LostFocus(object sender, RoutedEventArgs e)
        {
            Stat.Privolnay.auto2 = TB_Auto2.Text;
        }

        private void BTN_DopLists_Click(object sender, RoutedEventArgs e)
        {
            _home.OpenDop(Stat.Privolnay._listSave, Stat.Privolnay._listZas);
        }

        private void BTN_Sett_Click(object sender, RoutedEventArgs e)
        {
            _home.OpenSett(4);
        }

        private void BTN_Form_Click(object sender, RoutedEventArgs e)
        {
            _home.FormDoc(Stat.Privolnay._listPal, Stat.Privolnay._listGM, Stat.Privolnay._listMesh, Stat.Privolnay._listCont, Stat.Privolnay._listSave, Stat.Privolnay._listZas,
                          RTBoooinn, TB_FIO, RTBMarch, TB_Phone, RTBdt, TB_Auto1, TB_Auto2, Stat.Privolnay.sdach, Stat.Privolnay.poluch);
        }
    }
}
