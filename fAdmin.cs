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

namespace QuanlyquanCoffe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccoutList();

        }
        void LoadAccoutList()
        {
            string StrConnection = "Data Source=DESKTOP-6P3EB2J;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(StrConnection);
            string query = "select * from Account";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dtgvAccount.DataSource = data;


        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
