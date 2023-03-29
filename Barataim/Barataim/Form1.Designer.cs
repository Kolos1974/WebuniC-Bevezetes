namespace Barataim
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
            this.btnUjBarat = new System.Windows.Forms.Button();
            this.btnMent = new System.Windows.Forms.Button();
            this.btnBetolt = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnKeres = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMegse = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUjBarat
            // 
            this.btnUjBarat.Location = new System.Drawing.Point(12, 12);
            this.btnUjBarat.Name = "btnUjBarat";
            this.btnUjBarat.Size = new System.Drawing.Size(75, 23);
            this.btnUjBarat.TabIndex = 0;
            this.btnUjBarat.Text = "Új barát";
            this.btnUjBarat.UseVisualStyleBackColor = true;
            this.btnUjBarat.Click += new System.EventHandler(this.btnUjBarat_Click);
            // 
            // btnMent
            // 
            this.btnMent.Location = new System.Drawing.Point(12, 41);
            this.btnMent.Name = "btnMent";
            this.btnMent.Size = new System.Drawing.Size(75, 28);
            this.btnMent.TabIndex = 1;
            this.btnMent.Text = "Mentés";
            this.btnMent.UseVisualStyleBackColor = true;
            this.btnMent.Click += new System.EventHandler(this.btnMent_Click);
            // 
            // btnBetolt
            // 
            this.btnBetolt.Location = new System.Drawing.Point(12, 75);
            this.btnBetolt.Name = "btnBetolt";
            this.btnBetolt.Size = new System.Drawing.Size(75, 23);
            this.btnBetolt.TabIndex = 2;
            this.btnBetolt.Text = "Betöltés";
            this.btnBetolt.UseVisualStyleBackColor = true;
            this.btnBetolt.Click += new System.EventHandler(this.btnBetolt_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(12, 104);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "Barát Lista";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnKeres
            // 
            this.btnKeres.Location = new System.Drawing.Point(12, 133);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(75, 23);
            this.btnKeres.TabIndex = 4;
            this.btnKeres.Text = "Keresés";
            this.btnKeres.UseVisualStyleBackColor = true;
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMegse);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.tbCim);
            this.panel1.Controls.Add(this.tbNev);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(114, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 180);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // btnMegse
            // 
            this.btnMegse.Location = new System.Drawing.Point(259, 145);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(75, 23);
            this.btnMegse.TabIndex = 7;
            this.btnMegse.Text = "Mégsem";
            this.btnMegse.UseVisualStyleBackColor = true;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(3, 145);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(68, 81);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // tbCim
            // 
            this.tbCim.Location = new System.Drawing.Point(61, 43);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(234, 23);
            this.tbCim.TabIndex = 4;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(61, 14);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(234, 23);
            this.tbNev.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cím:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 207);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKeres);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnBetolt);
            this.Controls.Add(this.btnMent);
            this.Controls.Add(this.btnUjBarat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnUjBarat;
        private Button btnMent;
        private Button btnBetolt;
        private Button btnList;
        private Button btnKeres;
        private Panel panel1;
        private Button btnMegse;
        private Button btnOK;
        private NumericUpDown numericUpDown1;
        private TextBox tbCim;
        private TextBox tbNev;
        private Label label3;
        private Label label2;
        private Label label1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}