
namespace AYAZpaint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.yellow = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.grey = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.bgblack = new System.Windows.Forms.Button();
            this.bgwight = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bgwight);
            this.panel1.Controls.Add(this.bgblack);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 685);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.blue);
            this.panel2.Controls.Add(this.grey);
            this.panel2.Controls.Add(this.red);
            this.panel2.Controls.Add(this.yellow);
            this.panel2.Location = new System.Drawing.Point(978, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 35);
            this.panel2.TabIndex = 0;
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.FlatAppearance.BorderSize = 0;
            this.yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellow.Location = new System.Drawing.Point(3, 9);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(35, 23);
            this.yellow.TabIndex = 1;
            this.yellow.UseVisualStyleBackColor = false;
            this.yellow.Click += new System.EventHandler(this.yellow_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.FlatAppearance.BorderSize = 0;
            this.red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.red.Location = new System.Drawing.Point(55, 9);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(35, 23);
            this.red.TabIndex = 2;
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // grey
            // 
            this.grey.BackColor = System.Drawing.Color.Gray;
            this.grey.FlatAppearance.BorderSize = 0;
            this.grey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grey.Location = new System.Drawing.Point(113, 9);
            this.grey.Name = "grey";
            this.grey.Size = new System.Drawing.Size(35, 23);
            this.grey.TabIndex = 2;
            this.grey.UseVisualStyleBackColor = false;
            this.grey.Click += new System.EventHandler(this.grey_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.FlatAppearance.BorderSize = 0;
            this.blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blue.Location = new System.Drawing.Point(162, 9);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(35, 23);
            this.blue.TabIndex = 2;
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // bgblack
            // 
            this.bgblack.BackColor = System.Drawing.Color.Black;
            this.bgblack.FlatAppearance.BorderSize = 0;
            this.bgblack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgblack.Location = new System.Drawing.Point(357, 660);
            this.bgblack.Name = "bgblack";
            this.bgblack.Size = new System.Drawing.Size(31, 22);
            this.bgblack.TabIndex = 1;
            this.bgblack.UseVisualStyleBackColor = false;
            this.bgblack.Click += new System.EventHandler(this.bgblack_Click);
            // 
            // bgwight
            // 
            this.bgwight.BackColor = System.Drawing.Color.White;
            this.bgwight.FlatAppearance.BorderSize = 0;
            this.bgwight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgwight.Location = new System.Drawing.Point(613, 660);
            this.bgwight.Name = "bgwight";
            this.bgwight.Size = new System.Drawing.Size(31, 22);
            this.bgwight.TabIndex = 2;
            this.bgwight.UseVisualStyleBackColor = false;
            this.bgwight.Click += new System.EventHandler(this.bgwight_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AYAZpaint.Properties.Resources.ayaz___Copy;
            this.pictureBox1.Location = new System.Drawing.Point(3, 573);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 112);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 685);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "AYAZpaint";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button grey;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Button bgblack;
        private System.Windows.Forms.Button bgwight;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

