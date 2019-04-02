using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {
            nadana = nadanaTextBox.Text.ToString();
            byte[] arr = System.Text.Encoding.ASCII.GetBytes(nadana);
            string wiadomosc = Format(arr);
            bitTextBox.Text = wiadomosc;
            
            for (int i = 0; i < wiadomosc.Length;i++)
            {
                plik.WriteByte((byte)wiadomosc[i]);
           }
            plik.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string Format(byte[] data)
        {
            //storage for the resulting string
            string result = string.Empty;
            
            //iterate through the byte[]
            foreach (byte value in data)
            {
                
                //storage for the individual byte
                string binarybyte = Convert.ToString(value, 2);
                //if the binarybyte is not 8 characters long, its not a proper result
                while (binarybyte.Length < 8)
                {
                    //prepend the value with a 0
                    binarybyte = "0" + binarybyte;
                }
                //append the binarybyte to the result
                result +="0"+ binarybyte+"11";
                

            }
            //return the result
            return result;
        }
    }
}
