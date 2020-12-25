using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Calculator.Source
{
    partial class UserView
    {
        public void Print()
        {
            form.Answer.Items.Clear();

            var history = presenter.GetHistory();

            foreach(var h in history)
            {
                form.Answer.Items.Add(h.ToString());
            }

            form.Answer.TopIndex = presenter.GetIndex();
        }
    }
}
