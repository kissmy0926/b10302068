﻿namespace B10302002project
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1136, 769);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1200, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1200, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "骰子";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1312, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "[Money]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1212, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1312, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "[Player]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1212, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1321, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "[Step]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1221, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Step";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1200, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "End";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1185, 583);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(224, 219);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 840);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

