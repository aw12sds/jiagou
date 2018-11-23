using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Web.UI;

namespace WindowsFormsApplication2
{
    public delegate void dlgNodeClick(Node node);
    public class Node
    {

        public Node(INodeControl c)
        {
            this.ctrl = c;

           // c.ClickCallBack = new dlgNodeClick(ControlCallBack);

        }
        public int Level = 0;
        public Node ParentNode;
        public INodeControl ctrl;
        public List<Node> Childs = new List<Node>();

        public event dlgNodeClick OnNodeClick;

        public void ControlCallBack(Node node)
        {
            if (this.OnNodeClick != null)
            {
                this.OnNodeClick(this);
            }
        }
        public void AddChild(Node node)
        {
            node.ParentNode = this;
            node.Level = this.Level + 1;
            this.Childs.Add(node);
           
        }
        public int Index
        {
            get
            {
                if (this.ParentNode != null)
                {
                    return this.ParentNode.Childs.IndexOf(this);
                }
                return -1;
            }
        }
        public Node PreviousNode
        {
            get
            {
                if (this.ParentNode != null)
                {
                    if (this.Index == -1 || this.Index == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return this.ParentNode.Childs[this.Index - 1];
                    }
                }

                return null;
            }
        }
        public Node FirstChildNode
        {
            get
            {
                if (Childs.Count > 0)
                {
                    return this.Childs[0];
                }
                return null;
            }
        }
        public Node LastChildNode
        {
            get
            {
                if (Childs.Count ==0)
                {
                    return null;
                }
                else
                {
                    return this.Childs[this.Childs.Count -1];
                }
               
            }
        }

        public int X
        {
            get
            {
                return PosRec.X;
            }
            set
            {
                PosRec.X = value;
                if (this.ctrl != null)
                {
                    this.ctrl.Node_X = value;
                }
            }
        }
        public int Y
        {
            get
            {
                return PosRec.Y;
            }
            set
            {
                PosRec.Y = value;
                if (this.ctrl != null)
                {
                    this.ctrl.Node_Y = value;
                }
            }
        }
        public int Width
        {
            get
            {
                return PosRec.Width;
            }
            set
            {
                PosRec.Width = value;
                if (this.ctrl != null)
                {
                    this.ctrl.NodeWidth = value;
                }
            }
        }
        public int Heigth
        {
            get
            {
                return PosRec.Height;
            }
            set
            {
                PosRec.Height = value;
                if (this.ctrl != null)
                {
                    this.ctrl.NodeHeight = value;
                }
            }
        }
        public int Right
        {
            get
            {
                return X + Width;
            }
        }
        public int Botton
        {
            get
            {
                return Y + Heigth;
            }
        }

        private  Rectangle PosRec;
        
    }
    public class NodeConfirnHepler
    {
        public const int ROOTMAIGINS_TOP = 30;
        public const int NODEMAIGINS_RIGHT = 20;
        public const int NODEMAIGINS_LEFT = 20;

        /// <summary>
        /// 節點的垂直間距
        /// </summary>
        public const int NODE_V_DIS = 50;
        /// <summary>
        /// 節點的水平間距
        /// </summary>
        public const int NODE_H_DIS = 10;

        /// <summary>
        /// 節點寬
        /// </summary>
        public const int NODE_WIDTH = 50;
        
        /// <summary>
        /// 節點高度
        /// </summary>
        public const int NODE_HEIGHT = 70;

        

        /// <summary>
        /// 給定某個範圍，計算出每個node的位置Rectangle
        /// </summary>
        /// <param name="RootNode"></param>
        /// <param name="LeftNode_x">最左邊的節點x座標</param>
        /// <param name="LeftNode_y">最左邊的節點y座標</param>
        public void CalRootNodeControlRec(Node RootNode)
        {

            List<Level> Leves = new List<Level>();
            Level l = new Level(0);
            l.Childs.Add(RootNode);
            Leves.Add(l);
            foreach (Node n in RootNode.Childs)
            {
                AddLevel(n, Leves);
            }
 

            CalNodeRec(RootNode, Leves);
        }
        private Node LefNode;
        private Node GetLeftNode(Node node)
        {
            if (node.Childs.Count == 0)
            {
                return node;
            }
            foreach (Node n in node.Childs)
            {
                return GetLeftNode(n);
            }
            return null;
        }
        private void AddLevel(Node node, List<Level> Leves)
        {
            if (node.Level > Leves.Count - 1)
            {
                Level l = new Level(node.Level);
                l.Childs.Add(node);
                Leves.Add(l);

            }
            else
            {
                if (Leves[node.Level].Childs.IndexOf(node) < 0)
                {
                    Leves[node.Level].Childs.Add(node);
                }
            }
            foreach (Node n in node.Childs)
            {
                AddLevel(n, Leves);
            }
        }

        public int GetXByChilds(Node node)
        {
            if (node.Childs.Count > 0)
            {
                int tmp = 0;
                tmp = node.FirstChildNode.X + ((node.FirstChildNode.Right - node.FirstChildNode.X) / 2) - NODE_WIDTH/2;
                return tmp;
            }
            return -1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int GetXByParentPreviousNode(Node node)
        {
            if(node.ParentNode ==null){return -1;}
            Node pprvnode = node.ParentNode.PreviousNode;
            if (pprvnode != null)
            {
                if (pprvnode.Childs.Count > 0)
                {
                    return pprvnode.LastChildNode.Right + NODE_H_DIS;
                }
                else
                {
                    return pprvnode.Right + NODE_H_DIS;
                }
            }
            else
            {
                if (node.ParentNode != null)
                {
                    return GetXByParentPreviousNode(node.ParentNode);
                }
            }
            return -1;
        }
        /// <summary>
        /// 在同一Level中找前一個節點的
        /// 來決定 X
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int GetXByPreviousNode(Node node)
        {
            Node prvnode=node.PreviousNode;
            if(prvnode!=null)
            {
                 if (prvnode.Childs.Count > 0)
                {
                    return prvnode.LastChildNode.Right + NODE_H_DIS;
                }
                else
                {
                    return prvnode.Right + NODE_H_DIS;
                }
            }
            return -1;
        }

        public void CalNodeRec(Node node, List<Level> Leves)
        {
            foreach (Node n in node.Childs)
            {
                CalNodeRec(n, Leves);
            }
            System.Diagnostics.Debug.WriteLine((node.ctrl as System.Windows.Forms.Control).Text);

            node.Width = NODE_WIDTH;
            node.Heigth = NODE_HEIGHT;
            int[] sortArr = new int[] { GetXByPreviousNode(node),
                                        GetXByParentPreviousNode(node),
                                        GetXByChilds(node),
                                        NODEMAIGINS_RIGHT };           
            Array.Sort(sortArr);
            int N_X = sortArr[sortArr.Length - 1]; //取出最大X座標 就是node 的座標
            node.X = N_X;
            node.Y = (NODE_V_DIS + NODE_HEIGHT) * node.Level + ROOTMAIGINS_TOP;

        }
        public class Level
        {
            public Level(int l)
            {
                level = l;
            }
            public int level = 0;

            public List<Node> Childs=new List<Node>();

            public int GetNodeIndex(Node node)
            {
                for (int i = 0; i < Childs.Count; i++)
                {
                    if (Childs[i].Equals(node))
                    {
                        return i;
                    }
                }
                return -1;
            }
        }


    }
    public interface INodeControl
    {
        dlgNodeClick ClickCallBack { get; set; }
        Node Node { get; }
        int Node_X { get; set; }
        int Node_Y { get; set; }
        int NodeWidth { get; set; }
        int NodeHeight { get; set; }
    }
}
