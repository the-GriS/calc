using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Source
{
    partial class UserView
    {
        public string GetNum()
        {
            return form.Input.Text;
        }

        public string GetOperation()
        {
            return form.Operation.Text;
        }
    }
}
