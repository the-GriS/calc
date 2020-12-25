using System.Windows.Forms;

namespace Calculator.Source
{
    partial class UserView
    {
        public void AddOperator(string oper)
        {
            if (form.Input.Text == "-")
            {
                form.Input.Text = "0";
            }

            if (oper == "C")
            {
                form.Input.Text = "0";
                form.Operation.Text = "";

                return;
            }

            if (oper == "M" || oper == "S" || oper == "!")
            {
                form.Input.Text = "-";
            }

            form.Operation.Text = oper;
        }
    }
}
