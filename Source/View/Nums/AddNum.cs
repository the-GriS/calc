using System.Windows.Forms;

namespace Calculator.Source
{
    partial class UserView
    {
        public void AddNum(string num)
        {
            if (form.Input.Text == "-")
            {
                return;
            }

            if (num == ",")
            {
                if (form.Input.Text.Contains(","))
                {
                    return;
                }

                if (form.Input.Text[0] == '0')
                {
                    form.Input.Text += num;

                    return;
                }
            }

            if (num == "+/-")
            {
                if (form.Input.Text[0] == '0')
                {
                    return;
                }

                if (form.Input.Text[0] == '-')
                {
                    form.Input.Text = form.Input.Text.Substring(1, form.Input.Text.Length - 1);
                }
                else {
                    form.Input.Text = form.Input.Text.Insert(0, "-");
                }

                return;
            }

            if (form.Input.Text.Length == 1)
            {
                if (form.Input.Text[0] == '0')
                {
                    form.Input.Text = num;

                    return;
                }
            }

            form.Input.Text += num;
        }
    }
}
