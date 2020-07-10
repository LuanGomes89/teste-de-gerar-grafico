namespace WindowsFormsApplication18
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.baud = new System.Windows.Forms.TextBox();
            this.portname = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.valor = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grafico = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(2, 37);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.CustomProperties = "LineTension=0";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 6;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.CustomProperties = "LineTension=0";
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(658, 285);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(2, 328);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(94, 26);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(102, 328);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(97, 26);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(667, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(667, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teste sensor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Teste sensor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Serial Port";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(666, 328);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(100, 26);
            this.Open.TabIndex = 9;
            this.Open.Text = "Conectar";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "BaudRate";
            // 
            // baud
            // 
            this.baud.Location = new System.Drawing.Point(666, 298);
            this.baud.Multiline = true;
            this.baud.Name = "baud";
            this.baud.Size = new System.Drawing.Size(100, 20);
            this.baud.TabIndex = 11;
            this.baud.Text = "300\r\n9600\r\n1153200\r\n";
            // 
            // portname
            // 
            this.portname.FormattingEnabled = true;
            this.portname.Location = new System.Drawing.Point(667, 236);
            this.portname.Name = "portname";
            this.portname.Size = new System.Drawing.Size(100, 21);
            this.portname.TabIndex = 12;
            this.portname.Text = "COM1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(455, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "Print do chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(667, 117);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(101, 85);
            this.valor.TabIndex = 14;
            this.valor.Text = "+1 / -1";
            this.valor.UseVisualStyleBackColor = true;
            this.valor.Click += new System.EventHandler(this.valor_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(84, 445);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(63, 20);
            this.txt1.TabIndex = 16;
            this.txt1.Text = "1";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(156, 445);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(63, 20);
            this.txt2.TabIndex = 17;
            this.txt2.Text = "2";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(228, 445);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(63, 20);
            this.txt3.TabIndex = 18;
            this.txt3.Text = "3";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(3, 442);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 19;
            this.btnSalva.Text = "Imprimir";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Gerar gráfico para impressão aleatório";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Clean tudo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Hiden serie[0]";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(102, 360);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Hiden serie[1]";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(505, 359);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "imprime gráfico gerado";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Gera um gráfico com 3 valores para Y";
            // 
            // grafico
            // 
            this.grafico.AutoSize = true;
            this.grafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grafico.Location = new System.Drawing.Point(503, 400);
            this.grafico.Name = "grafico";
            this.grafico.Size = new System.Drawing.Size(279, 73);
            this.grafico.TabIndex = 26;
            this.grafico.Text = "Gráficos";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker1.TabIndex = 27;
         
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 485);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.portname);
            this.Controls.Add(this.baud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox baud;
        private System.Windows.Forms.ComboBox portname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button valor;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label grafico;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer2;
    }
}

