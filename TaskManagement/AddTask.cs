using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagement
{
    public partial class AddTask : Form
    {
        database db = new database();
        Proje prj = new Proje();
        Task task = new Task();
        public AddTask()
        {
            InitializeComponent();
        }

        private void txt_aciklama_Enter(object sender, EventArgs e)
        {
            if(txt_aciklama.Text == "İşin Açıklaması")
            {
                txt_aciklama.Text = "";
            }
        }

        private void txt_not_Enter(object sender, EventArgs e)
        {
            if(txt_not.Text == "Notlar:")
            {
                txt_not.Text = "";
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            task.proje_ad = txt_projeAd.Text; 
            if(Convert.ToString(timepicker.Value) == "" && txt_projeAd.Text == "")
            {
                MessageBox.Show("Proje adı ve Tarih boş geçilemez");
               
            }
            else
            {
                

                prj.ad = txt_projeAd.Text;
                prj.tarih = Convert.ToString(timepicker.Value);
                prj.aciklama = txt_aciklama.Text;
                prj.not = txt_not.Text;
                prj.tahminiSure = txt_tahminsure.Text;
                prj.gercekSure = txt_gerceksure.Text;
                prj.userId = 1;

                task.proje_ad = is1.Text;
                task.date = tarih1.Text;
                task.desc = aciklama1.Text;
                task.durumId = 1;

                db.taskEkle(task);

                db.projeEkle(prj);

                TaskManagment task1 = new TaskManagment();
                task1.Show();
                this.Hide();

            }
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void AddTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            TaskManagment task = new TaskManagment();
            task.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("To Do = 1 || In Progress = 2 || Complated = 3 ");
        }
    }
}
