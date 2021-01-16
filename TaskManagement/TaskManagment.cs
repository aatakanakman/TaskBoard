using System;
using System.Collections;
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
        
        DataTable tablo = new DataTable();
        database db = new database();
        int sira;
        int sira2;


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

            //SqlDataAdapter da = new SqlDataAdapter("Select proje_id,proje_name From tbl_proje", db.baglanti());
            //da.Fill(tablo);
            //dataGridView1.DataSource = tablo;
            ////return tablo;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ToDo.Items.Clear();
            InProgress.Items.Clear();
            Complated.Items.Clear();

             

            SqlCommand cmd = new SqlCommand("Select task_name,durum_id from tbl_task where proje_ad = @projead ", db.baglanti()); ;
            cmd.Parameters.AddWithValue("@projead", dataGridView1.CurrentRow.Cells["proje_name"].Value); 
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                Task task = new Task();
                task.name = (string)dr["task_name"];
                task.durumId =(int)dr["durum_id"];
                
                if(task.durumId == 1)
                {
                    ToDo.Items.Add(dr["task_name"]);
                   
                }
                else if (task.durumId == 2)
                {
                    InProgress.Items.Add(dr["task_name"]);
                    
                }
                else
                {
                    Complated.Items.Add(dr["task_name"]);
                    
                }
            }
        }



        private void ToDo_MouseDown(object sender, MouseEventArgs e)
        {
            Task task = new Task();
            task.name = ToDo.SelectedItem.ToString();
            task.durumId = 2;
            db.TaskDurumGuncelle(task);

            Point nokta = new Point(e.X, e.Y);
            sira = ToDo.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {
                ToDo.DoDragDrop(ToDo.Items[sira], DragDropEffects.All);
            }

        }
        private void InProgress_DragOver(object sender, DragEventArgs e)
        {
            if(e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }
        private void InProgress_DragDrop(object sender, DragEventArgs e)
        {
            InProgress.Items.Add(e.Data.GetData(DataFormats.StringFormat.ToString()));
            ToDo.Items.Remove(ToDo.Items[sira]);
        }

        private void InProgress_MouseDown(object sender, MouseEventArgs e)
        {
            Task task = new Task();
            task.name = InProgress.SelectedItem.ToString();
            task.durumId = 3;
            db.TaskDurumGuncelle(task);
            Point nokta1 = new Point(e.X, e.Y);
            sira2 = InProgress.IndexFromPoint(nokta1);
            if (e.Button == MouseButtons.Left)
            {
                InProgress.DoDragDrop(InProgress.Items[sira2], DragDropEffects.All);
            }
        }

        private void Complated_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void Complated_DragDrop(object sender, DragEventArgs e)
        {
            Complated.Items.Add(e.Data.GetData(DataFormats.StringFormat.ToString()));
            InProgress.Items.Remove(InProgress.Items[sira2]);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Proje prj = new Proje();
            prj.ad = (string)dataGridView1.CurrentRow.Cells["proje_name"].Value;
            prj.proje_id = (int)dataGridView1.CurrentRow.Cells["proje_id"].Value;
            db.projeSil(prj);
            dataGridView1.Refresh();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            UpdateTask update = new UpdateTask();
            update.ShowDialog();

            //AddTask addTask = new AddTask();
            //addTask.proje_name = (string)dataGridView1.CurrentRow.Cells["proje_name"].Value;
            //addTask.Show();

        }

        
    }
 }

