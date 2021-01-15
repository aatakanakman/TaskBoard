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
        public string proje_name { get; set; }

        database db = new database();
        Proje prj = new Proje();
        Task task = new Task();
        Task task2 = new Task();
        Task task3 = new Task();
        Task task4 = new Task();
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

                if(is1.Text != "")
                {
                    task.proje_ad = txt_projeAd.Text;
                    task.name = is1.Text;
                    task.date = tarih1.Text;
                    task.desc = aciklama1.Text;
                    task.durumId = Convert.ToInt32(durum1.Text);

                    task2.proje_ad = txt_projeAd.Text;
                    task2.name = is2.Text;
                    task2.date = tarih2.Text;
                    task2.desc = aciklama2.Text;
                    task2.durumId = Convert.ToInt32(durum2.Text);

                    db.taskEkle(task);
                    db.taskEkle2(task2);
                    //db.taskEkle3(task3);
                    //db.taskEkle4(task4);

                    db.projeEkle(prj);

                    TaskManagment task1 = new TaskManagment();
                    task1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("En az iki tane task eklenmesi lazım.");
                }
                

                //task3.proje_ad = txt_projeAd.Text;
                //if(is3.Text == "" && tarih3.Text == "" && aciklama3.Text == "" && durum3.Text == "" && )
                //{
                    
                //}
                //else
                //{
                //    task3.name = is3.Text;
                //    task3.date = tarih3.Text;
                //    task3.desc = aciklama3.Text;
                //    task3.durumId = Convert.ToInt32(du rum3.Text);
                //}
                

                //task4.proje_ad = txt_projeAd.Text;
                //task4.name = is4.Text;
                //task4.date = tarih4.Text;
                //task4.desc = aciklama4.Text;
                //task4.durumId = Convert.ToInt32(durum4.Text);

                

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
