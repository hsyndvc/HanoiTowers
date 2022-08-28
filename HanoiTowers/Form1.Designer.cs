namespace HanoiTowers
{
    partial class Form1
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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cB1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer_sure = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHamleSayisi = new System.Windows.Forms.Label();
            this.labelSure = new System.Windows.Forms.Label();
            this.btnOyna = new System.Windows.Forms.Button();
            this.labelKullanıcı = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelçubuk1 = new System.Windows.Forms.Label();
            this.labelçubuk2 = new System.Windows.Forms.Label();
            this.labelçubuk3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // cB1
            // 
            this.cB1.BackColor = System.Drawing.Color.DarkGray;
            this.cB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cB1.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cB1.Location = new System.Drawing.Point(148, 61);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(174, 31);
            this.cB1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seviye :";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::HanoiTowers.Properties.Resources.TowerBase;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(17, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 393);
            this.panel1.TabIndex = 8;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel1.DragOver += new System.Windows.Forms.DragEventHandler(this.panel_DragOver);
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.BackgroundImage = global::HanoiTowers.Properties.Resources.TowerBase;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(715, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 393);
            this.panel3.TabIndex = 10;
            this.panel3.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel3.DragOver += new System.Windows.Forms.DragEventHandler(this.panel_DragOver);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.BackgroundImage = global::HanoiTowers.Properties.Resources.TowerBase;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(367, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 393);
            this.panel2.TabIndex = 9;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel2.DragOver += new System.Windows.Forms.DragEventHandler(this.panel_DragOver);
            // 
            // timer_sure
            // 
            this.timer_sure.Interval = 1000;
            this.timer_sure.Tick += new System.EventHandler(this.timer_sure_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.CausesValidation = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(20, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1042, 20);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(775, 574);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 395);
            this.listBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // labelHamleSayisi
            // 
            this.labelHamleSayisi.AutoSize = true;
            this.labelHamleSayisi.BackColor = System.Drawing.Color.Transparent;
            this.labelHamleSayisi.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelHamleSayisi.Location = new System.Drawing.Point(852, 88);
            this.labelHamleSayisi.Name = "labelHamleSayisi";
            this.labelHamleSayisi.Size = new System.Drawing.Size(68, 23);
            this.labelHamleSayisi.TabIndex = 11;
            this.labelHamleSayisi.Text = "Hamle :";
            // 
            // labelSure
            // 
            this.labelSure.AutoSize = true;
            this.labelSure.BackColor = System.Drawing.Color.Transparent;
            this.labelSure.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelSure.Location = new System.Drawing.Point(655, 88);
            this.labelSure.Name = "labelSure";
            this.labelSure.Size = new System.Drawing.Size(54, 23);
            this.labelSure.TabIndex = 12;
            this.labelSure.Text = "Süre :";
            // 
            // btnOyna
            // 
            this.btnOyna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOyna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOyna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOyna.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnOyna.Location = new System.Drawing.Point(413, 51);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(146, 49);
            this.btnOyna.TabIndex = 2;
            this.btnOyna.Text = "Oyna";
            this.btnOyna.UseVisualStyleBackColor = false;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // labelKullanıcı
            // 
            this.labelKullanıcı.AutoSize = true;
            this.labelKullanıcı.BackColor = System.Drawing.Color.Transparent;
            this.labelKullanıcı.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelKullanıcı.Location = new System.Drawing.Point(448, 9);
            this.labelKullanıcı.Name = "labelKullanıcı";
            this.labelKullanıcı.Size = new System.Drawing.Size(111, 23);
            this.labelKullanıcı.TabIndex = 5;
            this.labelKullanıcı.Text = "Kullanıcı Adı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 558);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 411);
            this.dataGridView1.TabIndex = 7;
            // 
            // labelçubuk1
            // 
            this.labelçubuk1.AutoSize = true;
            this.labelçubuk1.BackColor = System.Drawing.Color.Transparent;
            this.labelçubuk1.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelçubuk1.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelçubuk1.Location = new System.Drawing.Point(174, 120);
            this.labelçubuk1.Name = "labelçubuk1";
            this.labelçubuk1.Size = new System.Drawing.Size(35, 41);
            this.labelçubuk1.TabIndex = 14;
            this.labelçubuk1.Text = "1";
            // 
            // labelçubuk2
            // 
            this.labelçubuk2.AutoSize = true;
            this.labelçubuk2.BackColor = System.Drawing.Color.Transparent;
            this.labelçubuk2.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelçubuk2.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelçubuk2.Location = new System.Drawing.Point(524, 120);
            this.labelçubuk2.Name = "labelçubuk2";
            this.labelçubuk2.Size = new System.Drawing.Size(35, 41);
            this.labelçubuk2.TabIndex = 15;
            this.labelçubuk2.Text = "2";
            // 
            // labelçubuk3
            // 
            this.labelçubuk3.AutoSize = true;
            this.labelçubuk3.BackColor = System.Drawing.Color.Transparent;
            this.labelçubuk3.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelçubuk3.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelçubuk3.Location = new System.Drawing.Point(872, 120);
            this.labelçubuk3.Name = "labelçubuk3";
            this.labelçubuk3.Size = new System.Drawing.Size(35, 41);
            this.labelçubuk3.TabIndex = 16;
            this.labelçubuk3.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(666, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 46);
            this.label3.TabIndex = 17;
            this.label3.Text = "1 nolu kuledeki tüm diskleri 3 nolu kuleye taşıyınız.\r\nKüçük diskin üzerine büyük" +
    " disk konmaz.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1099, 984);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelçubuk3);
            this.Controls.Add(this.labelçubuk2);
            this.Controls.Add(this.labelçubuk1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelKullanıcı);
            this.Controls.Add(this.btnOyna);
            this.Controls.Add(this.labelSure);
            this.Controls.Add(this.labelHamleSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hanoi Kuleleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox cB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer_sure;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHamleSayisi;
        private System.Windows.Forms.Label labelSure;
        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.Label labelKullanıcı;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelçubuk1;
        private System.Windows.Forms.Label labelçubuk2;
        private System.Windows.Forms.Label labelçubuk3;
        private System.Windows.Forms.Label label3;
    }
}