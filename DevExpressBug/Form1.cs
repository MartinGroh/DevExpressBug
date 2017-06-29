using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressBug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bFill_Click(object sender, EventArgs e)
        {
            List<MyData> data = new List<MyData>();
            for (int i = 0; i < 200; i++)
            {
                data.Add(new MyData { Name = $"Elemet{i}", Value = 0 });
            }
            for (int i = 0; i < 10; i++)
            {
                data[9 - i].Value = i * 10;
            }

            gridControl1.DataSource = data;
        }

        private void bRef_Click(object sender, EventArgs e)
        {
            gridControl1.RefreshDataSource();
        }
    }
}
