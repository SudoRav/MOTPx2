using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    public partial class Sett : Window
    {
        private Home _home;
        private int _numststion;
        public Sett(Home home, int numststion)
        {
            InitializeComponent();
            _home = home;
            _numststion = numststion;
        }


        private void RTB_Sdach_Loaded(object sender, RoutedEventArgs e)
        {
            FlowDocument document = new FlowDocument();
            Paragraph paragraph = new Paragraph();

            //переделай как нибудь
            switch (_numststion)
            {
                case 1: paragraph.Inlines.Add(new Bold(new Run(Stat.Himki.sdach))); break;
                case 2: paragraph.Inlines.Add(new Bold(new Run(Stat.Marta.sdach))); break;
                case 3: paragraph.Inlines.Add(new Bold(new Run(Stat.Puhkino.sdach))); break;
                case 4: paragraph.Inlines.Add(new Bold(new Run(Stat.Privolnay.sdach))); break;
                case 5: paragraph.Inlines.Add(new Bold(new Run(Stat.Vehki.sdach))); break;
                case 6: paragraph.Inlines.Add(new Bold(new Run(Stat.Rybinovay.sdach))); break;
                case 7: paragraph.Inlines.Add(new Bold(new Run(Stat.Sharapovo.sdach))); break;
                case 8: paragraph.Inlines.Add(new Bold(new Run(Stat.Helkovskay.sdach))); break;
                case 9: paragraph.Inlines.Add(new Bold(new Run(Stat.Odincovo.sdach))); break;
                case 10: paragraph.Inlines.Add(new Bold(new Run(Stat.Skladohnay.sdach))); break;
                case 11: paragraph.Inlines.Add(new Bold(new Run(Stat.Pererva.sdach))); break;
                case 12: paragraph.Inlines.Add(new Bold(new Run(Stat.BUhunskay.sdach))); break;
            }
                
            document.Blocks.Add(paragraph);
            RTB_Sdach.Document = document;
        }

        private void RTB_Poluch_Loaded(object sender, RoutedEventArgs e)
        {
            FlowDocument document = new FlowDocument();
            Paragraph paragraph = new Paragraph();

            switch (_numststion)
            {
                case 1: paragraph.Inlines.Add(new Bold(new Run(Stat.Himki.poluch))); break;
                case 2: paragraph.Inlines.Add(new Bold(new Run(Stat.Marta.poluch))); break;
                case 3: paragraph.Inlines.Add(new Bold(new Run(Stat.Puhkino.poluch))); break;
                case 4: paragraph.Inlines.Add(new Bold(new Run(Stat.Privolnay.poluch))); break;
                case 5: paragraph.Inlines.Add(new Bold(new Run(Stat.Vehki.poluch))); break;
                case 6: paragraph.Inlines.Add(new Bold(new Run(Stat.Rybinovay.poluch))); break;
                case 7: paragraph.Inlines.Add(new Bold(new Run(Stat.Sharapovo.poluch))); break;
                case 8: paragraph.Inlines.Add(new Bold(new Run(Stat.Helkovskay.poluch))); break;
                case 9: paragraph.Inlines.Add(new Bold(new Run(Stat.Odincovo.poluch))); break;
                case 10: paragraph.Inlines.Add(new Bold(new Run(Stat.Skladohnay.poluch))); break;
                case 11: paragraph.Inlines.Add(new Bold(new Run(Stat.Pererva.poluch))); break;
                case 12: paragraph.Inlines.Add(new Bold(new Run(Stat.BUhunskay.poluch))); break;
            }

            document.Blocks.Add(paragraph);
            RTB_Poluch.Document = document;
        }

        private void RTB_Sdach_LostFocus(object sender, RoutedEventArgs e)
        {
            switch (_numststion)
            {
                case 1: Stat.Himki.sdach = new TextRange(RTB_Sdach.Document.ContentStart, RTB_Sdach.Document.ContentEnd).Text; break;
                case 2: Stat.Marta.sdach = new TextRange(RTB_Sdach.Document.ContentStart, RTB_Sdach.Document.ContentEnd).Text; break;
                case 3: Stat.Puhkino.sdach = new TextRange(RTB_Sdach.Document.ContentStart, RTB_Sdach.Document.ContentEnd).Text; break;
                case 4: Stat.Privolnay.sdach = new TextRange(RTB_Sdach.Document.ContentStart, RTB_Sdach.Document.ContentEnd).Text; break;
                case 5: Stat.Vehki.sdach = new TextRange(RTB_Sdach.Document.ContentStart, RTB_Sdach.Document.ContentEnd).Text; break;
                case 6: Stat.Rybinovay.sdach = new TextRange(RTB_Sdach.Document.ContentStart, RTB_Sdach.Document.ContentEnd).Text; break;
                case 7: Stat.Sharapovo.sdach = new TextRange(RTB_Sdach.Document.ContentStart, RTB_Sdach.Document.ContentEnd).Text; break;
                case 8: Stat.Helkovskay.sdach = new TextRange(RTB_Sdach.Document.ContentStart, RTB_Sdach.Document.ContentEnd).Text; break;
                case 9: Stat.Odincovo.sdach = new TextRange(RTB_Sdach.Document.ContentStart, RTB_Sdach.Document.ContentEnd).Text; break;
                case 10: Stat.Skladohnay.sdach = new TextRange(RTB_Sdach.Document.ContentStart, RTB_Sdach.Document.ContentEnd).Text; break;
                case 11: Stat.Pererva.sdach = new TextRange(RTB_Sdach.Document.ContentStart, RTB_Sdach.Document.ContentEnd).Text; break;
                case 12: Stat.BUhunskay.sdach = new TextRange(RTB_Sdach.Document.ContentStart, RTB_Sdach.Document.ContentEnd).Text; break;
            }
        }

        private void RTB_Poluch_LostFocus(object sender, RoutedEventArgs e)
        {
            switch (_numststion)
            {
                case 1: Stat.Himki.poluch = new TextRange(RTB_Poluch.Document.ContentStart, RTB_Poluch.Document.ContentEnd).Text; break;
                case 2: Stat.Marta.poluch = new TextRange(RTB_Poluch.Document.ContentStart, RTB_Poluch.Document.ContentEnd).Text; break;
                case 3: Stat.Puhkino.poluch = new TextRange(RTB_Poluch.Document.ContentStart, RTB_Poluch.Document.ContentEnd).Text; break;
                case 4: Stat.Privolnay.poluch = new TextRange(RTB_Poluch.Document.ContentStart, RTB_Poluch.Document.ContentEnd).Text; break;
                case 5: Stat.Vehki.poluch = new TextRange(RTB_Poluch.Document.ContentStart, RTB_Poluch.Document.ContentEnd).Text; break;
                case 6: Stat.Rybinovay.poluch = new TextRange(RTB_Poluch.Document.ContentStart, RTB_Poluch.Document.ContentEnd).Text; break;
                case 7: Stat.Sharapovo.poluch = new TextRange(RTB_Poluch.Document.ContentStart, RTB_Poluch.Document.ContentEnd).Text; break;
                case 8: Stat.Helkovskay.poluch = new TextRange(RTB_Poluch.Document.ContentStart, RTB_Poluch.Document.ContentEnd).Text; break;
                case 9: Stat.Odincovo.poluch = new TextRange(RTB_Poluch.Document.ContentStart, RTB_Poluch.Document.ContentEnd).Text; break;
                case 10: Stat.Skladohnay.poluch = new TextRange(RTB_Poluch.Document.ContentStart, RTB_Poluch.Document.ContentEnd).Text; break;
                case 11: Stat.Pererva.poluch = new TextRange(RTB_Poluch.Document.ContentStart, RTB_Poluch.Document.ContentEnd).Text; break;
                case 12: Stat.BUhunskay.poluch = new TextRange(RTB_Poluch.Document.ContentStart, RTB_Poluch.Document.ContentEnd).Text; break;
            }
        }
    }
}
