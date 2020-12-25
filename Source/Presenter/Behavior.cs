using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Calculator.Source
{
    partial class Presenter
    {
        public void Undo()
        {
            model.Undo();

            var current = model.GetCurrentNums();

            view.SetInput(current.Num, current.Oper);

            view.Print();
        }

        public void Do()
        {
            model.Do();

            var current = model.GetCurrentNums();

            view.SetInput(current.Num, current.Oper);

            view.Print();
        }

        public void Repeat()
        {
            var previous = model.GetPreviousNums();

            if (previous == null)
            {
                return;
            }

            Result(previous.Num, previous.Oper);
        }

        public void Select(int id)
        {
            model.SetIndex(id);

            var current = model.GetCurrentNums();

            view.SetInput(current.Num, current.Oper);
            view.Print();
        }
    }
}
