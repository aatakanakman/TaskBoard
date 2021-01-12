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

namespace TaskManagement
{
    public partial class TaskManagment : Form
    {
        database db = new database();
        
        
        public TaskManagment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTask add = new AddTask();
            add.Show();
            this.Hide();
        }

        private void TaskManagment_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'taskManagementDataSet.tbl_proje' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_projeTableAdapter.Fill(this.taskManagementDataSet.tbl_proje);

            //SqlCommand cmd = new SqlCommand("Select proje_id,proje_name From tbl_proje", db.baglanti());
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    ListViewItem item = new ListViewItem(dr["proje_name"].ToString());
            //    item.SubItems.Add(dr["proje_id"].ToString());
            //    listView1.Items.Add(item);
            //}

            SqlDataAdapter da = new SqlDataAdapter("Select proje_id,proje_name From tbl_proje", db.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            //return tablo;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTask add = new AddTask();
            add.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select task_name from tbl_task ", db.baglanti()); ;
            //cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[dataGridView1.Row[] )); //Girdiğimiz şifreye uygun kişiyi istedik
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Eğer veritabanında girdiğimiz şifre var ise bilgilerini değişkenlere atadık..
               label5.Text =   dr["task_name"].ToString();
                
            }
        }
    }
    }

