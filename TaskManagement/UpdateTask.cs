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
    public partial class UpdateTask : Form
    {
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

        private void getir_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            secilenProje = (string)comboBox1.SelectedValue.ToString();
            MessageBox.Show(secilenProje);


        }

        
    }
}
