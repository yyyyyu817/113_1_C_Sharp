namespace A113221069
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtdayofweek = new TextBox();
            textday = new TextBox();
            textmonth = new TextBox();
            textyear = new TextBox();
            label5 = new Label();
            btnshowday = new Button();
            btnclear = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(84, 52);
            label1.Name = "label1";
            label1.Size = new Size(96, 35);
            label1.TabIndex = 0;
            label1.Text = "星期幾";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(84, 148);
            label2.Name = "label2";
            label2.Size = new Size(69, 35);
            label2.TabIndex = 1;
            label2.Text = "日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(84, 245);
            label3.Name = "label3";
            label3.Size = new Size(69, 35);
            label3.TabIndex = 2;
            label3.Text = "月份";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(84, 347);
            label4.Name = "label4";
            label4.Size = new Size(69, 35);
            label4.TabIndex = 3;
            label4.Text = "年份";
            // 
            // txtdayofweek
            // 
            txtdayofweek.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtdayofweek.Location = new Point(321, 52);
            txtdayofweek.Name = "txtdayofweek";
            txtdayofweek.Size = new Size(153, 42);
            txtdayofweek.TabIndex = 4;
            // 
            // textday
            // 
            textday.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textday.Location = new Point(321, 148);
            textday.Name = "textday";
            textday.Size = new Size(153, 42);
            textday.TabIndex = 5;
            // 
            // textmonth
            // 
            textmonth.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textmonth.Location = new Point(321, 245);
            textmonth.Name = "textmonth";
            textmonth.Size = new Size(153, 42);
            textmonth.TabIndex = 6;
            // 
            // textyear
            // 
            textyear.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textyear.Location = new Point(321, 340);
            textyear.Name = "textyear";
            textyear.Size = new Size(153, 42);
            textyear.TabIndex = 7;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(94, 446);
            label5.Name = "label5";
            label5.Size = new Size(445, 67);
            label5.TabIndex = 8;
            // 
            // btnshowday
            // 
            btnshowday.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnshowday.Location = new Point(94, 621);
            btnshowday.Name = "btnshowday";
            btnshowday.Size = new Size(212, 48);
            btnshowday.TabIndex = 9;
            btnshowday.Text = "顯示完整日期";
            btnshowday.UseVisualStyleBackColor = true;
            btnshowday.Click += btnshowday_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnclear.Location = new Point(344, 621);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(144, 48);
            btnclear.TabIndex = 10;
            btnclear.Text = "清空內容";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnexit.Location = new Point(532, 621);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(144, 48);
            btnexit.TabIndex = 11;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 746);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btnshowday);
            Controls.Add(label5);
            Controls.Add(textyear);
            Controls.Add(textmonth);
            Controls.Add(textday);
            Controls.Add(txtdayofweek);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtdayofweek;
        private TextBox textday;
        private TextBox textmonth;
        private TextBox textyear;
        private Label label5;
        private Button btnshowday;
        private Button btnclear;
        private Button btnexit;
    }
}
