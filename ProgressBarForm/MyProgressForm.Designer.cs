namespace ProgressBarForm {
    partial class MyProgressForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_cancle = new System.Windows.Forms.Button();
            this.tx_maxnum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_curnum = new System.Windows.Forms.Label();
            this.tx_des = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_cancle);
            this.panel1.Controls.Add(this.tx_maxnum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tx_curnum);
            this.panel1.Controls.Add(this.tx_des);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 131);
            this.panel1.TabIndex = 0;
            // 
            // bt_cancle
            // 
            this.bt_cancle.Location = new System.Drawing.Point(403, 95);
            this.bt_cancle.Name = "bt_cancle";
            this.bt_cancle.Size = new System.Drawing.Size(75, 23);
            this.bt_cancle.TabIndex = 2;
            this.bt_cancle.Text = "取消";
            this.bt_cancle.UseVisualStyleBackColor = true;
            this.bt_cancle.Click += new System.EventHandler(this.bt_cancle_Click);
            // 
            // tx_maxnum
            // 
            this.tx_maxnum.AutoSize = true;
            this.tx_maxnum.Location = new System.Drawing.Point(447, 66);
            this.tx_maxnum.Name = "tx_maxnum";
            this.tx_maxnum.Size = new System.Drawing.Size(15, 15);
            this.tx_maxnum.TabIndex = 1;
            this.tx_maxnum.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "/";
            // 
            // tx_curnum
            // 
            this.tx_curnum.AutoSize = true;
            this.tx_curnum.Location = new System.Drawing.Point(327, 66);
            this.tx_curnum.Name = "tx_curnum";
            this.tx_curnum.Size = new System.Drawing.Size(15, 15);
            this.tx_curnum.TabIndex = 1;
            this.tx_curnum.Text = "1";
            this.tx_curnum.TextChanged += new System.EventHandler(this.tx_curnum_TextChanged);
            // 
            // tx_des
            // 
            this.tx_des.AutoSize = true;
            this.tx_des.Location = new System.Drawing.Point(37, 66);
            this.tx_des.Name = "tx_des";
            this.tx_des.Size = new System.Drawing.Size(115, 15);
            this.tx_des.TabIndex = 1;
            this.tx_des.Text = "正在处理......";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(40, 21);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(438, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // MyProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(516, 131);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MyProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_cancle;
        private System.Windows.Forms.Label tx_maxnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tx_curnum;
        private System.Windows.Forms.Label tx_des;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

