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
        string[] dizi;
        int tahminiSüre = 0;
        
        public string proje_name { get; set; }
        //Sınıflardan nesneler oluştuyoruz.
        database db = new database();
        Proje prj = new Proje();
        Task task = new Task();
        Task task2 = new Task();
        public AddTask()
        {
            InitializeComponent();
        }

        private void txt_aciklama_Enter(object sender, EventArgs e)
        {
            //Placeholder özelliği olması için textbox'a tıklandığında içindeki text değerini boşalltıyoruz.
            if(txt_aciklama.Text == "İşin Açıklaması") 
            {
                txt_aciklama.Text = "";
            }
        }

        private void txt_not_Enter(object sender, EventArgs e)
        {
            //Placeholder özelliği olması için textbox'a tıklandığında içindeki text değerini boşalltıyoruz.
            if (txt_not.Text == "Notlar:")
            {
                txt_not.Text = "";
            }
        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            
            task.proje_ad = txt_projeAd.Text; 
            //İf bloğu içerisinde proje ad ve tarih textboxlarının boş geçilemeyeceğini kontrol ederek kullanıcıya bildiriyoruz.
            if(Convert.ToString(timepicker.Value) == "" && txt_projeAd.Text == "")
            {
                MessageBox.Show("Proje adı ve Tarih boş geçilemez");
            }
            else
            {
                //Kullanıcı tarafında girilen değerleri sınıflardan aldığımız örneklere aktarıp, örneğimizi database sınıfı içerisinde olan ilgili method'a aktarıyoruz.
                prj.ad = txt_projeAd.Text;
                prj.tarih = Convert.ToString(timepicker.Value);
                prj.aciklama = txt_aciklama.Text;
                prj.not = txt_not.Text;
                
                prj.gercekSure = txt_gerceksure.Text;
                prj.userId = 1;

                //Günlük ortalama 6 saat çalışma ile bir uygulamanın platfrmuna göre ortalama tamamlanma sürelerini araştırarak bir gün tahmini yaptım.
                if (txt_aciklama.Text.ToLower().Contains("web") == true)
                {
                    tahminiSüre += 20;
                }
                if (txt_aciklama.Text.ToLower().Contains("mobil") == true)
                {
                    tahminiSüre += 66;
                }

                if (txt_aciklama.Text.ToLower().Contains("forum") == true)
                {
                    tahminiSüre += 25;
                }

                if (txt_aciklama.Text.ToLower().Contains("masaüstü") == true)
                {
                    tahminiSüre += 55;
                }

                if (txt_aciklama.Text.ToLower().Contains("blog") == true)
                {
                    tahminiSüre += 15;
                }

                
                prj.tahminiSure = Convert.ToString(tahminiSüre) + "Gün";
                

                if (is1.Text != "")
                {
                    //İlgili projeye eklenen taskları task sınıfından oluşturduğumuz örnekler içerisine aktardıktan sonra database sınıfındaki ilgili method'a gönderiyoruz.
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
                    db.projeEkle(prj);
                    TaskManagment task1 = new TaskManagment(); 
                    task1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("En az iki tane task eklenmesi lazım.");
                }
            }
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void AddTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Ekleme ekranı kapatıldığında TaskManagment formunun yüklenmesini istiyoruz.
            TaskManagment task = new TaskManagment();
            task.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Durum hakkında bilgilendirme yapmak için linklabel özelliğ ile durumlar ve karşılık gelen kodları messagebox içerisinde gösterdik.
            MessageBox.Show("To Do = 1 || In Progress = 2 || Complated = 3 ");
        }

        public void SureHesapla()
        {


        }
    }
}
