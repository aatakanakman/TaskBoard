namespace TaskManagement
{
    partial class TaskManagment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagment));
            this.tblprojeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskManagementDataSet = new TaskManagement.TaskManagementDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ToDo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.InProgress = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Complated = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbl_projeTableAdapter = new TaskManagement.TaskManagementDataSetTableAdapters.tbl_projeTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proje_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proje_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblprojeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskManagementDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblprojeBindingSource
            // 
            this.tblprojeBindingSource.DataMember = "tbl_proje";
            this.tblprojeBindingSource.DataSource = this.taskManagementDataSet;
            // 
            // taskManagementDataSet
            // 
            this.taskManagementDataSet.DataSetName = "TaskManagementDataSet";
            this.taskManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.ToDo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(379, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 655);
            this.panel3.TabIndex = 1;
            // 
            // ToDo
            // 
            this.ToDo.AllowDrop = true;
            this.ToDo.BackColor = System.Drawing.Color.Azure;
            this.ToDo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToDo.Font = new System.Drawing.Font("Georgia", 15F);
            this.ToDo.FormattingEnabled = true;
            this.ToDo.ItemHeight = 24;
            this.ToDo.Location = new System.Drawing.Point(3, 77);
            this.ToDo.Name = "ToDo";
            this.ToDo.Size = new System.Drawing.Size(194, 528);
            this.ToDo.TabIndex = 6;
            this.ToDo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToDo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.InProgress);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(655, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 649);
            this.panel4.TabIndex = 2;
            // 
            // InProgress
            // 
            this.InProgress.AllowDrop = true;
            this.InProgress.BackColor = System.Drawing.Color.Azure;
            this.InProgress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InProgress.Font = new System.Drawing.Font("Georgia", 15F);
            this.InProgress.FormattingEnabled = true;
            this.InProgress.ItemHeight = 24;
            this.InProgress.Location = new System.Drawing.Point(3, 77);
            this.InProgress.Name = "InProgress";
            this.InProgress.Size = new System.Drawing.Size(203, 528);
            this.InProgress.TabIndex = 7;
            this.InProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.InProgress_DragDrop);
            this.InProgress.DragOver += new System.Windows.Forms.DragEventHandler(this.InProgress_DragOver);
            this.InProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InProgress_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "In Progress";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.Complated);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(941, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 652);
            this.panel5.TabIndex = 2;
            // 
            // Complated
            // 
            this.Complated.AllowDrop = true;
            this.Complated.BackColor = System.Drawing.Color.Azure;
            this.Complated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Complated.Font = new System.Drawing.Font("Georgia", 15F);
            this.Complated.FormattingEnabled = true;
            this.Complated.ItemHeight = 24;
            this.Complated.Location = new System.Drawing.Point(3, 77);
            this.Complated.Name = "Complated";
            this.Complated.Size = new System.Drawing.Size(194, 528);
            this.Complated.TabIndex = 8;
            this.Complated.DragDrop += new System.Windows.Forms.DragEventHandler(this.Complated_DragDrop);
            this.Complated.DragOver += new System.Windows.Forms.DragEventHandler(this.Complated_DragOver);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(68, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Completed";
            // 
            // tbl_projeTableAdapter
            // 
            this.tbl_projeTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_guncelle);
            this.panel2.Controls.Add(this.btn_sil);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(4, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 640);
            this.panel2.TabIndex = 2;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_guncelle.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.Image")));
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guncelle.Location = new System.Drawing.Point(121, 584);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(67, 45);
            this.btn_guncelle.TabIndex = 4;
            this.btn_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_sil.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.Location = new System.Drawing.Point(229, 584);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(67, 45);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 45);
            this.button1.TabIndex = 1;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proje_id,
            this.proje_name});
            this.dataGridView1.DataSource = this.tblprojeBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(3, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(293, 564);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // proje_id
            // 
            this.proje_id.DataPropertyName = "proje_id";
            this.proje_id.HeaderText = "Proje Numarası";
            this.proje_id.Name = "proje_id";
            this.proje_id.ReadOnly = true;
            // 
            // proje_name
            // 
            this.proje_name.DataPropertyName = "proje_name";
            this.proje_name.HeaderText = "Proje Adı";
            this.proje_name.Name = "proje_name";
            this.proje_name.ReadOnly = true;
            // 
            // TaskManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1197, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "TaskManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskManagment";
            this.Load += new System.EventHandler(this.TaskManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblprojeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskManagementDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TaskManagementDataSet taskManagementDataSet;
        private System.Windows.Forms.BindingSource tblprojeBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private TaskManagementDataSetTableAdapters.tbl_projeTableAdapter tbl_projeTableAdapter;
        private System.Windows.Forms.ListBox ToDo;
        private System.Windows.Forms.ListBox InProgress;
        private System.Windows.Forms.ListBox Complated;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proje_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn proje_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}