using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NsisSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "축하드립니다!\n프로그램이 정상 실행되었습니다.";
            foreach (string str in Environment.GetCommandLineArgs())
                listBox1.Items.Add(str);
        }
    }
}
