using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        //DataTable dt;
        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select id,pid,name from tb_zuzhijiagou ";

            DataTable dt = SQLHELP.GetDataTable(sql, CommandType.Text);
            //dt.Rows.Add(new object[] {1, 0, "总经办" });
            //dt.Rows.Add(new object[] { 2, 1, "市场部" });
            //dt.Rows.Add(new object[] { 3, 1, "技术部" });
            //dt.Rows.Add(new object[] { 4, 1, "研发部" });
            //dt.Rows.Add(new object[] { 5, 1, "物流部" });
            //dt.Rows.Add(new object[] { 6, 1, "质监部" });
            //dt.Rows.Add(new object[] { 7, 1, "财务部" });
            //dt.Rows.Add(new object[] { 8, 1, "部门分组" });
            //dt.Rows.Add(new object[] { 9, 1, "人力资源部" });
            //dt.Rows.Add(new object[] { 10, 1, "行政部" });

            //dt.Rows.Add(new object[] { 11, 2, "市场部分组" });           
            //dt.Rows.Add(new object[] { 12, 3, "线缆事业部" });
            //dt.Rows.Add(new object[] { 13, 3, "薄材事业部" });
            //dt.Rows.Add(new object[] { 14, 3, "智能事业部" });
            //dt.Rows.Add(new object[] { 15, 3, "石英事业部" });
            //dt.Rows.Add(new object[] { 16, 3, "新材事业部" });                      
            //dt.Rows.Add(new object[] { 17, 8, "模具事业部" });
            //dt.Rows.Add(new object[] { 18, 8, "信息化事业部" });
            //dt.Rows.Add(new object[] { 19, 8, "精工事业部" });
            //dt.Rows.Add(new object[] { 20, 8, "培训事业部" });
            //dt.Rows.Add(new object[] { 21, 10, "行政部分组" });


            //dt.Rows.Add(new object[] { 22, 11, "线缆组" });
            //dt.Rows.Add(new object[] { 23, 11, "石英组" });
            //dt.Rows.Add(new object[] { 24, 11, "薄材组" });
            //dt.Rows.Add(new object[] { 25, 11, "精工组" });
            //dt.Rows.Add(new object[] { 26, 11, "智能组" });
            //dt.Rows.Add(new object[] { 27, 11, "新材组" });
            //dt.Rows.Add(new object[] { 28, 11, "信息化组" });
            //dt.Rows.Add(new object[] { 29, 11, "海外组" });


            //dt.Rows.Add(new object[] { 30, 17, "生产管理室" });
            //dt.Rows.Add(new object[] { 31, 17, "技术组" });
            //dt.Rows.Add(new object[] { 32, 17, "车间" });
            //dt.Rows.Add(new object[] { 33, 17, "市场组" });


            //dt.Rows.Add(new object[] { 34, 19, "生产管理室" });
            //dt.Rows.Add(new object[] { 35, 19, "检测室" });
            //dt.Rows.Add(new object[] { 36, 19, "机加工车间" });
            //dt.Rows.Add(new object[] { 37, 19, "装配车间" });


            //dt.Rows.Add(new object[] { 38, 21, "办公室" });
            //dt.Rows.Add(new object[] { 39, 21, "档案室" });
            //dt.Rows.Add(new object[] { 40, 21, "资材室" });

            //dt.Rows.Add(new object[] { 41,32, "数控工序" });
            //dt.Rows.Add(new object[] { 42, 32, "加工中心工序" });
            //dt.Rows.Add(new object[] { 43, 32, "钳工电火花工序" });
            //dt.Rows.Add(new object[] { 44, 32, "普车工序" });


            //dt.Rows.Add(new object[] { 45, 36, "普通设备工序" });
            //dt.Rows.Add(new object[] { 46, 36, "数控工序" });
            //dt.Rows.Add(new object[] { 47, 36, "钣焊工序工序" });



            //dt.Rows.Add(new object[] { 48, 37, "装配工序" });
            //dt.Rows.Add(new object[] { 49, 37, "接线工序" });
            //dt.Rows.Add(new object[] { 50, 37, "钣焊工序" });

            
            this.bindingSource1.DataSource = dt;
            this.bindingSource1.DataMember = dt.TableName;

            this.ctrlOrgChar1.DataSource = dt;
            this.ctrlOrgChar1.KeyFileName = "id";
            this.ctrlOrgChar1.ParentKeyFileName = "pid";
            this.ctrlOrgChar1.RootParentKeyValue = 0;
            this.ctrlOrgChar1.ShowChar();
        }        
    }    
}
