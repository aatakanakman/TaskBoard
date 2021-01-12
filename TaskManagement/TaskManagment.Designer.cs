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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.taskManagementDataSet = new TaskManagement.TaskManagementDataSet();
            this.tblprojeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.proje_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proje_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_projeTableAdapter = new TaskManagement.TaskManagementDataSetTableAdapters.tbl_projeTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprojeBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 652);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Beige;
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Proje Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 588);
            this.panel2.TabIndex = 2;
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(224, 538);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // taskManagementDataSet
            // 
            this.taskManagementDataSet.DataSetName = "TaskManagementDataSet";
            this.taskManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblprojeBindingSource
            // 
            this.tblprojeBindingSource.DataMember = "tbl_proje";
            this.tblprojeBindingSource.DataSource = this.taskManagementDataSet;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(294, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 652);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(619, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 649);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(941, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 652);
            this.panel5.TabIndex = 2;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(68, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Beige;
            this.button2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(137, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Görev Ekle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // tbl_projeTableAdapter
            // 
            this.tbl_projeTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // TaskManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1197, 651);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "TaskManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskManagment";
            this.Load += new System.EventHandler(this.TaskManagment_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprojeBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TaskManagementDataSet taskManagementDataSet;
        private System.Windows.Forms.BindingSource tblprojeBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn proje_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn proje_name;
        private TaskManagementDataSetTableAdapters.tbl_projeTableAdapter tbl_projeTableAdapter;
        private System.Windows.Forms.Label label5;
    }
}