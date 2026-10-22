namespace Tyuiu.PolyakovaAB.Sprint6.Task0.V19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBoxF_PAV = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxF_PAV).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(28, 323);
            button1.Name = "button1";
            button1.Size = new Size(155, 79);
            button1.TabIndex = 0;
            button1.Text = "Решить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonBoxClick_PAV;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 268);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 27);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBoxKeyPress_PAV;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 375);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 27);
            textBox2.TabIndex = 2;
            // 
            // pictureBoxF_PAV
            // 
            pictureBoxF_PAV.ErrorImage = null;
            pictureBoxF_PAV.Image = (Image)resources.GetObject("pictureBoxF_PAV.Image");
            pictureBoxF_PAV.Location = new Point(538, 42);
            pictureBoxF_PAV.Name = "pictureBoxF_PAV";
            pictureBoxF_PAV.Size = new Size(209, 65);
            pictureBoxF_PAV.TabIndex = 3;
            pictureBoxF_PAV.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 4;
            label1.Text = "Условие";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 60);
            label2.Name = "label2";
            label2.Size = new Size(439, 20);
            label2.TabIndex = 5;
            label2.Text = "Ввести значение Х, вставить в формулу  и получить результат";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 234);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 6;
            label3.Text = "Введите Х:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 332);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 7;
            label4.Text = "Ответ:";
            // 
            // button2
            // 
            button2.Location = new Point(713, 370);
            button2.Name = "button2";
            button2.Size = new Size(34, 32);
            button2.TabIndex = 8;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonBoxClick2_PAV;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 430);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxF_PAV);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "FormMain";
            Text = "FormMain_PAV";
            ((System.ComponentModel.ISupportInitialize)pictureBoxF_PAV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        public PictureBox pictureBoxF_PAV;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
    }
}
