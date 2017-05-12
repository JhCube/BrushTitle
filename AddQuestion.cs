using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrushTitle
{
    public partial class AddQuestion : Form
    {

        Format f;
        string txt = "";
        int type = 0;
        bool isDrop = false;

        int sence = 0;

        public AddQuestion()
        {
            InitializeComponent();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            refresh();
            f = new Format(txt,type,isDrop);
            this.txtShow.Text = f.Text;
            switchover(1);
            this.lblMsg.Text = "题数："+f.TiShu+"  请检查是否有误！";
        }

        //刷新
        private void refresh() {
            txt = this.txtShow.Text;

            if (rbtn1.Checked) type = 0;
            else if (rbtn2.Checked) type = 1;
            else if (rbtn3.Checked) type = 2;

            if (rbtnF.Checked) isDrop = false;
            else if (rbtnT.Checked) isDrop = true;

        }

        private void switchover(int a) {
            if (a == 0) {
                this.gboxName.Visible = false;
                this.gboxType.Visible = true;
                this.gboxIsDrop.Visible = true;
                this.txtShow.ReadOnly = false;
                this.btnFormat.Visible = true;
                this.btnBack.Visible = false;
                this.btnSave.Visible = false;

                this.txtShow.Text = txt;
            }
            else if (a == 1)
            {
                this.gboxName.Visible = true;
                this.gboxType.Visible = false;
                this.gboxIsDrop.Visible = false;
                this.txtShow.ReadOnly = true;
                this.btnFormat.Visible = false;
                this.btnBack.Visible = true;
                this.btnSave.Visible = true;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            switchover(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
