using System;
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

        public relatorio2(string x, string y, string z)
        {
            InitializeComponent();

            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[3];

            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("media1", x);
            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("media2", y);
            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("media3", z);
   



            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void relatorio2_Load(object sender, EventArgs e)
        {
         for (int cont = 0; cont <= 3; cont++)
            {
                dadosBindingSource.Add(Class1.dados.GerarExemplo());
           }
            //dadosBindingSource.Add(Class1.dados.GerarExemplo());
                       
            this.reportViewer1.RefreshReport();
        }

       
    }
}

