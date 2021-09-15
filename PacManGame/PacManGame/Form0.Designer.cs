
namespace PacManGame
{
    partial class Form0
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
            this.button1 = new System.Windows.Forms.Button();
            this.pacman = new System.Windows.Forms.PictureBox();
            this.pinkghost = new System.Windows.Forms.PictureBox();
            this.yellowghost = new System.Windows.Forms.PictureBox();
            this.redghost = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(116, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Нажмите, что бы начать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.VisibleChanged += new System.EventHandler(this.button1_Click);
            // 
            // pacman
            // 
            this.pacman.Image = global::PacManGame.Properties.Resources.right;
            this.pacman.Location = new System.Drawing.Point(33, 59);
            this.pacman.Margin = new System.Windows.Forms.Padding(2);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(50, 50);
            this.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacman.TabIndex = 45;
            this.pacman.TabStop = false;
            // 
            // pinkghost
            // 
            this.pinkghost.Image = global::PacManGame.Properties.Resources.pink_guy;
            this.pinkghost.Location = new System.Drawing.Point(372, 167);
            this.pinkghost.Margin = new System.Windows.Forms.Padding(2);
            this.pinkghost.Name = "pinkghost";
            this.pinkghost.Size = new System.Drawing.Size(37, 48);
            this.pinkghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinkghost.TabIndex = 42;
            this.pinkghost.TabStop = false;
            this.pinkghost.Tag = "ghost";
            // 
            // yellowghost
            // 
            this.yellowghost.Image = global::PacManGame.Properties.Resources.yellow_guy;
            this.yellowghost.Location = new System.Drawing.Point(116, 20);
            this.yellowghost.Margin = new System.Windows.Forms.Padding(2);
            this.yellowghost.Name = "yellowghost";
            this.yellowghost.Size = new System.Drawing.Size(37, 48);
            this.yellowghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowghost.TabIndex = 43;
            this.yellowghost.TabStop = false;
            this.yellowghost.Tag = "ghost";
            // 
            // redghost
            // 
            this.redghost.BackColor = System.Drawing.Color.Black;
            this.redghost.Image = global::PacManGame.Properties.Resources.red_guy;
            this.redghost.Location = new System.Drawing.Point(65, 234);
            this.redghost.Margin = new System.Windows.Forms.Padding(2);
            this.redghost.Name = "redghost";
            this.redghost.Size = new System.Drawing.Size(37, 48);
            this.redghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redghost.TabIndex = 44;
            this.redghost.TabStop = false;
            this.redghost.Tag = "ghost";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PacManGame.Properties.Resources.right;
            this.pictureBox1.Location = new System.Drawing.Point(190, 275);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PacManGame.Properties.Resources.right;
            this.pictureBox2.Location = new System.Drawing.Point(336, 40);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(430, 349);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pacman);
            this.Controls.Add(this.pinkghost);
            this.Controls.Add(this.yellowghost);
            this.Controls.Add(this.redghost);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form0";
            this.Click += new System.EventHandler(this.button1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pacman;
        private System.Windows.Forms.PictureBox pinkghost;
        private System.Windows.Forms.PictureBox yellowghost;
        private System.Windows.Forms.PictureBox redghost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}