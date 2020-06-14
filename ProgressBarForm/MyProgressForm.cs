using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarForm {
    public partial class MyProgressForm : Form {
        private bool _isCancel;

        public MyProgressForm() {
            InitializeComponent();
        }
        public MyProgressForm(int maxValue, int curValue, string description) {
            InitializeComponent();
            this.MaxValue = maxValue;
            this.CurValue = CurValue;
            this.Description = description;
        }
        /// <summary>
        /// 最大值
        /// </summary>
        public int MaxValue {
            get {
                return int.Parse(this.tx_maxnum.Text);
            }
            set {
                this.tx_maxnum.Text = value.ToString();
            }
        }
        /// <summary>
        /// 当前值
        /// </summary>
        public int CurValue {
            get {
                return int.Parse(this.tx_curnum.Text);
            }
            set {
                //跨线程修改属性值
                if (this.InvokeRequired) {
                    Action a = () => { this.tx_curnum.Text = value.ToString(); };
                    //防止窗体关闭后再修改参数值时报错
                    try {
                        this.Invoke(a);
                    }
                    catch (Exception) {
                    }
                    
                }
                else {
                    this.tx_curnum.Text = value.ToString();
                }

            }
        }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description {
            get {
                return this.tx_des.Text;
            }
            set {
                this.tx_des.Text = value;
            }
        }
        /// <summary>
        /// 取消
        /// </summary>
        public bool IsCancel { get => _isCancel; set => _isCancel = value; }

        private void Form1_Load(object sender, EventArgs e) {

        }
        
        /// <summary>
        /// 新线程拉起进度条窗体，防止界面UI显示不全
        /// </summary>
        public new void Show() {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (object sender, DoWorkEventArgs e) => { base.ShowDialog(); };
            worker.RunWorkerAsync();
        }
        /// <summary>
        /// 当前进度改变，完成时自动关闭窗体
        /// </summary>
        private void curValueChange() {
            if (CurValue == MaxValue) {
                this.Hide();
                return;
            }
            this.progressBar1.Value = (int)((this.CurValue * 1.0 / this.MaxValue) * 100);
        }
        /// <summary>
        /// 当前值修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tx_curnum_TextChanged(object sender, EventArgs e) {
            //跨线程修改属性值
            if (this.InvokeRequired) {
                Action a = curValueChange;
                this.Invoke(a);
            }
            else {
                curValueChange();
            }
        }
        /// <summary>
        /// 取消操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_cancle_Click(object sender, EventArgs e) {
            this._isCancel = true;
        }
        /// <summary>
        /// 隐藏界面
        /// </summary>
        public new void Hide() {
            if (this.InvokeRequired) {
                Action a = () => { base.Close(); };
                this.Invoke(a);
            }
            else {
                base.Hide();
            }
        }
        
    }
}
