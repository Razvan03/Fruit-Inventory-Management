namespace Tema2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.btn_Photo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Detalii = new System.Windows.Forms.TextBox();
            this.txtBox_Pret = new System.Windows.Forms.TextBox();
            this.txtBox_Cantitate = new System.Windows.Forms.TextBox();
            this.txtBox_Nume = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.listBox_Produse = new System.Windows.Forms.ListBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.lbl_Price);
            this.panel2.Controls.Add(this.btn_Sort);
            this.panel2.Controls.Add(this.btn_Photo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBox_Detalii);
            this.panel2.Controls.Add(this.txtBox_Pret);
            this.panel2.Controls.Add(this.txtBox_Cantitate);
            this.panel2.Controls.Add(this.txtBox_Nume);
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.listBox_Produse);
            this.panel2.Name = "panel2";
            // 
            // btn_Sort
            // 
            resources.ApplyResources(this.btn_Sort, "btn_Sort");
            this.btn_Sort.BackColor = System.Drawing.Color.Orange;
            this.btn_Sort.ForeColor = System.Drawing.Color.White;
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.UseVisualStyleBackColor = false;
            this.btn_Sort.Click += new System.EventHandler(this.btn_SortByPrice_Click);
            // 
            // btn_Photo
            // 
            resources.ApplyResources(this.btn_Photo, "btn_Photo");
            this.btn_Photo.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_Photo.ForeColor = System.Drawing.Color.White;
            this.btn_Photo.Name = "btn_Photo";
            this.btn_Photo.UseVisualStyleBackColor = false;
            this.btn_Photo.Click += new System.EventHandler(this.Incarca_Poza_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtBox_Detalii
            // 
            resources.ApplyResources(this.txtBox_Detalii, "txtBox_Detalii");
            this.txtBox_Detalii.Name = "txtBox_Detalii";
            // 
            // txtBox_Pret
            // 
            resources.ApplyResources(this.txtBox_Pret, "txtBox_Pret");
            this.txtBox_Pret.Name = "txtBox_Pret";
            // 
            // txtBox_Cantitate
            // 
            resources.ApplyResources(this.txtBox_Cantitate, "txtBox_Cantitate");
            this.txtBox_Cantitate.Name = "txtBox_Cantitate";
            // 
            // txtBox_Nume
            // 
            resources.ApplyResources(this.txtBox_Nume, "txtBox_Nume");
            this.txtBox_Nume.Name = "txtBox_Nume";
            // 
            // btn_Delete
            // 
            resources.ApplyResources(this.btn_Delete, "btn_Delete");
            this.btn_Delete.BackColor = System.Drawing.Color.Crimson;
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            resources.ApplyResources(this.btn_Update, "btn_Update");
            this.btn_Update.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            resources.ApplyResources(this.btn_Add, "btn_Add");
            this.btn_Add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // listBox_Produse
            // 
            resources.ApplyResources(this.listBox_Produse, "listBox_Produse");
            this.listBox_Produse.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listBox_Produse.FormattingEnabled = true;
            this.listBox_Produse.Name = "listBox_Produse";
            this.listBox_Produse.Click += new System.EventHandler(this.listBox_Produse_Click);
            // 
            // lbl_Price
            // 
            resources.ApplyResources(this.lbl_Price, "lbl_Price");
            this.lbl_Price.Name = "lbl_Price";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Detalii;
        private System.Windows.Forms.TextBox txtBox_Pret;
        private System.Windows.Forms.TextBox txtBox_Cantitate;
        private System.Windows.Forms.TextBox txtBox_Nume;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListBox listBox_Produse;
        private System.Windows.Forms.Button btn_Photo;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Label lbl_Price;
    }
}

