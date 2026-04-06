using MOTP.View;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace MOTP.View.Stations
{
    public partial class Pererva : UserControl
    {
        Home _home = new Home();
        public Pererva()
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
                            _home.AddProd(Stat.Pererva._listPal, Stat.Pererva._listGM, Stat.Pererva._listMesh, Stat.Pererva._listCont, Stat.Pererva._listSave, Stat.Pererva._listZas,
                                              Stat.Pererva._listPal, TBNacl, TBPlmb, "паллет", ListPal); break;
                        case 1:
                            _home.AddProd(Stat.Pererva._listPal, Stat.Pererva._listGM, Stat.Pererva._listMesh, Stat.Pererva._listCont, Stat.Pererva._listSave, Stat.Pererva._listZas,
                                              Stat.Pererva._listGM, TBNacl, TBPlmb, "гм", ListGM); break;

                        case 4:
                            _home.AddProd(Stat.Pererva._listPal, Stat.Pererva._listGM, Stat.Pererva._listMesh, Stat.Pererva._listCont, Stat.Pererva._listSave, Stat.Pererva._listZas,
                                              Stat.Pererva._listSave, TBNacl, TBPlmb, "сейфпакет"); break;
                        case 5:
                            _home.AddProd(Stat.Pererva._listPal, Stat.Pererva._listGM, Stat.Pererva._listMesh, Stat.Pererva._listCont, Stat.Pererva._listSave, Stat.Pererva._listZas,
                                              Stat.Pererva._listZas, TBNacl, TBPlmb, "засыл"); break;
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
                            _home.AddProd(Stat.Pererva._listPal, Stat.Pererva._listGM, Stat.Pererva._listMesh, Stat.Pererva._listCont, Stat.Pererva._listSave, Stat.Pererva._listZas,
                                              Stat.Pererva._listMesh, TBNacl, TBPlmb, "мешок", ListMesh); break;
                        case 3:
                            _home.AddProd(Stat.Pererva._listPal, Stat.Pererva._listGM, Stat.Pererva._listMesh, Stat.Pererva._listCont, Stat.Pererva._listSave, Stat.Pererva._listZas,
                                              Stat.Pererva._listCont, TBNacl, TBPlmb, "контейнер", ListCont); break;
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
            _home.ListSelectionWeb(ListPal, Stat.Pererva._listPal, false);
        }

        private void ListGM_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _home.ListSelectionWeb(ListGM, Stat.Pererva._listGM, false);
        }

        private void ListMesh_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _home.ListSelectionWeb(ListMesh, Stat.Pererva._listMesh, true);
        }

        private void ListCont_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _home.ListSelectionWeb(ListCont, Stat.Pererva._listCont, true);
        }

        public void BTN_Otch_Click(object sender, RoutedEventArgs e)
        {
            _home.FormOtch(Stat.Pererva._listPal, Stat.Pererva._listGM, Stat.Pererva._listMesh, Stat.Pererva._listCont, Stat.Pererva._listSave, Stat.Pererva._listZas,
                           TB_Martch2.Text, TB_autoplomb.Text, RTBoooinn, RTBMarch, RTBdt, TB_Auto1.Text, TB_Auto2.Text);
        }

        private void ListPal_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string item in Stat.Pererva._listPal)
                ListPal.Items.Add(item);
        }

        private void ListGM_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string item in Stat.Pererva._listGM)
                ListGM.Items.Add(item);
        }

        private void ListMesh_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string item in Stat.Pererva._listMesh)
                ListMesh.Items.Add(item);
        }

        private void ListCont_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string item in Stat.Pererva._listCont)
                ListCont.Items.Add(item);
        }


        private void RTBoooinn_Loaded(object sender, RoutedEventArgs e)
        {
            FlowDocument document = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(new Bold(new Run(Stat.Pererva.oooinn)));
            document.Blocks.Add(paragraph);
            RTBoooinn.Document = document;
        }

        private void TB_FIO_Loaded(object sender, RoutedEventArgs e)
        {
            TB_FIO.Text = Stat.Pererva.fio;
        }

        private void RTBMarch_Loaded(object sender, RoutedEventArgs e)
        {
            FlowDocument document = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(new Bold(new Run(Stat.Pererva.march)));
            document.Blocks.Add(paragraph);
            RTBMarch.Document = document;
        }

        private void TB_Martch2_Loaded(object sender, RoutedEventArgs e)
        {
            TB_Martch2.Text = Stat.Pererva.march2;
        }

        private void RTBdt_Loaded(object sender, RoutedEventArgs e)
        {
            FlowDocument document = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(new Bold(new Run(Stat.Pererva.dt)));
            document.Blocks.Add(paragraph);
            RTBdt.Document = document;
        }

        private void TB_Auto1_Loaded(object sender, RoutedEventArgs e)
        {
            TB_Auto1.Text = Stat.Pererva.auto1;
        }

        private void TB_Auto2_Loaded(object sender, RoutedEventArgs e)
        {
            TB_Auto2.Text = Stat.Pererva.auto2;
        }

        private void BTN_ClrPal_Click(object sender, RoutedEventArgs e)
        {
            _home.ClrList(ListPal, Stat.Pererva._listPal);
        }

        private void BTN_ClrGM_Click(object sender, RoutedEventArgs e)
        {
            _home.ClrList(ListGM, Stat.Pererva._listGM);
        }

        private void BTN_ClrMesh_Click(object sender, RoutedEventArgs e)
        {
            _home.ClrList(ListMesh, Stat.Pererva._listMesh);
        }

        private void BTN_ClrCont_Click(object sender, RoutedEventArgs e)
        {
            _home.ClrList(ListCont, Stat.Pererva._listCont);
        }

        private void RTBoooinn_LostFocus(object sender, RoutedEventArgs e)
        {
            Stat.Pererva.oooinn = new TextRange(RTBoooinn.Document.ContentStart, RTBoooinn.Document.ContentEnd).Text;
        }

        private void TB_FIO_LostFocus(object sender, RoutedEventArgs e)
        {
            Stat.Pererva.fio = TB_FIO.Text;
        }

        private void RTBMarch_LostFocus(object sender, RoutedEventArgs e)
        {
            Stat.Pererva.march = new TextRange(RTBMarch.Document.ContentStart, RTBMarch.Document.ContentEnd).Text;
        }

        private void TB_Martch2_LostFocus(object sender, RoutedEventArgs e)
        {
            Stat.Pererva.march2 = TB_Martch2.Text;
        }

        private void RTBdt_LostFocus(object sender, RoutedEventArgs e)
        {
            Stat.Pererva.dt = new TextRange(RTBdt.Document.ContentStart, RTBdt.Document.ContentEnd).Text;
        }

        private void TB_Auto1_LostFocus(object sender, RoutedEventArgs e)
        {
            Stat.Pererva.auto1 = TB_Auto1.Text;
        }

        private void TB_Auto2_LostFocus(object sender, RoutedEventArgs e)
        {
            Stat.Pererva.auto2 = TB_Auto2.Text;
        }

        private void BTN_DopLists_Click(object sender, RoutedEventArgs e)
        {
            _home.OpenDop(Stat.Pererva._listSave, Stat.Pererva._listZas);
        }

        private void BTN_Sett_Click(object sender, RoutedEventArgs e)
        {
            _home.OpenSett(11);
        }

        private void BTN_Form_Click(object sender, RoutedEventArgs e)
        {
            _home.FormDoc(Stat.Pererva._listPal, Stat.Pererva._listGM, Stat.Pererva._listMesh, Stat.Pererva._listCont, Stat.Pererva._listSave, Stat.Pererva._listZas,
                          RTBoooinn, TB_FIO, RTBMarch, TB_Phone, RTBdt, TB_Auto1, TB_Auto2, Stat.Pererva.sdach, Stat.Pererva.poluch);
        }
    }
}
