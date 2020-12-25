using System.Windows.Forms;

namespace Calculator.Source
{
    partial class Presenter
    {
        public void AddOperator(Button btn)
        {
            var text = btn.Text;

            view.AddOperator(text);
        }
    }
}
