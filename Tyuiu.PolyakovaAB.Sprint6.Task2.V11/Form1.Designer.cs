using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.PolyakovaAB.Sprint6.Task2.V11
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            chart1 = new Chart();
            button2 = new Button();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Условие";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 47);
            label2.Name = "label2";
            label2.Size = new Size(222, 20);
            label2.TabIndex = 1;
            label2.Text = "Вывести решение по формуле";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 154);
            label3.Name = "label3";
            label3.Size = new Size(212, 20);
            label3.TabIndex = 2;
            label3.Text = "Введите стартовое значение:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 252);
            label4.Name = "label4";
            label4.Size = new Size(209, 20);
            label4.TabIndex = 3;
            label4.Text = "Введите конечное значение:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 293);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 27);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(35, 337);
            button1.Name = "button1";
            button1.Size = new Size(165, 101);
            button1.TabIndex = 6;
            button1.Text = "Решение";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonBoxClick_PAV;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(451, 21);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "f(x)";
            chart1.Series.Add(series1);
            chart1.Size = new Size(323, 399);
            chart1.TabIndex = 7;
            chart1.Text = "chart1";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Location = new Point(218, 402);
            button2.Name = "button2";
            button2.Size = new Size(66, 36);
            button2.TabIndex = 8;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonBoxClick2_PAV;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(261, 23);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 373);
            textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(chart1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button button2;
        private TextBox textBox3;
    }
}
