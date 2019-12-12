﻿using ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erripeg.ObjectModel
{
    public partial class SelectSession : Form
    {
        Connection connection = new Connection();
        SqlCommand cmd = new SqlCommand();
        public SelectSession()
        {
            InitializeComponent();
            //selectSessionDataGridView.Columns[0].HeaderText = "id";
            
            //selectSessionDataGridView.Columns[0].Width = 100;
            
            this.List("select * from section");
            SessionDataGridView.Columns[1].HeaderText = "historia";
            SessionDataGridView.Columns[1].Width = 432;
        }
        private void ShowSessions()
        {
            ConnectionsQuerys con = new ConnectionsQuerys();
            SqlDataReader reader = con.GetSessions();
            SessionDataGridView.DataSource = reader;
        }

        private void CreateSessionButton_Click(object sender, EventArgs e)
        {
            CriarSessão c = new CriarSessão();
            c.Show();
            this.Dispose();
        }

        private void SelectSessionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectSession_Load(object sender, EventArgs e)
        {
            
        }

        public void List(String sql)
        {
            try
            {
                cmd.Connection = connection.Connect();
                cmd = new SqlCommand(sql, cmd.Connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                da.Fill(ds);
                SessionDataGridView.DataSource = ds;
                SessionDataGridView.DataMember = da.TableMappings[0].DataSetTable;

            }
            catch(Exception ex)
            {
                cmd.Dispose();
                connection.Disconnect();
            }
            finally
            {
                cmd.Dispose();
                connection.Disconnect();
            }
        }

        private void SelectSessionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CriaçãoPersonagem d = new CriaçãoPersonagem();

            int index = e.RowIndex;
            DataGridViewRow selectedRow = SessionDataGridView.Rows[index];
            Usuario.id_sessao = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            Usuario.mestre = Int32.Parse(selectedRow.Cells[2].Value.ToString());

            d.Show();
            this.Dispose();
        }

        private void SessionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CriaçãoPersonagem d = new CriaçãoPersonagem();

            int index = e.RowIndex;
            DataGridViewRow selectedRow = SessionDataGridView.Rows[index];
            Usuario.id_sessao = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            Usuario.mestre = Int32.Parse(selectedRow.Cells[2].Value.ToString());

            d.Show();
            this.Dispose();
        }

        private void SessionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
