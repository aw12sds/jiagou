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

            CopyNodes();
            TreeNodeHelper.CalRootNodeControlRec(TNodes[0]);

        }

        public void CopyNodes()
        {
            DataRow[] drs = dt.Select(string.Format("pid={0}", 0));

            NodeButton b = new NodeButton(50, 20);
            Node rootn = new Node(b);
            b.Text = drs[0]["id"].ToString();
            b._Node = rootn;

            TNodes.Add(rootn);

            this.xtraScrollableControl1.Controls.Add(b);
            CopyNodes(drs[0], rootn);

        }
        public void CopyNodes(DataRow r,Node pn)
        {
            DataRow[] drs = dt.Select(string.Format("pid={0}", r["id"]));
            foreach (DataRow d in drs)
            {
                NodeButton b = new NodeButton(50, 20);               
                Node n = new Node(b);
                b.Text = d["id"].ToString();
                b._Node =n;
                pn.AddChild(n);
                this.xtraScrollableControl1.Controls.Add(b);
                CopyNodes(d, n);
            }
        }
        public List<Node> TNodes=new List<Node>();
        public NodeConfirnHepler TreeNodeHelper = new NodeConfirnHepler();
        DataTable dt;
        private void Form1_Load(object sender, EventArgs e)
        {
            dt=new DataTable();
            dt.Columns.Add(new DataColumn("id",typeof(int)));
            dt.Columns.Add(new DataColumn("pid", typeof(int)));
            dt.Columns.Add(new DataColumn("name", typeof(string)));
            dt.Rows.Add(new object[] { 1, 0, "1" });
            dt.Rows.Add(new object[] { 2, 1, "2" });
            dt.Rows.Add(new object[] { 3, 1, "3" });
            dt.Rows.Add(new object[] { 4, 2, "4" });
            dt.Rows.Add(new object[] { 5, 2, "5" });
            dt.Rows.Add(new object[] { 6, 3, "6" });
            dt.Rows.Add(new object[] { 7, 3, "7" });

            this.bindingSource1.DataSource = dt;
            this.bindingSource1.DataMember = dt.TableName;

        }
    }


    public class NodeButton:Button,INodeControl
    {

        public NodeButton(int w,int h)
        {
            this.Width = w;
            this.Height = h;
 

        }
        public  Node _Node;
        #region INodeControl 成員

        public dlgNodeClick ClickCallBack
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Node Node
        {
            get { return _Node; }
        }

        public int NodeWidth
        {
            get { return this.Width; }
            set { this.Width = value; }
        }

        public int NodeHeight
        {
            get { return this.Height; }
            set { this.Height = value; }
        }

 


        public int Node_X
        {
            get { return this.Left; }
            set { this.Left = value; }
        }

        public int Node_Y
        {
            get { return this.Top; }
            set { this.Top = value; }
        }

        #endregion
    }
}
