using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace WindowsFormsApplication18
{

    public partial class Form1 : Form
    {
        double x = 0, y = 0, z = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string[] port = SerialPort.GetPortNames();
            portname.Items.Clear();
            portname.Items.AddRange(port);

            timer2.Enabled = true;
        }

        private float counter = 0;
        private float counter1 = 0;
        private int i = 0;
        private float sinal = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {


            counter++;

            sinal--;

            if (chart1.Series[0].Points.Count > 110)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Update();
            }

            chart1.Series[0].Points.AddY((Math.Sin(counter * (3.1416 / 45))));

            textBox1.Text = (counter * (3.1416 / 45)).ToString();

            if (chart1.Series[1].Points.Count > 110)
            {
                chart1.Series[1].Points.RemoveAt(0);
                chart1.Update();

            }
            chart1.Series[1].Points.AddY((Math.Sin(sinal * (3.1416 / 45))));

            textBox2.Text = (sinal * (3.1416 / 45)).ToString();

        }


        private void Open_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                Open.Text = ("Conectar");


            }
            else
            {
                serialPort1.PortName = portname.Text;

                try
                {
                    if (!serialPort1.IsOpen)

                    {
                        serialPort1.Open();
                        Open.Text = ("Desconectar");
                    }

                }
                catch (Exception err)

                {
                    MessageBox.Show(this, err.Message);
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }



        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {



            try
            {
                /* dados dados = new global::dados();

                 dados.media1 = 100;
                 dados.media2 = Single.Parse(textBox5.Text);
                 dados.media3 = Single.Parse(textBox6.Text);
 */
                x = Single.Parse(txt1.Text);
                y = Single.Parse(txt2.Text);
                z = Single.Parse(txt3.Text);

                Class1.valores.valor[0] = txt1.Text;
                Class1.valores.valor[1] = txt2.Text;
                Class1.valores.valor[2] = txt3.Text;

                relatorio2 imprimirDadosRelatorio = new relatorio2(x.ToString(), y.ToString(), z.ToString());


                imprimirDadosRelatorio.Show();

            }
            catch (Exception err)
            {
                MessageBox.Show("Entre com valores os textbox ");
            }
            // chart1.Printing.PrintPreview();
        

          
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
           
            Single a, b, c;

            Single[] valor2 = new Single[] { 1, 2, 3,4,5,6,7,8,9 };
            Random aleatorio = new Random();

            Class1.valores.valor[0] = Convert.ToString(valor2[aleatorio.Next(9)]);
            Class1.valores.valor[1] = Convert.ToString(valor2[aleatorio.Next(9)]);
            Class1.valores.valor[2] = Convert.ToString(valor2[aleatorio.Next(9)]);

            a = Convert.ToSingle(Class1.valores.valor[0]);
            b = Convert.ToSingle(Class1.valores.valor[1]);
            c = Convert.ToSingle(Class1.valores.valor[2]);

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            if (chart1.Series[0].Points.Count > 3)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Update();

            }

            chart1.Series[0].Points.AddY(a);
            chart1.Series[0].Points.AddY(b);
            chart1.Series[0].Points.AddY(c);


           // Class1.valores.valor[0] = Convert.ToString(valor2[aleatorio.Next(10)]);
            //Class1.valores.valor[1] = Convert.ToString(valor2[aleatorio.Next(10)]);
            //Class1.valores.valor[2] = Convert.ToString(valor2[aleatorio.Next(10)]);

            //if (chart1.Series[1].Points.Count > 15)
           // {
            //    chart1.Series[1].Points.RemoveAt(0);
             //   chart1.Update();

          //  }

          //  chart1.Series[1].Points.AddY(Convert.ToString(valor2[aleatorio.Next(10)]));
           // chart1.Series[1].Points.AddY(Convert.ToString(valor2[aleatorio.Next(10)]));
           // chart1.Series[1].Points.AddY(Convert.ToString(valor2[aleatorio.Next(10)]));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            timer1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chart1.Series[0].Enabled == true) {
                chart1.Series[0].Enabled = false;
                button4.Text = "Show serie[0]";
            }
            else { 
                chart1.Series[0].Enabled = true; ;
                button4.Text = "Hiden serie[0]";
            }
         


        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (chart1.Series[1].Enabled == true)
            {
                chart1.Series[1].Enabled = false;
                button5.Text = "Show serie[1]";
            }
            else
            {
                chart1.Series[1].Enabled = true; ;
                button5.Text = "Hiden serie[1]";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            relatorio2 imprimirDadosRelatorio = new relatorio2(x.ToString(), y.ToString(), z.ToString());
            imprimirDadosRelatorio.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            grafico.ForeColor = Color.FromArgb(r.Next(0, 256),
        r.Next(0, 256), r.Next(0, 256));
        }

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            chart1.Printing.PrintPreview();
        }


        private void valor_Click(object sender, EventArgs e)
        {

            if (counter1 >= 10)
                i = -3;
            if (counter1 <= - 10)
                i = +3;

            

            if (chart1.Series[0].Points.Count > 15)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Update();

            }
            if (chart1.Series[1].Points.Count > 15)
            {
                chart1.Series[1].Points.RemoveAt(0);
                chart1.Update();

            }

            chart1.Series[0].Points.AddXY(i,counter1);
            chart1.Series[1].Points.AddXY(i,counter1);
          
            counter1 +=i;


        }



    }
}

/*public class dados
{
    

    public Single media1 { get; set; }
    public Single media2 { get; set; }
    public Single media3 { get; set; }

    public static dados GerarExemplo() 
    {
    

        Single m1 = 1; /// na
        Single m2 = 4;
        Single m3 = 10;


        return new dados()
        {
            media1 = m1,
            media2 = m2,
            media3 = m3
        };
}
}*/





/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication18
{
    public partial class relatorio2 : Form
    {
        public relatorio2(string x, string y, string z, string k)
        {
            InitializeComponent();

            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[4];

            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("x", x);
            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("y", y);
            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("z", z);
            p[3] = new Microsoft.Reporting.WinForms.ReportParameter("k", k);



            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void relatorio2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

        }
    }
}
*/
