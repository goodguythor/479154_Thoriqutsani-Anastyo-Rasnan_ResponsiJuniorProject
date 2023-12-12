namespace ResponsiJunpro
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
            namaLabel = new Label();
            depLabel = new Label();
            karyawanDataView = new DataGridView();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            insertButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)karyawanDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new Point(177, 40);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new Size(102, 15);
            namaLabel.TabIndex = 0;
            namaLabel.Text = "Nama Karyawan : ";
            // 
            // depLabel
            // 
            depLabel.AutoSize = true;
            depLabel.Location = new Point(187, 78);
            depLabel.Name = "depLabel";
            depLabel.Size = new Size(91, 15);
            depLabel.TabIndex = 1;
            depLabel.Text = "Dep. Karyawan :";
            // 
            // karyawanDataView
            // 
            karyawanDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            karyawanDataView.Location = new Point(33, 172);
            karyawanDataView.Name = "karyawanDataView";
            karyawanDataView.RowTemplate.Height = 25;
            karyawanDataView.Size = new Size(735, 249);
            karyawanDataView.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // insertButton
            // 
            insertButton.Location = new Point(177, 116);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(75, 23);
            insertButton.TabIndex = 5;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.Click += insertButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(258, 116);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 6;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(339, 116);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(563, 32);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(151, 121);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "ID Departemen:\nHR : HR\nENG : Engineer\nDEV : Developer\nPM : Produt Manager\nFIN : Finance";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(284, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(insertButton);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(karyawanDataView);
            Controls.Add(depLabel);
            Controls.Add(namaLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)karyawanDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namaLabel;
        private Label depLabel;
        private DataGridView karyawanDataView;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button insertButton;
        private Button editButton;
        private Button deleteButton;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
    }
}