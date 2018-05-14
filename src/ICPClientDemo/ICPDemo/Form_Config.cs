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
    public partial class Form_Config : Form
    {
        public Form_Config()
        {
            InitializeComponent();
        }

        public string ConfigKey
        {
            get
            {
                return this.textBox_ConfigKey.Text.Trim();
            }
        }

        public string ConfigValue
        {
            get
            {
                return this.textBox_ConfigValue.Text.Trim();
            }
        }
        
        public void HideConfigValue()
        {
            this.label_ConfigValue.Visible = false;
            this.textBox_ConfigValue.Visible = false;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            this.btn_Cancel.Text = ConfigHelper.GetString("Cancel");
            this.btn_OK.Text = ConfigHelper.GetString("Ok");
            this.label_ConfigKey.Text = ConfigHelper.GetString("ConfigKey");
            this.label_ConfigValue.Text = ConfigHelper.GetString("ConfigValue");
        }
    }
}
