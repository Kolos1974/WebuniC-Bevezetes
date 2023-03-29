namespace Valasztasok
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnUJ = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnBetoltes = new System.Windows.Forms.Button();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbVaros = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 334);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // btnUJ
            // 
            this.btnUJ.Location = new System.Drawing.Point(212, 12);
            this.btnUJ.Name = "btnUJ";
            this.btnUJ.Size = new System.Drawing.Size(117, 23);
            this.btnUJ.TabIndex = 1;
            this.btnUJ.Text = "Új adat felvitele";
            this.btnUJ.UseVisualStyleBackColor = true;
            this.btnUJ.Click += new System.EventHandler(this.btnUJ_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(212, 41);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(117, 23);
            this.btnMentes.TabIndex = 2;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnBetoltes
            // 
            this.btnBetoltes.Location = new System.Drawing.Point(212, 70);
            this.btnBetoltes.Name = "btnBetoltes";
            this.btnBetoltes.Size = new System.Drawing.Size(117, 23);
            this.btnBetoltes.TabIndex = 3;
            this.btnBetoltes.Text = "Betöltés";
            this.btnBetoltes.UseVisualStyleBackColor = true;
            this.btnBetoltes.Click += new System.EventHandler(this.btnBetoltes_Click);
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(335, 13);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(193, 23);
            this.tbNev.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(408, 43);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(486, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(42, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Nő";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbVaros
            // 
            this.tbVaros.Location = new System.Drawing.Point(335, 103);
            this.tbVaros.Name = "tbVaros";
            this.tbVaros.Size = new System.Drawing.Size(193, 23);
            this.tbVaros.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 367);
            this.Controls.Add(this.tbVaros);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.btnBetoltes);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnUJ);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Button btnUJ;
        private Button btnMentes;
        private Button btnBetoltes;
        private TextBox tbNev;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox1;
        private TextBox tbVaros;
    }
}