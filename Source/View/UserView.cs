using System.Windows.Forms;

namespace Calculator.Source
{
    partial class UserView
    {
        Presenter presenter;
        Calc form;

        public UserView(Calc form, Presenter presenter)
        {
            this.form = form;
            this.presenter = presenter;

            StatusBar();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void ClearInput()
        {
            form.Input.Text = "0";
            form.Operation.Text = "";
        }

        public void SetInput(double num, string oper)
        {
            form.Operation.Text = oper;

            if (oper == "M" || oper == "S" || oper == "!")
            {
                form.Input.Text = "-";
                return;
            }

            form.Input.Text = num.ToString();
        }
    }
}
