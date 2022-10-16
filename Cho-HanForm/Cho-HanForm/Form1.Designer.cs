
namespace Cho_HanForm
{
    partial class Cho_Han
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cho_Han));
            this.StartBTN = new System.Windows.Forms.Button();
            this.Intro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBTN
            // 
            this.StartBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StartBTN.AutoSize = true;
            this.StartBTN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StartBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StartBTN.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.StartBTN.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.StartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBTN.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StartBTN.Location = new System.Drawing.Point(601, 526);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(180, 79);
            this.StartBTN.TabIndex = 2;
            this.StartBTN.Text = "Start Game";
            this.StartBTN.UseCompatibleTextRendering = true;
            this.StartBTN.UseVisualStyleBackColor = false;
            // 
            // Intro
            // 
            this.Intro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Intro.BackColor = System.Drawing.SystemColors.Info;
            this.Intro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Intro.Font = new System.Drawing.Font("Javanese Text", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intro.Location = new System.Drawing.Point(57, 393);
            this.Intro.Name = "Intro";
            this.Intro.Size = new System.Drawing.Size(329, 241);
            this.Intro.TabIndex = 1;
            this.Intro.Text = "In this traditional Japanese dice game, two dice are rolled in a bamboo\r\ncup by t" +
    "he dealer sitting on the floor. The player must guess if the\r\ndice total to an e" +
    "ven (cho) or odd (han) number.";
            this.Intro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Intro.UseCompatibleTextRendering = true;
            this.Intro.Visible = false;
            this.Intro.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cho";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1067, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 65);
            this.button2.TabIndex = 5;
            this.button2.Text = "Han";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(716, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 303);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(117, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "Balance: $5000.00";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(598, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 56);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bet: $5.00";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(362, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 303);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Cho_Han
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1328, 672);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.Intro);
            this.Name = "Cho_Han";
            this.Text = "Cho_HanForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.Label Intro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

