﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLaundryVS
{
    public partial class MainMenu : UserControl
    {


        public MainMenu()
        {
            InitializeComponent();
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            MainForm.moveToPembayaran = true;
        }
        private void btnPesanan_Click(object sender, EventArgs e)
        {
            MainForm.moveToPesanan = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.moveToRiwayat = true;
        }
    }
}
