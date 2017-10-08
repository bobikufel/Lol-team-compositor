namespace LOL_team_compositor
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
            this.Top = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mid = new System.Windows.Forms.PictureBox();
            this.Jng = new System.Windows.Forms.PictureBox();
            this.Adc = new System.Windows.Forms.PictureBox();
            this.Sup = new System.Windows.Forms.PictureBox();
            this.Reroll = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sup)).BeginInit();
            this.SuspendLayout();
            // 
            // Top
            // 
            this.Top.Image = global::LOL_team_compositor.Properties.Resources.Aatrox;
            this.Top.Location = new System.Drawing.Point(50, 51);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(60, 60);
            this.Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Top.TabIndex = 1;
            this.Top.TabStop = false;
            this.Top.Click += new System.EventHandler(this.Top_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOL_team_compositor.Properties.Resources.Summoner_s_Rift_Minimap_old2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Mid
            // 
            this.Mid.Image = global::LOL_team_compositor.Properties.Resources.Aatrox;
            this.Mid.Location = new System.Drawing.Point(238, 235);
            this.Mid.Name = "Mid";
            this.Mid.Size = new System.Drawing.Size(60, 60);
            this.Mid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mid.TabIndex = 2;
            this.Mid.TabStop = false;
            // 
            // Jng
            // 
            this.Jng.Image = global::LOL_team_compositor.Properties.Resources.Aatrox;
            this.Jng.Location = new System.Drawing.Point(102, 216);
            this.Jng.Name = "Jng";
            this.Jng.Size = new System.Drawing.Size(60, 60);
            this.Jng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Jng.TabIndex = 3;
            this.Jng.TabStop = false;
            // 
            // Adc
            // 
            this.Adc.Image = global::LOL_team_compositor.Properties.Resources.Aatrox;
            this.Adc.Location = new System.Drawing.Point(383, 392);
            this.Adc.Name = "Adc";
            this.Adc.Size = new System.Drawing.Size(60, 60);
            this.Adc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Adc.TabIndex = 4;
            this.Adc.TabStop = false;
            // 
            // Sup
            // 
            this.Sup.Image = global::LOL_team_compositor.Properties.Resources.Aatrox;
            this.Sup.Location = new System.Drawing.Point(449, 458);
            this.Sup.Name = "Sup";
            this.Sup.Size = new System.Drawing.Size(60, 60);
            this.Sup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sup.TabIndex = 5;
            this.Sup.TabStop = false;
            // 
            // Reroll
            // 
            this.Reroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Reroll.Location = new System.Drawing.Point(50, 383);
            this.Reroll.Name = "Reroll";
            this.Reroll.Size = new System.Drawing.Size(112, 108);
            this.Reroll.TabIndex = 6;
            this.Reroll.Text = "LOSUJ";
            this.Reroll.UseVisualStyleBackColor = true;
            this.Reroll.Click += new System.EventHandler(this.Reroll_Click);
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(305, 51);
            this.Test.Multiline = true;
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(193, 92);
            this.Test.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 538);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.Reroll);
            this.Controls.Add(this.Sup);
            this.Controls.Add(this.Adc);
            this.Controls.Add(this.Jng);
            this.Controls.Add(this.Mid);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Top;
        private System.Windows.Forms.PictureBox Mid;
        private System.Windows.Forms.PictureBox Jng;
        private System.Windows.Forms.PictureBox Adc;
        private System.Windows.Forms.PictureBox Sup;
        private System.Windows.Forms.Button Reroll;
        private System.Windows.Forms.TextBox Test;
    }
}

