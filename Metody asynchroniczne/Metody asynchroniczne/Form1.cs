using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody_asynchroniczne
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private async void downloadButton_Click(object sender, EventArgs e)
        {
            string downloaded_result = await DownloadContent(adres_tb.Text);
            pobranyPlik_rtb.Text = downloaded_result;
        }

        public static async Task<string> DownloadContent(string adres)
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync(adres);
                return result;
            }
        }

        private async void downloadAll_btn_Click(object sender, EventArgs e)
        {
            string downloaded_result = await DownloadAll(adresy_lb);
            pobranyPlik_rtb.Text = downloaded_result;
        }

        public static async Task<string> DownloadAll(ListBox adres)
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync(adres.SelectedItem.ToString());
                if (adres.SelectedIndex != adres.Items.Count-1)
                    adres.SelectedIndex++;
                return result;
            }
        }

        private async void rozmiar_btn_Click(object sender, EventArgs e)
        {
            int rozmiarPliku = await MyMethod(adres_tb.Text);
            pobranyPlik_rtb.Text = rozmiarPliku.ToString() + " znaków";
        }

        public static async Task<int> MyMethod(string adres)
        {
            string downloaded_result = await DownloadContent(adres);
            return downloaded_result.Length;
        }

        private async void pobierz100_btn_Click(object sender, EventArgs e)
        {
            string downloaded_result = await Download100(adres_tb.Text);
            pobranyPlik_rtb.Text = downloaded_result;
        }

        public static async Task<string> Download100(string adres)
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync(adres);
                return "\"" + result.Remove(100) + "\"";
            }
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            adresy_lb.Items.Add(adres_tb.Text);
        }        
    }
}
