namespace Dominik_CMS
{
    partial class AddArticle
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
            this.articleSubtitle = new System.Windows.Forms.TextBox();
            this.articleTitle = new System.Windows.Forms.TextBox();
            this.articleDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.articleAuthor = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.articleMainImage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // articleSubtitle
            // 
            this.articleSubtitle.Location = new System.Drawing.Point(12, 185);
            this.articleSubtitle.Multiline = true;
            this.articleSubtitle.Name = "articleSubtitle";
            this.articleSubtitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.articleSubtitle.Size = new System.Drawing.Size(732, 209);
            this.articleSubtitle.TabIndex = 0;
            // 
            // articleTitle
            // 
            this.articleTitle.Location = new System.Drawing.Point(12, 25);
            this.articleTitle.Name = "articleTitle";
            this.articleTitle.Size = new System.Drawing.Size(399, 20);
            this.articleTitle.TabIndex = 1;
            this.articleTitle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // articleDate
            // 
            this.articleDate.Location = new System.Drawing.Point(12, 75);
            this.articleDate.Name = "articleDate";
            this.articleDate.Size = new System.Drawing.Size(200, 20);
            this.articleDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tytuł";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Podtytuł";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dodaj Akapit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1001, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "Dodaj Zdjęcie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Autor";
            // 
            // articleAuthor
            // 
            this.articleAuthor.Location = new System.Drawing.Point(15, 430);
            this.articleAuthor.Name = "articleAuthor";
            this.articleAuthor.Size = new System.Drawing.Size(399, 20);
            this.articleAuthor.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.typ,
            this.nazwa});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(801, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(336, 209);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Index
            // 
            this.Index.Text = "Index";
            // 
            // typ
            // 
            this.typ.DisplayIndex = 2;
            this.typ.Text = "typ";
            // 
            // nazwa
            // 
            this.nazwa.DisplayIndex = 1;
            this.nazwa.Text = "nazwa";
            this.nazwa.Width = 210;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(15, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "Anuluj";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Location = new System.Drawing.Point(191, 489);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 47);
            this.button4.TabIndex = 12;
            this.button4.Text = "Zapisz";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // articleMainImage
            // 
            this.articleMainImage.Location = new System.Drawing.Point(12, 137);
            this.articleMainImage.Name = "articleMainImage";
            this.articleMainImage.Size = new System.Drawing.Size(399, 20);
            this.articleMainImage.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Zdjęcie Główne";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(801, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 63);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(810, 374);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 40);
            this.button6.TabIndex = 21;
            this.button6.Text = "Usuń fragment artukułu";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Blue;
            this.pictureBox2.Location = new System.Drawing.Point(801, 430);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(336, 123);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(810, 462);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 67);
            this.button7.TabIndex = 23;
            this.button7.Text = "zmień kolejność fragmentów artykułu";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(963, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(963, 486);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 50);
            this.textBox2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(960, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Podaj kolejność (oddziel indexy przecinkami)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(963, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Podaj usuwany index";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(963, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Podaj edytowany index";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(963, 325);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 20);
            this.textBox3.TabIndex = 30;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(810, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 40);
            this.button5.TabIndex = 29;
            this.button5.Text = "Edytuj fragment artukułu";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox3.Location = new System.Drawing.Point(801, 292);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(336, 63);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // AddArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 565);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.articleMainImage);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.articleAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.articleDate);
            this.Controls.Add(this.articleTitle);
            this.Controls.Add(this.articleSubtitle);
            this.Name = "AddArticle";
            this.Text = "Dodaj Artykuł";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox articleSubtitle;
        private System.Windows.Forms.TextBox articleTitle;
        private System.Windows.Forms.DateTimePicker articleDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox articleAuthor;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader typ;
        private System.Windows.Forms.ColumnHeader nazwa;
        private System.Windows.Forms.TextBox articleMainImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}