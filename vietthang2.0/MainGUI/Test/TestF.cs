using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class TestF : Form
    {
        public TestF()
        {
            InitializeComponent();
            prepareData();
        }
        private void prepareData()
        {
            List<Test> l = new List<Test>();
            l.Add(new Test("Huy"));
            l.Add(new Test("Tri"));
            l.Add(new Test("Thien"));
            this.gridControl1.DataSource = l;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = (DateTime)this.dateEdit1.EditValue;
        }
    }
    public class Test
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Test(string name)
        {
            this.name = name;
        }
	
    }
}
