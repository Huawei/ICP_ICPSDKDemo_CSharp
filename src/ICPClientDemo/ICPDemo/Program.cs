﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;

namespace ICPDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new frmMain());
            }
            catch
            {
            }
          
        }
    }
}