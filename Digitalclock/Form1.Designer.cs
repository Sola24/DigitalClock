namespace Digitalclock
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
            this.components = new System.ComponentModel.Container();
            this.timetxt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Closebtn = new System.Windows.Forms.Label();
            this.placaname = new System.Windows.Forms.Label();
            this.citylist = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Greetingtxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timetxt
            // 
            this.timetxt.AutoSize = true;
            this.timetxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.timetxt.Font = new System.Drawing.Font("MS UI Gothic", 58F, System.Drawing.FontStyle.Bold);
            this.timetxt.ForeColor = System.Drawing.Color.GreenYellow;
            this.timetxt.Location = new System.Drawing.Point(115, 84);
            this.timetxt.Name = "timetxt";
            this.timetxt.Size = new System.Drawing.Size(453, 116);
            this.timetxt.TabIndex = 0;
            this.timetxt.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Closebtn
            // 
            this.Closebtn.AutoSize = true;
            this.Closebtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.Closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebtn.ForeColor = System.Drawing.Color.Black;
            this.Closebtn.Location = new System.Drawing.Point(748, 10);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(32, 37);
            this.Closebtn.TabIndex = 1;
            this.Closebtn.Text = "x";
            this.Closebtn.Click += new System.EventHandler(this.Close_Click);
            // 
            // placaname
            // 
            this.placaname.AutoSize = true;
            this.placaname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.placaname.ForeColor = System.Drawing.Color.GreenYellow;
            this.placaname.Location = new System.Drawing.Point(134, 226);
            this.placaname.Name = "placaname";
            this.placaname.Size = new System.Drawing.Size(138, 29);
            this.placaname.TabIndex = 2;
            this.placaname.Text = "Local Clock";
            // 
            // citylist
            // 
            this.citylist.BackColor = System.Drawing.Color.DarkGreen;
            this.citylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.citylist.ForeColor = System.Drawing.Color.GreenYellow;
            this.citylist.FormattingEnabled = true;
            this.citylist.Items.AddRange(new object[] {
            "Lagos (Local Clock)",
            "Paris",
            "Vietnam",
            "Los Angeles",
            "Hong Kong"});
            this.citylist.Location = new System.Drawing.Point(507, 310);
            this.citylist.Name = "citylist";
            this.citylist.Size = new System.Drawing.Size(273, 28);
            this.citylist.TabIndex = 3;
            this.citylist.SelectedIndexChanged += new System.EventHandler(this.Citylist_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(134, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 37);
            this.label2.TabIndex = 4;
            // 
            // Greetingtxt
            // 
            this.Greetingtxt.AutoSize = true;
            this.Greetingtxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Italic);
            this.Greetingtxt.ForeColor = System.Drawing.Color.GreenYellow;
            this.Greetingtxt.Location = new System.Drawing.Point(117, 15);
            this.Greetingtxt.Name = "Greetingtxt";
            this.Greetingtxt.Size = new System.Drawing.Size(82, 41);
            this.Greetingtxt.TabIndex = 5;
            this.Greetingtxt.Text = "........";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(513, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Greetingtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.citylist);
            this.Controls.Add(this.placaname);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.timetxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Closebtn;
        private System.Windows.Forms.Label placaname;
        private System.Windows.Forms.ComboBox citylist;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label timetxt;
        public System.Windows.Forms.Label Greetingtxt;
        public System.Windows.Forms.Label label3;
    }
}

