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
using System.IO;

namespace Könyvtár
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    class Anyagok
    {
        public int kid;
        public string szerzo;
        public string cim;
        public string kiev;
        public string kiado;
        public string kolcs;
        public bool kolcsonz;
        public Anyagok(string sor)
        {
            string[] resz = sor.Split(';');
            kid = Convert.ToInt32(resz[0]);
            szerzo = resz[1];
            cim = resz[2];
            kiev = resz[3];
            kiado = resz[4];
            kolcs = resz[5];
            if (resz[5] == "True")
                kolcsonz = true;
            else
                kolcsonz = false;
        }
    }

    class Tagok
    {
        public int tid;
        public string nev;
        public string szület;
        public string inysz;
        public string lakc;

        public Tagok(string sor)
        {
            string[] resz = sor.Split(';');
            tid = Convert.ToInt32(resz[0]);
            nev = resz[1];
            szület = resz[2];
            inysz = resz[3];
            lakc = resz[4];

        }
    }
     
   

    class feladat2
    {
        List<Tagok> adatoksz = new List<Tagok>();
        public feladat2(string kid)
        {
            foreach (var item in File.ReadAllLines(kid))
            {
                adatoksz.Add(new Tagok(item));
            }
        } 
    }



    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            class feladat
            {
            List<Anyagok> adatok = new List<Anyagok>();
            public feladat(string kid)
            {
                foreach (var item in File.ReadAllLines(kid))
                {
                    adatok.Add(new Anyagok(item));
                }
            }


            }
        }
    }
}
