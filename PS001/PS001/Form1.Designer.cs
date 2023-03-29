namespace PS001
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.normálToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyújtottToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automatikusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.középreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nagyítottToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normálToolStripMenuItem,
            this.nyújtottToolStripMenuItem,
            this.automatikusToolStripMenuItem,
            this.középreToolStripMenuItem,
            this.nagyítottToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 114);
            // 
            // normálToolStripMenuItem
            // 
            this.normálToolStripMenuItem.Name = "normálToolStripMenuItem";
            this.normálToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.normálToolStripMenuItem.Text = "Normál";
            this.normálToolStripMenuItem.Click += new System.EventHandler(this.normálToolStripMenuItem_Click);
            // 
            // nyújtottToolStripMenuItem
            // 
            this.nyújtottToolStripMenuItem.Name = "nyújtottToolStripMenuItem";
            this.nyújtottToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.nyújtottToolStripMenuItem.Text = "Nyújtott";
            this.nyújtottToolStripMenuItem.Click += new System.EventHandler(this.nyújtottToolStripMenuItem_Click);
            // 
            // automatikusToolStripMenuItem
            // 
            this.automatikusToolStripMenuItem.Name = "automatikusToolStripMenuItem";
            this.automatikusToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.automatikusToolStripMenuItem.Text = "Automatikus";
            this.automatikusToolStripMenuItem.Click += new System.EventHandler(this.automatikusToolStripMenuItem_Click);
            // 
            // középreToolStripMenuItem
            // 
            this.középreToolStripMenuItem.Name = "középreToolStripMenuItem";
            this.középreToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.középreToolStripMenuItem.Text = "Középre";
            this.középreToolStripMenuItem.Click += new System.EventHandler(this.középreToolStripMenuItem_Click);
            // 
            // nagyítottToolStripMenuItem
            // 
            this.nagyítottToolStripMenuItem.Name = "nagyítottToolStripMenuItem";
            this.nagyítottToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.nagyítottToolStripMenuItem.Text = "Nagyított";
            this.nagyítottToolStripMenuItem.Click += new System.EventHandler(this.nagyítottToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(828, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Betöltés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(828, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mentés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(828, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Szinező";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(828, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Kontúr kereső";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(828, 158);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Vízjel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG fájlok|*.jpg";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPEG fájlok|*.jpg";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(818, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 23);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(834, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vízjel felirata:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem normálToolStripMenuItem;
        private ToolStripMenuItem nyújtottToolStripMenuItem;
        private ToolStripMenuItem automatikusToolStripMenuItem;
        private ToolStripMenuItem középreToolStripMenuItem;
        private ToolStripMenuItem nagyítottToolStripMenuItem;
        private TextBox textBox1;
        private Label label1;
    }
}