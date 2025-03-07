﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DESKTOP_APP
{
    public partial class UC_DELETE : UserControl
    {
        Function_db fn3 = new Function_db();
        String query;
        public UC_DELETE()
        {
            InitializeComponent();
        }

        private void UC_DELETE_Load(object sender, EventArgs e)
        {
            Delllable.Text = "How to DELETE ?";
            Delllable.ForeColor = Color.Blue;
            LoadData();

        }

        public void LoadData()
        {
            query = "select * from details";
            DataSet ds = fn3.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from details where name like '" + txtSearch.Text + "%'";
            DataSet ds = fn3.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete item?", "important Meassage", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from details where iid=" + id + "";
                fn3.SetData(query);
                LoadData();

            }
        }

        private void Delllable_Click(object sender, EventArgs e)
        {
            Delllable.ForeColor = Color.Red;
            Delllable.Text = "click on row to delete";
        }

        private void UC_DELETE_Enter(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
