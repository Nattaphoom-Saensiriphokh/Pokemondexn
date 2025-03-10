namespace PokemondexN
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
            btnPikachu = new Button();
            btnEspeon = new Button();
            bthHatterene = new Button();
            btnSwirlix = new Button();
            bthJigglypuff = new Button();
            bthAlcremie = new Button();
            lbName = new Label();
            lbType = new Label();
            lbStats = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPikachu
            // 
            btnPikachu.BackColor = Color.White;
            btnPikachu.ForeColor = Color.MediumVioletRed;
            btnPikachu.Location = new Point(40, 35);
            btnPikachu.Name = "btnPikachu";
            btnPikachu.Size = new Size(94, 29);
            btnPikachu.TabIndex = 0;
            btnPikachu.Text = "Pikachu";
            btnPikachu.UseVisualStyleBackColor = false;
            btnPikachu.Click += btnPikachu_Click;
            // 
            // btnEspeon
            // 
            btnEspeon.ForeColor = Color.DeepPink;
            btnEspeon.Location = new Point(40, 103);
            btnEspeon.Name = "btnEspeon";
            btnEspeon.Size = new Size(94, 29);
            btnEspeon.TabIndex = 1;
            btnEspeon.Text = "Espeon";
            btnEspeon.UseVisualStyleBackColor = true;
            btnEspeon.Click += btnEspeon_Click;
            // 
            // bthHatterene
            // 
            bthHatterene.ForeColor = Color.HotPink;
            bthHatterene.Location = new Point(40, 165);
            bthHatterene.Name = "bthHatterene";
            bthHatterene.Size = new Size(94, 29);
            bthHatterene.TabIndex = 2;
            bthHatterene.Text = "Hatterene";
            bthHatterene.UseVisualStyleBackColor = true;
            bthHatterene.Click += bthHatterene_Click;
            // 
            // btnSwirlix
            // 
            btnSwirlix.ForeColor = Color.PaleVioletRed;
            btnSwirlix.Location = new Point(40, 233);
            btnSwirlix.Name = "btnSwirlix";
            btnSwirlix.Size = new Size(94, 29);
            btnSwirlix.TabIndex = 3;
            btnSwirlix.Text = "Swirlix";
            btnSwirlix.UseVisualStyleBackColor = true;
            btnSwirlix.Click += btnSwirlix_Click;
            // 
            // bthJigglypuff
            // 
            bthJigglypuff.ForeColor = Color.Pink;
            bthJigglypuff.Location = new Point(40, 301);
            bthJigglypuff.Name = "bthJigglypuff";
            bthJigglypuff.Size = new Size(94, 29);
            bthJigglypuff.TabIndex = 4;
            bthJigglypuff.Text = "Jigglypuff";
            bthJigglypuff.UseVisualStyleBackColor = true;
            bthJigglypuff.Click += bthJigglypuff_Click;
            // 
            // bthAlcremie
            // 
            bthAlcremie.ForeColor = Color.LightPink;
            bthAlcremie.Location = new Point(40, 362);
            bthAlcremie.Name = "bthAlcremie";
            bthAlcremie.Size = new Size(94, 29);
            bthAlcremie.TabIndex = 5;
            bthAlcremie.Text = "Alcremie";
            bthAlcremie.UseVisualStyleBackColor = true;
            bthAlcremie.Click += bthAlcremie_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.ForeColor = Color.MediumVioletRed;
            lbName.Location = new Point(479, 89);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 6;
            lbName.Text = "Name";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.ForeColor = Color.DeepPink;
            lbType.Location = new Point(479, 125);
            lbType.Name = "lbType";
            lbType.Size = new Size(40, 20);
            lbType.TabIndex = 7;
            lbType.Text = "Type";
            // 
            // lbStats
            // 
            lbStats.AutoSize = true;
            lbStats.ForeColor = Color.HotPink;
            lbStats.Location = new Point(479, 165);
            lbStats.Name = "lbStats";
            lbStats.Size = new Size(75, 20);
            lbStats.TabIndex = 8;
            lbStats.Text = "BasicStats";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pikachu;
            pictureBox1.Location = new Point(172, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lbStats);
            Controls.Add(lbType);
            Controls.Add(lbName);
            Controls.Add(bthAlcremie);
            Controls.Add(bthJigglypuff);
            Controls.Add(btnSwirlix);
            Controls.Add(bthHatterene);
            Controls.Add(btnEspeon);
            Controls.Add(btnPikachu);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPikachu;
        private Button btnEspeon;
        private Button bthHatterene;
        private Button btnSwirlix;
        private Button bthJigglypuff;
        private Button bthAlcremie;
        private Label lbName;
        private Label lbType;
        private Label lbStats;
        private PictureBox pictureBox1;
    }
}
