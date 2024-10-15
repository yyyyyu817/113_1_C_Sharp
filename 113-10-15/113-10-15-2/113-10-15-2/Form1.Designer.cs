namespace _113_10_15_2
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
            km_box = new TextBox();
            oil_box = new TextBox();
            lblshow = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("標楷體", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(93, 56);
            label1.Name = "label1";
            label1.Size = new Size(103, 29);
            label1.TabIndex = 0;
            label1.Text = "公里數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("標楷體", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(93, 136);
            label2.Name = "label2";
            label2.Size = new Size(133, 29);
            label2.TabIndex = 1;
            label2.Text = "公里油耗";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("標楷體", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(93, 233);
            label3.Name = "label3";
            label3.Size = new Size(178, 29);
            label3.TabIndex = 2;
            label3.Text = "公里/每公升";
            // 
            // km_box
            // 
            km_box.Location = new Point(336, 51);
            km_box.Name = "km_box";
            km_box.Size = new Size(126, 23);
            km_box.TabIndex = 3;
            // 
            // oil_box
            // 
            oil_box.Location = new Point(337, 142);
            oil_box.Name = "oil_box";
            oil_box.Size = new Size(126, 23);
            oil_box.TabIndex = 4;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Location = new Point(336, 231);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(124, 31);
            lblshow.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(103, 314);
            button1.Name = "button1";
            button1.Size = new Size(105, 36);
            button1.TabIndex = 6;
            button1.Text = "計算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(337, 314);
            button2.Name = "button2";
            button2.Size = new Size(105, 36);
            button2.TabIndex = 7;
            button2.Text = "離開";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblshow);
            Controls.Add(oil_box);
            Controls.Add(km_box);
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
        private TextBox km_box;
        private TextBox oil_box;
        private Label lblshow;
        private Button button1;
        private Button button2;
    }
}
