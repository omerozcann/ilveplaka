using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace ilplaka
{
    public partial class ilplakaFrm : Form
    {
        SortedList<String, String> plakalar = new SortedList<string, string>();//bu dizide plakalar anahtar değer olacak il adları veri olacak.
        SortedList<String, String> iladlari = new SortedList<string, string>();//bu dizide il adları anahtar değer olacak plakalar veri olacak.

        public ilplakaFrm()//Burası yapılandırıcı metottur. ilplakaFrm ilk çalıştığında burası otomatik çağrılır
        {
            InitializeComponent();
            hazirla();
        }

        public void hazirla()
        {
            StreamReader sr = new StreamReader("ilplaka.txt");
            while(sr.EndOfStream==false)//dosya sonuna gelinmediği sürece dön
            {
                String satir = sr.ReadLine();//dosyadan 1 satır veri oku
                String[] dizi = satir.Split(' ');//veriler arasındaki boşluğa göre string dizisine dönüştür
                plakalar.Add(dizi[0], dizi[1]);
                iladlari.Add(dizi[1], dizi[0]);
            }
            sr.Close();
        }

        private void iladisorgulaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sonucTxt.Text = plakalar[plakaTxt.Text];
            }
            catch(KeyNotFoundException) 
            {
                MessageBox.Show("Böyle Bir Plaka Kodu Yok");         
            }
            
        }

        private void plakasorgulaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sonucTxt.Text = iladlari[iladiTxt.Text];
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Böyle Bir İl Adı Yok");
            }
        }
    }
}
