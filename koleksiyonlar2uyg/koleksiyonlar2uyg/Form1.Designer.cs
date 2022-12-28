namespace koleksiyonlar2uyg
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
            this.keytxt = new System.Windows.Forms.TextBox();
            this.valuetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eklebtn = new System.Windows.Forms.Button();
            this.cikarbtn = new System.Windows.Forms.Button();
            this.varmiyokmutxt = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.aciklamalbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keytxt
            // 
            this.keytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.keytxt.Location = new System.Drawing.Point(256, 114);
            this.keytxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keytxt.Name = "keytxt";
            this.keytxt.Size = new System.Drawing.Size(132, 30);
            this.keytxt.TabIndex = 0;
            // 
            // valuetxt
            // 
            this.valuetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.valuetxt.Location = new System.Drawing.Point(256, 170);
            this.valuetxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valuetxt.Name = "valuetxt";
            this.valuetxt.Size = new System.Drawing.Size(132, 30);
            this.valuetxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(156, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(156, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value :";
            // 
            // eklebtn
            // 
            this.eklebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eklebtn.Location = new System.Drawing.Point(141, 277);
            this.eklebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(121, 43);
            this.eklebtn.TabIndex = 4;
            this.eklebtn.Text = "Ekle ";
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // cikarbtn
            // 
            this.cikarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikarbtn.Location = new System.Drawing.Point(279, 277);
            this.cikarbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cikarbtn.Name = "cikarbtn";
            this.cikarbtn.Size = new System.Drawing.Size(111, 43);
            this.cikarbtn.TabIndex = 5;
            this.cikarbtn.Text = "Çıkar ";
            this.cikarbtn.UseVisualStyleBackColor = true;
            this.cikarbtn.Click += new System.EventHandler(this.cikarbtn_Click);
            // 
            // varmiyokmutxt
            // 
            this.varmiyokmutxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.varmiyokmutxt.Location = new System.Drawing.Point(397, 277);
            this.varmiyokmutxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.varmiyokmutxt.Name = "varmiyokmutxt";
            this.varmiyokmutxt.Size = new System.Drawing.Size(200, 43);
            this.varmiyokmutxt.TabIndex = 6;
            this.varmiyokmutxt.Text = "Var mı Yok mu ";
            this.varmiyokmutxt.UseVisualStyleBackColor = true;
            this.varmiyokmutxt.Click += new System.EventHandler(this.varmiyokmutxt_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(657, 95);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 244);
            this.listBox1.TabIndex = 7;
            // 
            // aciklamalbl
            // 
            this.aciklamalbl.AutoSize = true;
            this.aciklamalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklamalbl.Location = new System.Drawing.Point(273, 411);
            this.aciklamalbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aciklamalbl.Name = "aciklamalbl";
            this.aciklamalbl.Size = new System.Drawing.Size(125, 29);
            this.aciklamalbl.TabIndex = 8;
            this.aciklamalbl.Text = "--------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.aciklamalbl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.varmiyokmutxt);
            this.Controls.Add(this.cikarbtn);
            this.Controls.Add(this.eklebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valuetxt);
            this.Controls.Add(this.keytxt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keytxt;
        private System.Windows.Forms.TextBox valuetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.Button cikarbtn;
        private System.Windows.Forms.Button varmiyokmutxt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label aciklamalbl;
    }
}

