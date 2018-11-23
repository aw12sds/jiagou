namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ctrlOrgChar1 = new WindowsFormsApplication2.CtrlOrgChar();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlOrgChar1
            // 
            this.ctrlOrgChar1.AutoScroll = true;
            this.ctrlOrgChar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ctrlOrgChar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlOrgChar1.DataSource = null;
            this.ctrlOrgChar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlOrgChar1.KeyFileName = null;
            this.ctrlOrgChar1.Location = new System.Drawing.Point(0, 0);
            this.ctrlOrgChar1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ctrlOrgChar1.Name = "ctrlOrgChar1";
            this.ctrlOrgChar1.ParentKeyFileName = null;
            this.ctrlOrgChar1.RootParentKeyValue = null;
            this.ctrlOrgChar1.Size = new System.Drawing.Size(1213, 624);
            this.ctrlOrgChar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 624);
            this.Controls.Add(this.ctrlOrgChar1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "组织架构图";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private CtrlOrgChar ctrlOrgChar1;
    }
}

