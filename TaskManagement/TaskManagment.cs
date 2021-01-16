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
        
        //Sınıf içerisinde kullanılacak olan diğer sınıflarımızdan nesneler oluşturuyoruz.
        database db = new database();
        int sira;
        int sira2;


        public TaskManagment()
        {
            InitializeComponent();
        }

        private void TaskManagment_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            // TODO: Bu kod satırı 'taskManagementDataSet.tbl_proje' tablosuna veri yükler. 
            this.tbl_projeTableAdapter.Fill(this.taskManagementDataSet.tbl_proje);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Listboxlarımızdaki verilerimizi her satıra tıklama sonrasında arka arkaya yazmaması için tıklanmanın hemen ardından listbox'ların itemlerini temizlememiz gerekir.
            ToDo.Items.Clear();
            InProgress.Items.Clear();
            Complated.Items.Clear();

            /*Proje adına ve durumId' sine göre, todo,ın Progress ve complate listboxlarına değer yerleştirmelerini yapmamız için seçilen satırdaki proje ismini 
             Proje sınıfından oluşturduğumuz örneğin ad property sine aktarıyoruz.*/
            Proje prj = new Proje();
            prj.ad = Convert.ToString(dataGridView1.CurrentRow.Cells["proje_name"].Value);
            SqlDataReader dr = db.Doldur(prj); //Database sınıfındaki ilgili method'a aktarıyoruz.

           
            while (dr.Read()) //Fonksiyondan dönen değer okunup bitesiye kadar aşağıdaki işlemleri yapıyoruz.
            {
                
                Task task = new Task();
                task.name = (string)dr["task_name"]; /*DataReader'dan gelen sütun adlarına göre, ilgili örneklerin özellikleri dolduruluyor.
                                                      * Ve durum id'lerine göre ilgili listbox'lara atanıyor*/
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


        //Drag-Drop işlemleri için 3 event kullanıyoruz.
        private void ToDo_MouseDown(object sender, MouseEventArgs e) //İlk olarak ToDo listesinin üstüne geldiğmizde seçmek istediğim projenin durum_id = 2 olarak atanıyor
        {
            

            Point nokta = new Point(e.X, e.Y);  //Seçilen satırın noktalarını alıyoruz..
            sira = ToDo.IndexFromPoint(nokta); //Ve bu noktaları bir değişkene aktarıyoruz.
            if (e.Button == MouseButtons.Left) //Farenin sol butonu ile işlemyapacağımızı söylüyoruz.
            {
                ToDo.DoDragDrop(ToDo.Items[sira], DragDropEffects.All); //Sira olarak alınan noktaları baz alarak drag drop işlemini başlatıyoruzç.
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
            Task task = new Task();
            task.name = ToDo.SelectedItem.ToString();
            task.durumId = 2;
            db.TaskDurumGuncelle(task); // Güncellenin durum id database fonksiyonu sayesinde tablolaromozda da güncelleniyor.

            InProgress.Items.Add(e.Data.GetData(DataFormats.StringFormat.ToString())); //Bırakılan yere göre datamızı çekiyoruz.
            ToDo.Items.Remove(ToDo.Items[sira]);
        }

        private void InProgress_MouseDown(object sender, MouseEventArgs e)
        {
            
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
            Task task = new Task();
            task.name = InProgress.SelectedItem.ToString();
            task.durumId = 3;
            db.TaskDurumGuncelle(task);

            Complated.Items.Add(e.Data.GetData(DataFormats.StringFormat.ToString()));
            InProgress.Items.Remove(InProgress.Items[sira2]);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            //proje sil butonuna tıkladığımızda seçilen datagridview'in ilgili sütun değerlerini alıyoruz ve database sınıfımızdali projesil methoduna parametre  olarak gönderiyoruz.
            Proje prj = new Proje();
            prj.ad = (string)dataGridView1.CurrentRow.Cells["proje_name"].Value;
            prj.proje_id = (int)dataGridView1.CurrentRow.Cells["proje_id"].Value;
            db.projeSil(prj);
            
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            UpdateTask update = new UpdateTask();
            update.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTask add = new AddTask();
            add.Show();
            this.Hide();
        }
    }
 }

