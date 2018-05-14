using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ICPDemo
{
    public partial class frmVrcAgent : Form
    {

        public frmVrcAgent()
        {
            InitializeComponent();
        }

        public string VRPList
        {
            get
            {
                return this.textBox1.Text;
            }

            set
            {
                this.textBox1.Text = value;
            }
        }

        public string AgentID
        {
            get
            {
                return this.textBox2.Text;
            }

            set
            {
                this.textBox2.Text = value;
            }
        }

        public string SelfIP
        {
            get
            {
                return this.textBox3.Text;
            }

            set
            {
                this.textBox3.Text = value;
            }
        }
        public int SelfPort
        {
            get
            {
                Int32 tmp = 0;
                if (int.TryParse(this.textBox4.Text, out tmp))
                {
                    return tmp;
                }
                return 0;
            }
        }
    
        private void frmVrcAgent_Load(object sender, EventArgs e)
        {
            this.label1.Text = ConfigHelper.GetString("VRPList");
            this.label2.Text = ConfigHelper.GetString("VRC_AgentID");
            this.label4.Text = ConfigHelper.GetString("VRC_SelfIP");
            this.label3.Text = ConfigHelper.GetString("VRC_SelfPort");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}

