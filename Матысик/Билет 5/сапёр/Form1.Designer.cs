namespace сапёр
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
            this.infa = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rasst_min = new System.Windows.Forms.TextBox();
            this.koordy = new System.Windows.Forms.TextBox();
            this.koordx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kolvo_min = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.infa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kolvo_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // infa
            // 
            this.infa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infa.BackColor = System.Drawing.Color.Brown;
            this.infa.Controls.Add(this.exit);
            this.infa.Controls.Add(this.start);
            this.infa.Controls.Add(this.label5);
            this.infa.Controls.Add(this.label4);
            this.infa.Controls.Add(this.label3);
            this.infa.Controls.Add(this.label2);
            this.infa.Controls.Add(this.rasst_min);
            this.infa.Controls.Add(this.koordy);
            this.infa.Controls.Add(this.koordx);
            this.infa.Controls.Add(this.label1);
            this.infa.Controls.Add(this.kolvo_min);
            this.infa.Location = new System.Drawing.Point(885, -10);
            this.infa.Margin = new System.Windows.Forms.Padding(2);
            this.infa.Name = "infa";
            this.infa.Padding = new System.Windows.Forms.Padding(2);
            this.infa.Size = new System.Drawing.Size(291, 567);
            this.infa.TabIndex = 0;
            this.infa.TabStop = false;
            this.infa.Text = " ";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(162, 431);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(82, 39);
            this.exit.TabIndex = 11;
            this.exit.Text = "ВЫХОД";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(59, 431);
            this.start.Margin = new System.Windows.Forms.Padding(2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(82, 39);
            this.start.TabIndex = 10;
            this.start.Text = "СТАРТ";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Расстояние до мины";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ваши координаты";
            // 
            // rasst_min
            // 
            this.rasst_min.Location = new System.Drawing.Point(55, 381);
            this.rasst_min.Margin = new System.Windows.Forms.Padding(2);
            this.rasst_min.Name = "rasst_min";
            this.rasst_min.Size = new System.Drawing.Size(189, 27);
            this.rasst_min.TabIndex = 4;
            // 
            // koordy
            // 
            this.koordy.Location = new System.Drawing.Point(168, 277);
            this.koordy.Margin = new System.Windows.Forms.Padding(2);
            this.koordy.Name = "koordy";
            this.koordy.Size = new System.Drawing.Size(53, 27);
            this.koordy.TabIndex = 3;
            // 
            // koordx
            // 
            this.koordx.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.koordx.Location = new System.Drawing.Point(51, 277);
            this.koordx.Margin = new System.Windows.Forms.Padding(2);
            this.koordx.Name = "koordx";
            this.koordx.Size = new System.Drawing.Size(41, 27);
            this.koordx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество мин";
            // 
            // kolvo_min
            // 
            this.kolvo_min.Location = new System.Drawing.Point(59, 138);
            this.kolvo_min.Margin = new System.Windows.Forms.Padding(2);
            this.kolvo_min.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.kolvo_min.Name = "kolvo_min";
            this.kolvo_min.Size = new System.Drawing.Size(140, 27);
            this.kolvo_min.TabIndex = 0;
            this.kolvo_min.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kolvo_min.ValueChanged += new System.EventHandler(this.kolvo_min_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(172, 201);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 89);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::сапёр.Properties.Resources.mina;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(172, 201);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 89);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::сапёр.Properties.Resources._1626158263_9_kartinkin_com_p_futbolnoe_pole_tekstura_krasivo_11;
            this.ClientSize = new System.Drawing.Size(1173, 558);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.infa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Минер 3000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.infa.ResumeLayout(false);
            this.infa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kolvo_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox infa;
        private TextBox koordy;
        private TextBox koordx;
        private Label label1;
        private NumericUpDown kolvo_min;
        private PictureBox pictureBox1;
        private TextBox rasst_min;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private Button exit;
        private Button start;
    }
}