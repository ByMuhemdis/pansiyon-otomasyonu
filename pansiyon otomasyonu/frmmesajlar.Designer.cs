namespace pansiyon_otomasyonu
{
    partial class frmmesajlar
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
            this.label1 = new System.Windows.Forms.Label();
            this.richmesaj = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadsoyaad = new System.Windows.Forms.TextBox();
            this.btnmesajkayıt = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // richmesaj
            // 
            this.richmesaj.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richmesaj.Location = new System.Drawing.Point(38, 126);
            this.richmesaj.Name = "richmesaj";
            this.richmesaj.Size = new System.Drawing.Size(726, 239);
            this.richmesaj.TabIndex = 1;
            this.richmesaj.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mesaj";
            // 
            // txtadsoyaad
            // 
            this.txtadsoyaad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsoyaad.Location = new System.Drawing.Point(159, 37);
            this.txtadsoyaad.Name = "txtadsoyaad";
            this.txtadsoyaad.Size = new System.Drawing.Size(381, 34);
            this.txtadsoyaad.TabIndex = 3;
            // 
            // btnmesajkayıt
            // 
            this.btnmesajkayıt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmesajkayıt.Location = new System.Drawing.Point(639, 380);
            this.btnmesajkayıt.Name = "btnmesajkayıt";
            this.btnmesajkayıt.Size = new System.Drawing.Size(125, 37);
            this.btnmesajkayıt.TabIndex = 4;
            this.btnmesajkayıt.Text = "Mesaj Kaydet";
            this.btnmesajkayıt.UseVisualStyleBackColor = true;
            this.btnmesajkayıt.Click += new System.EventHandler(this.btnmesajkayıt_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 432);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(726, 177);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad Soyad";
            this.columnHeader2.Width = 264;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mesaj";
            this.columnHeader3.Width = 313;
            // 
            // frmmesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(790, 621);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnmesajkayıt);
            this.Controls.Add(this.txtadsoyaad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richmesaj);
            this.Controls.Add(this.label1);
            this.Name = "frmmesajlar";
            this.Text = "frmmesajlar";
            this.Load += new System.EventHandler(this.frmmesajlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richmesaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadsoyaad;
        private System.Windows.Forms.Button btnmesajkayıt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}