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

namespace TaskManagement
{
    public partial class UpdateTask : Form
    {
        //Gerekli olan nesne ve listelerimizi oluşşturuyoruz.
        database db = new database();
        List<String> isAdi = new List<String>();
        List<String> isAciklama = new List<String>();
        List<String> isTarih = new List<String>();
        List<int> durumId = new List<int>();

        public string secilenProje { get; set; } 

        public UpdateTask()
        {
            InitializeComponent();
        }

        private void UpdateTask_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'taskManagementDataSet.tbl_proje' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_projeTableAdapter.Fill(this.taskManagementDataSet.tbl_proje);

        }

        //Getir label'ına tıkladığımızda combobox üzerinden seçilen projenin adına göre ilgili yerlere database üzerinden değerleri çekiyoruz.
        private void getir_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            secilenProje = (string)comboBox1.SelectedValue.ToString(); //combobox'taki değeri secilen proje olarak değişkene akratıyoruz.
            if (comboBox1.SelectedItem != null) //Bir projenin seçildiğinden emin oluyoruz.
            {
                Task task = new Task();
                
                //MessageBox.Show(secilenProje);
                task.proje_ad = secilenProje;
                SqlDataReader dr = db.TaskGetir(task);
                
                Proje prj = new Proje();
                prj.ad = (string)comboBox1.SelectedValue.ToString();
                SqlDataReader dr1 = db.ProjeGetir(prj);

                SqlDataReader dr2 = db.UserGetir();
               
                //Fonksiyonların geri dönüş değerleri okunana dek aşağıdaki işlemleri gerçekleştiriyoruz.

                while (dr2.Read())
                {

                    txt_uzman.Text = (string)dr2["user_name"]; 

                }


                while (dr1.Read())
                {
                    txt_aciklama.Text = (string)dr1["proje_desc"];
                    txt_not.Text = (string)dr1["proje_not"];
                    txt_tahminsure.Text = (string)dr1["proje_tahmini"];
                }


                while (dr.Read())
                {
                    //Oluşturmuş olduğumuz listelere okunan değerleri sırasıyla ekliyoruz.
                    isAdi.Add((string)dr["task_name"]);
                    isAciklama.Add((string)dr["task_desc"]);
                    isTarih.Add((string)dr["task_date"]);
                    durumId.Add((int)dr["durum_id"]);
                }

                //Eklediğimiz değerleri döngü içerisinde sırasıyla ilgili textboxlara aktarıyoruz.
                int i; 
                for (i = 0; i < isAdi.Count; i++)
                {
                    is1.Text = isAdi[0];
                    is2.Text = isAdi[1];
                    tarih1.Text = isTarih[0];
                    tarih2.Text = isTarih[1];
                    aciklama1.Text = isAciklama[0];
                    aciklama2.Text = isAciklama[1];
                    durum1.Text = Convert.ToString(durumId[0]);
                    durum2.Text = Convert.ToString(durumId[1]);
                }
            }
            else
            {
                MessageBox.Show("Henüz Bir Proje seçilmedi veya proje yok");
            }
        }
    }
}
