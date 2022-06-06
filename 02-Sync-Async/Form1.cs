using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Sync_Async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            Topla(int.Parse(textBox1.Text), int.Parse(textBox2.Text));


        }

        private async void btnCarp_Click(object sender, EventArgs e)
        {
           //await CarpAsync(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            MessageBox.Show("İşlem Tamamlandı.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Topla(int sayi1,int sayi2)
        {
            MessageBox.Show($"Toplam : {sayi1+sayi2}");
        }
        private void CarpAsync(int sayi1, int sayi2)
        {
            MessageBox.Show($"Çarpım : {sayi1*sayi2}");
        }

        private Task CarpmAsync(int sayi1, int sayi2) => Task.Run(() =>
                                                                   {
                                                                       Thread.Sleep(1000);
                                                                       MessageBox.Show("Çarpım = "+sayi1*sayi2);
                                                                   });

    }
}
