using System.Windows.Forms;

namespace Calculator.Source
{
    partial class Presenter
    {
        public void AddNum(Button btn)
        {
            var text = btn.Text;

            view.AddNum(text);
        }
    }
}
