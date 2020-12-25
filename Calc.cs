using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Calculator.Source;

namespace Calculator
{
    public partial class Calc : Form
    {
        Presenter presenter;
        public Calc()
        {
            InitializeComponent();

            presenter = new Presenter(this);

            Answer.DoubleClick += Answer_DoubleClick;
        }

        private void Import_Click(object sender, EventArgs e)
        {
            presenter.Import();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            presenter.Export();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            presenter.Print();
        }

        private void One_Click(object sender, EventArgs e)
        {
            presenter.AddNum(sender as Button);
        }

        private void Two_Click(object sender, EventArgs e)
        {
            presenter.AddNum(sender as Button);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            presenter.AddNum(sender as Button);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            presenter.AddNum(sender as Button);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            presenter.AddNum(sender as Button);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            presenter.AddNum(sender as Button);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            presenter.AddNum(sender as Button);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            presenter.AddNum(sender as Button);
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            presenter.AddNum(sender as Button);
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            presenter.AddNum(sender as Button);
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            presenter.AddNum(sender as Button);
        }

        private void Swap_Click(object sender, EventArgs e)
        {
            presenter.AddNum(sender as Button);
        }

        private void Log_Click(object sender, EventArgs e)
        {
            presenter.AddOperator(sender as Button);
        }

        private void Mid_Click(object sender, EventArgs e)
        {
            presenter.AddOperator(sender as Button);
        }

        private void Stand_Click(object sender, EventArgs e)
        {
            presenter.AddOperator(sender as Button);
        }

        private void Div_Click(object sender, EventArgs e)
        {
            presenter.AddOperator(sender as Button);
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            presenter.AddOperator(sender as Button);
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            presenter.AddOperator(sender as Button);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            presenter.AddOperator(sender as Button);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            presenter.AddOperator(sender as Button);
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            presenter.AddOperator(sender as Button);
        }

        private void Pow_Click(object sender, EventArgs e)
        {
            presenter.AddOperator(sender as Button);
        }

        private void Fac_Click(object sender, EventArgs e)
        {
            presenter.AddOperator(sender as Button);
        }

        private void Res_Click(object sender, EventArgs e)
        {
            presenter.Result();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            presenter.Undo();
        }

        private void DoBtn_Click(object sender, EventArgs e)
        {
            presenter.Do();
        }

        private void Repeat_Click(object sender, EventArgs e)
        {
            presenter.Repeat();
        }

        private void Answer_DoubleClick(object sender, EventArgs e)
        {
            presenter.Select(Answer.IndexFromPoint((e as MouseEventArgs).Location));
        }

        private void ImportAction_Click(object sender, EventArgs e)
        {
            presenter.ImportAction();
        }
    }
}
