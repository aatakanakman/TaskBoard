﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class database
    {
      

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FUMRB92\\SQLEXPRESS01;Initial Catalog=TaskManagement;Integrated Security=True");
            baglan.Open();

            return baglan;
        }

        public string projeEkle(Proje prj)
        {
            
            SqlCommand komut = new SqlCommand("INSERT INTO tbl_proje(proje_name,proje_tarih,proje_not,proje_desc,proje_tahmini,proje_gerceklesen,user_id) VALUES (@ad,@tarih,@not,@desc,@tahminiSure,@gercekSure,@user)",baglanti());

            komut.Parameters.AddWithValue("@ad", prj.ad);
            komut.Parameters.AddWithValue("@tarih", prj.tarih);
            komut.Parameters.AddWithValue("@not", prj.not); 
            komut.Parameters.AddWithValue("@desc", prj.aciklama);
            komut.Parameters.AddWithValue("@tahminiSure", prj.tahminiSure);
            komut.Parameters.AddWithValue("@gercekSure", prj.gercekSure);
            komut.Parameters.AddWithValue("@user", prj.userId);
            komut.ExecuteNonQuery();

            return "Proje Eklendi";
   
        }

        public string taskEkle(Task task)
        {
            SqlCommand komut2 = new SqlCommand("INSERT INTO tbl_task(task_name,task_desc,task_date,durum_id,proje_ad) VALUES (@ad,@aciklama,@tarih,@durum_id,@proje_ad)", baglanti());

            komut2.Parameters.AddWithValue("@ad", task.name);
            komut2.Parameters.AddWithValue("@aciklama", task.desc);
            komut2.Parameters.AddWithValue("@tarih", task.date);
            komut2.Parameters.AddWithValue("@durum_id", task.durumId);
            komut2.Parameters.AddWithValue("@proje_ad", task.proje_ad);


            komut2.ExecuteNonQuery();

            return "Task Eklendi";
        }
        public void taskEkle2(Task task)
        {
            SqlCommand komut2 = new SqlCommand("INSERT INTO tbl_task(task_name,task_desc,task_date,durum_id,proje_ad) VALUES (@ad,@aciklama,@tarih,@durum_id,@proje_ad)", baglanti());

            komut2.Parameters.AddWithValue("@ad", task.name);
            komut2.Parameters.AddWithValue("@aciklama", task.desc);
            komut2.Parameters.AddWithValue("@tarih", task.date);
            komut2.Parameters.AddWithValue("@durum_id", task.durumId);
            komut2.Parameters.AddWithValue("@proje_ad", task.proje_ad);


            komut2.ExecuteNonQuery();
        }

        public void TaskDurumGuncelle(Task task)
        {
            SqlCommand komut2 = new SqlCommand("update tbl_task set durum_id = @durum where task_name = @ad", baglanti());

            komut2.Parameters.AddWithValue("@ad", task.name);
            komut2.Parameters.AddWithValue("@durum", task.durumId);
            komut2.ExecuteNonQuery();
        }

        public string projeSil(Proje prj)
        {
            SqlCommand komut2 = new SqlCommand("delete from tbl_proje where proje_name = @ad", baglanti());

            komut2.Parameters.AddWithValue("@ad", prj.ad);
            komut2.ExecuteNonQuery();

            SqlCommand komut3 = new SqlCommand("delete from tbl_task where proje_ad = @ad", baglanti());

            komut3.Parameters.AddWithValue("@ad", prj.ad);
            komut3.ExecuteNonQuery();

            return "Silindi";
        }
        public SqlDataReader TaskGetir(Task task)
        {
            SqlCommand komut3 = new SqlCommand("Select * from tbl_task where proje_ad = @ad", baglanti());

            komut3.Parameters.AddWithValue("@ad", task.proje_ad);
            SqlDataReader data = komut3.ExecuteReader();

            return data;

        }

        public SqlDataReader ProjeGetir(Proje prj)
        {
            SqlCommand komut3 = new SqlCommand("Select * from tbl_proje where proje_name = @ad", baglanti());
            komut3.Parameters.AddWithValue("@ad", prj.ad);
            SqlDataReader data1 = komut3.ExecuteReader();
            return data1;

        }

        public SqlDataReader UserGetir()
        {
            SqlCommand komut4 = new SqlCommand("select user_name from tbl_proje p , tbl_user u where u.user_id = p.user_id ", baglanti());
            SqlDataReader data2 = komut4.ExecuteReader();

            return data2;

        }

        public SqlDataReader Doldur(Proje prj)
        {
            SqlCommand cmd = new SqlCommand("Select task_name,durum_id from tbl_task where proje_ad = @projead ",baglanti()); ;
            cmd.Parameters.AddWithValue("@projead", prj.ad);
           SqlDataReader dr = cmd.ExecuteReader();

            return dr;

        }
    }
}
