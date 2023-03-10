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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            getInfo();
        }

        public void getInfo()
        {
            string query = ("SELECT id_truck as '№', numb as 'ГОС номер', Driver as 'ФИО водителя' from truck;");
            MySqlConnection conn = Class2.GetSqlConnection();
            MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                ada.Fill(dt);
                dataGridView3.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            numb.Text = dataGridView3[1, dataGridView3.CurrentRow.Index].Value.ToString();
            fio.Text = dataGridView3[2, dataGridView3.CurrentRow.Index].Value.ToString();
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            string addwork = "insert into truck (numb, Driver) values('" + numb.Text + "' , '" + fio.Text + "');";
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

        private void button2_Click(object sender, EventArgs e)
        {
            string update = "update truck set numb = '" + numb.Text + "', Driver = '" + fio.Text + "' where id_truck = " + dataGridView3[0, dataGridView3.CurrentRow.Index].Value.ToString() + ";";
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
                string del = "delete from truck where id_truck = " + dataGridView3[0, dataGridView3.CurrentRow.Index].Value.ToString() + ";";
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
