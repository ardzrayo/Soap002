using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteSoap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiServicioSoap.Service1Client oClient = new MiServicioSoap.Service1Client();
            string res=oClient.GetData(10,9);
            MessageBox.Show(res);

            MiServicioSoap.CompositeType oData = new MiServicioSoap.CompositeType();
            oData.BoolValue = true;
            var res2 = oClient.GetDataUsingDataContract(oData);
            MessageBox.Show(res2.StringValue);
        }
    }
}
