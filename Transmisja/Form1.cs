using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transmisja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //WYSLIJ
        {
            System.IO.File.WriteAllText(@"..\..\wiadomosc.txt", string.Empty);//wyczyszczenie  pliku
            FileStream plik = new FileStream(@"..\..\wiadomosc.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); //plik=wiadomosc.txt


            nadana = nadanaTextBox.Text.ToString(); //cała nasza wiadomośc w zmiennej: nadana

            antyWulgar();
            
            byte[] bitowa = System.Text.Encoding.ASCII.GetBytes(nadana);
            wiadomosc = kodowanie(bitowa);
            bitTextBox.Text = wiadomosc;
            
            for (int i = 0; i < wiadomosc.Length;i++) //zapis kazdego bitu po kolei
            {
                plik.WriteByte((byte)wiadomosc[i]);
            }
            plik.Close();
        }




        private void odczytajButton_Click(object sender, EventArgs e)
        {
           
            string text = System.IO.File.ReadAllText(@"..\..\wiadomosc.txt"); //w zmiennej text jest caly ciag binarny
            
            int i = 0;
            string wynikString=null;

            for (i = 0; i < text.Length;i=i+11)//dzialanie na całym bajcie
            {
               
                if (text[i] == '0' && text[i+9] == '1' && text[i+10] == '1')//bity startu i stopu czy sa ok
                {

                    wynikString += dekodowanie(text, i + 1);
                }
                else
                {
                    wynikString = null;
                    wynikString = "Plik uszkodzono";
                    odebranaTextBox.Text = wynikString;
                    return;
                }
                
             }
            odebranaTextBox.Text = wynikString;
            
        }

        public string kodowanie(byte[] ciag)    //z string na ASCII +bit start/stop
        {
            string wynikASCII = string.Empty;

            foreach (byte value in ciag)
            {

                binary = Convert.ToString(value, 2);
                while (binary.Length < 8)
                {
                    binary = "0" + binary;
                }
                wynikASCII += "0" + binary + "11";


            }

            return wynikASCII;
        }

        public string dekodowanie(string tekst, int i) //FUNKCJA ZAMIANY BITOW NA TEKST
        {
            string bity;
            
            bity = string.Copy(tekst.Substring(i,8));

           double suma = 0;

            for (int k = 0; k <8 ; k++)
            {
                if (bity[7-k] == '1') suma += Math.Pow(2,k);
                
            }   
            string litera = Convert.ToChar((int)suma).ToString();

            return litera;
           
        }

        public void antyWulgar()
        {
            slownik = new System.IO.StreamReader(@"..\..\slownik.txt"); // wczytanie naszego slownika, z google xD
            while ((wulgar = slownik.ReadLine()) != null) // tutaj on sie zapętla i czyta w pętli kolejno linijki ze slownika, czyli kazda petla = jakis wulgar w zmiennej wulgar
            {
                gwiazdki = null;

                if (nadana.Contains(wulgar))// fajna funkcja sprawdza czy string wulgar jest w stringu nadana
                {
                    for (int k = 0; k < wulgar.Length; k++) gwiazdki += "*"; //to nam tak dynamicznie tworzy ciąg gwiazdek zgodny z liczbą w wulgarze

                    nadana = nadana.Replace(wulgar, gwiazdki); //zamiana wulgara na gwiazdki
                    wulgar = null;

                }
            }

            slownik.Close(); // trza zamknac
        }

 
      
        private void odebranaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
