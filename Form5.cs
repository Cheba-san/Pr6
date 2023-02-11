using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            getInfo();
        }

        public void getInfo()
        {
            string query = ("SELECT id_city as '№', city_name as 'Город' from city;");
            MySqlConnection conn = Class2.GetSqlConnection();
            MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                ada.Fill(dt);
                dataGridView4.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            city.Text = dataGridView4[1, dataGridView4.CurrentRow.Index].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addclient = "insert into city (city_name) values('" + city.Text + "' );";
            MySqlConnection conn = Class2.GetSqlConnection();
            MySqlCommand cmDB = new MySqlCommand(addclient, conn);
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

        private void button2_Click(object sender, EventArgs e)
        {
            string update = "update city set city_name = '" + city.Text + "' where id_city = " + dataGridView4[0, dataGridView4.CurrentRow.Index].Value.ToString() + ";";
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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Уверены, что хотите удалить данные?", "Вы уверены?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string del = "delete from city where id_city = " + dataGridView4[0, dataGridView4.CurrentRow.Index].Value.ToString() + ";";
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
    }
}
