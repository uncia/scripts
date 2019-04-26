namespace Zabbix
{
    partial class frmMian
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lvList = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdRead = new System.Windows.Forms.OpenFileDialog();
            this.lvOut = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labText = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvList
            // 
            this.lvList.Location = new System.Drawing.Point(12, 25);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(178, 274);
            this.lvList.TabIndex = 1;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIn,
            this.tsmiStart,
            this.tsmiOut,
            this.tsmiAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiIn
            // 
            this.tsmiIn.Name = "tsmiIn";
            this.tsmiIn.Size = new System.Drawing.Size(44, 21);
            this.tsmiIn.Text = "导入";
            this.tsmiIn.Click += new System.EventHandler(this.tsmiIn_Click);
            // 
            // tsmiStart
            // 
            this.tsmiStart.Enabled = false;
            this.tsmiStart.Name = "tsmiStart";
            this.tsmiStart.Size = new System.Drawing.Size(44, 21);
            this.tsmiStart.Text = "开始";
            this.tsmiStart.Click += new System.EventHandler(this.tsmiStart_Click);
            // 
            // tsmiOut
            // 
            this.tsmiOut.Enabled = false;
            this.tsmiOut.Name = "tsmiOut";
            this.tsmiOut.Size = new System.Drawing.Size(44, 21);
            this.tsmiOut.Text = "导出";
            this.tsmiOut.Click += new System.EventHandler(this.tsmiOut_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(44, 21);
            this.tsmiAbout.Text = "关于";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // lvOut
            // 
            this.lvOut.Location = new System.Drawing.Point(209, 25);
            this.lvOut.Name = "lvOut";
            this.lvOut.Size = new System.Drawing.Size(377, 274);
            this.lvOut.TabIndex = 3;
            this.lvOut.UseCompatibleStateImageBehavior = false;
            this.lvOut.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "本工具，适用于安全测试。造成的法律责任，本人一概不负。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "已完成:";
            // 
            // labText
            // 
            this.labText.AutoSize = true;
            this.labText.Location = new System.Drawing.Point(66, 323);
            this.labText.Name = "labText";
            this.labText.Size = new System.Drawing.Size(41, 12);
            this.labText.TabIndex = 6;
            this.labText.Text = "label3";
            // 
            // frmMian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(614, 355);
            this.Controls.Add(this.labText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvOut);
            this.Controls.Add(this.lvList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(630, 394);
            this.MinimumSize = new System.Drawing.Size(630, 394);
            this.Name = "frmMian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zabbix批量检查【i春秋社区】--0nise\'s Blog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMian_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.OpenFileDialog ofdRead;
        private System.Windows.Forms.ListView lvOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labText;
    }
}

