using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.ctrlOrgChar1.DataSource = this.dt;
            this.ctrlOrgChar1.KeyFileName = "id";
            this.ctrlOrgChar1.ParentKeyFileName = "pid";
            this.ctrlOrgChar1.RootParentKeyValue= 0;
            this.ctrlOrgChar1.ShowChar();

        }



        DataTable dt;
        private void Form1_Load(object sender, EventArgs e)
        {
            dt=new DataTable();
            dt.Columns.Add(new DataColumn("id",typeof(int)));
            dt.Columns.Add(new DataColumn("pid", typeof(int)));
            dt.Columns.Add(new DataColumn("name", typeof(string)));
            dt.Rows.Add(new object[] { 40, 0, "1" });
            dt.Rows.Add(new object[] { 2, 40, "2" });
            dt.Rows.Add(new object[] { 3, 40, "3" });
            dt.Rows.Add(new object[] { 4, 2, "4" });
            dt.Rows.Add(new object[] { 5, 2, "5" });
            dt.Rows.Add(new object[] { 6, 3, "6" });
            dt.Rows.Add(new object[] { 7, 3, "7" });
            dt.Rows.Add(new object[] { 8, 3, "8" });
            dt.Rows.Add(new object[] { 9, 3, "9" });
         
  
            this.bindingSource1.DataSource = dt;
            this.bindingSource1.DataMember = dt.TableName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }
    
    }


   
}
