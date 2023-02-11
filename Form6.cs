using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            getInfo();
        }

        public void getInfo()
        {
            string query = ("SELECT id_delivery as '№', client as 'ID клиента', cargo as 'ID Груза', truck as 'ID Грузовика', city as 'ID Города', date_delivery as 'Дата поставки' from delivery;");
            MySqlConnection conn = Class2.GetSqlConnection();
            MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                ada.Fill(dt);
                dataGridView5.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            client.Text = dataGridView5[1, dataGridView5.CurrentRow.Index].Value.ToString();
            cargo.Text = dataGridView5[2, dataGridView5.CurrentRow.Index].Value.ToString();
            truck.Text = dataGridView5[3, dataGridView5.CurrentRow.Index].Value.ToString();
            city.Text = dataGridView5[4, dataGridView5.CurrentRow.Index].Value.ToString();
            date.Text = dataGridView5[5, dataGridView5.CurrentRow.Index].Value.ToString();
        }

        private void butt_add_Click(object sender, EventArgs e)
        {
            string addwork = "insert into delivery (client, cargo, truck, city, date_delivery) values('" + client.Text + "' , '" + cargo.Text + "', '" + truck.Text + "' , '" + city.Text + "', '" + date.Text + "');";
            MySqlConnection conn = Class2.GetSqlConnection();
            MySqlCommand cmDB = new MySqlCommand(addwork, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                MessageBox.Show("Добавлено.");
                getInfo();
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла непредвиденная ошибка.");
            }
        }

        private void butt_update_Click(object sender, EventArgs e)
        {
            string update = "update delivery set client = '" + client.Text + "', cargo = '" + cargo.Text + "', truck = " + truck.Text + ", city = " + city.Text + ", date_delivery = '" + date.Text + "' where id_delivery = " + dataGridView5[0, dataGridView5.CurrentRow.Index].Value.ToString() + ";";
            MySqlConnection conn = Class2.GetSqlConnection();
            MySqlCommand cmDB = new MySqlCommand(update, conn);
            try
            {
                conn.Open();
                cmDB.ExecuteReader();
                conn.Close();
                MessageBox.Show("данные обновлены");
                getInfo();
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла непредвиденная ошибка.");
            }
        }

        private void butt_del_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Уверены, что хотите удалить данные?", "Вы уверены?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string del = "delete from delivery where id_delivery = " + dataGridView5[0, dataGridView5.CurrentRow.Index].Value.ToString() + ";";
                MySqlConnection conn = Class2.GetSqlConnection();
                MySqlCommand cmDB = new MySqlCommand(del, conn);
                try
                {
                    conn.Open();
                    cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("данные удалены");
                    getInfo();
                }
                catch (Exception)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка.");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
