namespace HighLow_TheEndOfCardgame
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
            this.P1_txt = new System.Windows.Forms.Label();
            this.P2_txt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.P1_num = new System.Windows.Forms.Label();
            this.P2_num = new System.Windows.Forms.Label();
            this.sdww = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maintxt = new System.Windows.Forms.Label();
            this.p1_drawagain = new System.Windows.Forms.Label();
            this.p2_drawagain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // P1_txt
            // 
            this.P1_txt.AutoSize = true;
            this.P1_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.P1_txt.Location = new System.Drawing.Point(55, 112);
            this.P1_txt.Name = "P1_txt";
            this.P1_txt.Size = new System.Drawing.Size(83, 55);
            this.P1_txt.TabIndex = 0;
            this.P1_txt.Text = "1A";
            this.P1_txt.Click += new System.EventHandler(this.label1_Click);
            // 
            // P2_txt
            // 
            this.P2_txt.AutoSize = true;
            this.P2_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.P2_txt.Location = new System.Drawing.Point(301, 112);
            this.P2_txt.Name = "P2_txt";
            this.P2_txt.Size = new System.Drawing.Size(83, 55);
            this.P2_txt.TabIndex = 1;
            this.P2_txt.Text = "1A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(66, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(312, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Player2";
            // 
            // P1_num
            // 
            this.P1_num.AutoSize = true;
            this.P1_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.P1_num.Location = new System.Drawing.Point(66, 195);
            this.P1_num.Name = "P1_num";
            this.P1_num.Size = new System.Drawing.Size(72, 24);
            this.P1_num.TabIndex = 4;
            this.P1_num.Text = "26 card";
            // 
            // P2_num
            // 
            this.P2_num.AutoSize = true;
            this.P2_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.P2_num.Location = new System.Drawing.Point(312, 195);
            this.P2_num.Name = "P2_num";
            this.P2_num.Size = new System.Drawing.Size(72, 24);
            this.P2_num.TabIndex = 5;
            this.P2_num.Text = "26 card";
            // 
            // sdww
            // 
            this.sdww.AutoSize = true;
            this.sdww.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.sdww.Location = new System.Drawing.Point(181, 31);
            this.sdww.Name = "sdww";
            this.sdww.Size = new System.Drawing.Size(88, 55);
            this.sdww.TabIndex = 6;
            this.sdww.Text = "VS";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(126, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maintxt
            // 
            this.maintxt.AutoSize = true;
            this.maintxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.maintxt.Location = new System.Drawing.Point(135, 231);
            this.maintxt.Name = "maintxt";
            this.maintxt.Size = new System.Drawing.Size(0, 29);
            this.maintxt.TabIndex = 8;
            // 
            // p1_drawagain
            // 
            this.p1_drawagain.AutoSize = true;
            this.p1_drawagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.p1_drawagain.Location = new System.Drawing.Point(12, 323);
            this.p1_drawagain.Name = "p1_drawagain";
            this.p1_drawagain.Size = new System.Drawing.Size(0, 16);
            this.p1_drawagain.TabIndex = 9;
            // 
            // p2_drawagain
            // 
            this.p2_drawagain.AutoSize = true;
            this.p2_drawagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.p2_drawagain.Location = new System.Drawing.Point(12, 373);
            this.p2_drawagain.Name = "p2_drawagain";
            this.p2_drawagain.Size = new System.Drawing.Size(0, 16);
            this.p2_drawagain.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 418);
            this.Controls.Add(this.p2_drawagain);
            this.Controls.Add(this.p1_drawagain);
            this.Controls.Add(this.maintxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sdww);
            this.Controls.Add(this.P2_num);
            this.Controls.Add(this.P1_num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.P2_txt);
            this.Controls.Add(this.P1_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label P1_txt;
        private System.Windows.Forms.Label P2_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label P1_num;
        private System.Windows.Forms.Label P2_num;
        private System.Windows.Forms.Label sdww;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label maintxt;
        private System.Windows.Forms.Label p1_drawagain;
        private System.Windows.Forms.Label p2_drawagain;
    }
}

