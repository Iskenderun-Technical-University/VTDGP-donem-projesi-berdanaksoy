﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VTDGP_donem_projesi_berdanaksoy
{
    public partial class yoneticiGirisEkranı : Form
    {
        public yoneticiGirisEkranı()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void button2_Click(object sender, EventArgs e)
        {
            anaEkran anaEkran = new anaEkran();
            anaEkran.Show();
            this.Hide();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM yoneticiGirisi where yoneticiAdi=@user AND sifre=@pass";
            con = new SqlConnection("server=BERDAN\\SQLEXPRESS; Initial Catalog=VTDGP Proje Restaurant;Integrated Security=SSPI");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            con.Close();
        }
    }
}
