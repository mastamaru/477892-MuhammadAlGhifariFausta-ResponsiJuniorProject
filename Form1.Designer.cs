namespace Responsi2Junpro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbDept = new ComboBox();
            tbNama = new TextBox();
            dgKaryawan = new DataGridView();
            listBox1 = new ListBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgKaryawan).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(199, 45);
            label1.Name = "label1";
            label1.Size = new Size(176, 32);
            label1.TabIndex = 1;
            label1.Text = "Junpro Comp.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 160);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 2;
            label2.Text = "Nama Karyawan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 211);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 3;
            label3.Text = "Departemen";
            // 
            // cbDept
            // 
            cbDept.FormattingEnabled = true;
            cbDept.Location = new Point(202, 213);
            cbDept.Name = "cbDept";
            cbDept.Size = new Size(183, 23);
            cbDept.TabIndex = 4;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(202, 162);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(183, 23);
            tbNama.TabIndex = 5;
            // 
            // dgKaryawan
            // 
            dgKaryawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKaryawan.Location = new Point(12, 300);
            dgKaryawan.Name = "dgKaryawan";
            dgKaryawan.RowTemplate.Height = 25;
            dgKaryawan.Size = new Size(538, 150);
            dgKaryawan.TabIndex = 6;
            dgKaryawan.CellClick += dgKaryawan_CellClick;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "ID Departemen", "Human Resources : HR", "Engineer : ENG", "Developer : DEV", "Project Manager : PM", "Finance : FIN" });
            listBox1.Location = new Point(401, 87);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(134, 94);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(120, 262);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 32);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(242, 262);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 32);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Edit";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(375, 262);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 32);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(listBox1);
            Controls.Add(dgKaryawan);
            Controls.Add(tbNama);
            Controls.Add(cbDept);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgKaryawan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbDept;
        private TextBox tbNama;
        private DataGridView dgKaryawan;
        private ListBox listBox1;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
