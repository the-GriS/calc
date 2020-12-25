using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Calculator.Source
{
    partial class UserView
    {
        public string GetFileName()
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Text files(*.txt)| *.txt*";
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return "";

            return openFile.FileName;
        }
    }
}
