using System;
using System.Data.SqlClient;
using NUnit.Framework;
using TaskManagement;

namespace TaskManagementNUnitTest
{
    
    [TestFixture]

    public class UnitTest1
    {
        
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FUMRB92\\SQLEXPRESS01;Initial Catalog=TaskManagement;Integrated Security=True");
            baglan.Open();

            return baglan;
        }

        [Test]
        public void TaskEkleNUnit()
        {
            TaskEkle("Test", "Alet & Edevat","Test Aciklama", "15.10.2021", 1);
        }
        
        public void TaskEkle(string name, string proje_ad, string aciklama , string tarih , int durum_id )
        {

            Task task = new Task();
            task.name = name;
            task.date = tarih;
            task.proje_ad = proje_ad;
            task.durumId = durum_id;
            task.desc = aciklama;
            database db = new database();
            string sonuc;
            sonuc = db.taskEkle(task);
            
            Assert.AreEqual("Task Eklendi", sonuc);

        }

        [Test]
        public void ProjeEkleNUnit()
        {
            ProjeEkle("Test Projesi", "16.01.2021", "Tst Proje Açıklaması", "Test proje not", "Test Gün", "", 1);
         }

        public void ProjeEkle(string name, string tarih, string aciklama, string not, string tahminiSure , string gercekSure, int userId)
        {
            Proje prj = new Proje();
            prj.ad = name;
            prj.tarih = tarih;
            prj.aciklama = aciklama;
            prj.not = not;
            prj.tahminiSure = tahminiSure;
            prj.gercekSure = gercekSure;
            prj.userId = userId ;
            database db = new database();
            string sonuc;
            sonuc = db.projeEkle(prj);
            Assert.AreEqual("Proje Eklendi", sonuc);

        }


        [Test]
        public void ProjeSilNUnit()
        {
            ProjeSil("Test Projesi");
        }

        public void ProjeSil(string name)
        {
            Proje prj = new Proje();
            prj.ad = name;
            database db = new database();
            string sonuc;
            sonuc = db.projeSil(prj);
            Assert.AreEqual("Silindi", sonuc);

        }




    }
}
