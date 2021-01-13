using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    class database
    {
      

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FUMRB92\\SQLEXPRESS01;Initial Catalog=TaskManagement;Integrated Security=True");
            baglan.Open();

            return baglan;
        }

        public void projeEkle(Proje prj)
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

   
        }

        public void taskEkle(Task task)
        {
            SqlCommand komut2 = new SqlCommand("INSERT INTO tbl_task(task_name,task_desc,task_date,durum_id,proje_ad) VALUES (@ad,@aciklama,@tarih,@durum_id,@proje_ad)", baglanti());

            komut2.Parameters.AddWithValue("@ad", task.name);
            komut2.Parameters.AddWithValue("@aciklama", task.desc);
            komut2.Parameters.AddWithValue("@tarih", task.date);
            komut2.Parameters.AddWithValue("@durum_id", task.durumId);
            komut2.Parameters.AddWithValue("@proje_ad", task.proje_ad);


            komut2.ExecuteNonQuery();
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

        public void projeSil(Proje prj)
        {
            SqlCommand komut2 = new SqlCommand("delete from tbl_proje where proje_name = @ad", baglanti());

            komut2.Parameters.AddWithValue("@ad", prj.ad);
            komut2.ExecuteNonQuery();

            SqlCommand komut3 = new SqlCommand("delete from tbl_task where proje_ad = @ad", baglanti());

            komut3.Parameters.AddWithValue("@ad", prj.ad);
            komut3.ExecuteNonQuery();
        }

        //public void taskEkle3(Task task2)
        //{
        //    SqlCommand komut2 = new SqlCommand("INSERT INTO tbl_task(task_name,task_desc,task_date,durum_id,proje_ad) VALUES (@ad,@aciklama,@tarih,@durum_id,@proje_ad)", baglanti());

        //    komut2.Parameters.AddWithValue("@ad", task2.name);
        //    komut2.Parameters.AddWithValue("@aciklama", task2.desc);
        //    komut2.Parameters.AddWithValue("@tarih", task2.date);
        //    komut2.Parameters.AddWithValue("@durum_id", task2.durumId);
        //    komut2.Parameters.AddWithValue("@proje_ad", task2.proje_ad);


        //    komut2.ExecuteNonQuery();
        //}

        //public void taskEkle4(Task task3)
        //{
        //    SqlCommand komut2 = new SqlCommand("INSERT INTO tbl_task(task_name,task_desc,task_date,durum_id,proje_ad) VALUES (@ad,@aciklama,@tarih,@durum_id,@proje_ad)", baglanti());

        //    komut2.Parameters.AddWithValue("@ad", task3.name);
        //    komut2.Parameters.AddWithValue("@aciklama", task3.desc);
        //    komut2.Parameters.AddWithValue("@tarih", task3.date);
        //    komut2.Parameters.AddWithValue("@durum_id", task3.durumId);
        //    komut2.Parameters.AddWithValue("@proje_ad", task3.proje_ad);


        //    komut2.ExecuteNonQuery();
        //}


    }
}
