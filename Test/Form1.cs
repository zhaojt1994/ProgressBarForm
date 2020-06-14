using ProgressBarForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            int max = 100;
            int cur = 1;
            string des = "测试进行中......";
            //MyProgressForm form = new MyProgressForm();
            //form.MaxValue = max;
            //form.CurValue = cur;
            //form.Description = des;
            MyProgressForm form = new MyProgressForm(max,cur,des);
            form.Show();
            for (int i = 0; i < max; i++) {
                if (form.IsCancel) {
                    form.Hide();
                    break;
                }
                Thread.Sleep(30);
                form.CurValue = i + 1;
            }
            MessageBox.Show("完成");
        }
    }
}
