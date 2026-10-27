namespace Tyuiu.PolyakovaAB.Sprint6.Task1.V30
{
    partial class FormMain
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(33, 333);
            button1.Name = "button1";
            button1.Size = new Size(121, 105);
            button1.TabIndex = 0;
            button1.Text = "Результат";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonBoxClick_PAV;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Location = new Point(741, 399);
            button2.Name = "button2";
            button2.Size = new Size(51, 48);
            button2.TabIndex = 1;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonBoxClick2_PAV;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 24);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Условие";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 62);
            label2.Name = "label2";
            label2.Size = new Size(317, 20);
            label2.TabIndex = 3;
            label2.Text = "Вычислить значения по формуле в таблицу:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 152);
            label3.Name = "label3";
            label3.Size = new Size(217, 20);
            label3.TabIndex = 4;
            label3.Text = "Введите начальное значение:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 234);
            label4.Name = "label4";
            label4.Size = new Size(209, 20);
            label4.TabIndex = 5;
            label4.Text = "Введите конечное значение:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 280);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(455, 62);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(280, 338);
            textBox3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 24);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 9;
            label5.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
    }
}
