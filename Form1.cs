using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEKRAR_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Sinav class'ımızı newleyerek çağırıyoruz
            Sinav sinav = new Sinav();

            //sinav. diyerek clastaki propları textbox'a atıyoruz
            sinav.Vize1 = double.Parse(txtVize1.Text);
            sinav.Vize2 = double.Parse(txtVize2.Text);
            sinav.Final = double.Parse(txtFinal.Text);
            //sinav.Adi = txtSinavAdi.Text;


            //sinav. dedikten sonra metodumuzu çağırıyoruz 
            //metodumuzun sonucunu MessageBox'ta göstereceğimiz için değişkene atıyoruz
            double ortalamaSonuc = sinav.OrtalamaHesapla();



            MessageBox.Show($"Notunuz :{ortalamaSonuc}");

          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //SınavTip'i combobox'a atıyoruz
            foreach (var item in Enum.GetValues(typeof(SinavTip)))
            {
                cmbboxSinavTuru.Items.Add(item);
            }
            //ders adını combobox'a ekliyoruz
            foreach (var item in Enum.GetValues(typeof(DersAdi)))
            {
                cmbSinavAdi.Items.Add(item);
            }
        }
    }
}
