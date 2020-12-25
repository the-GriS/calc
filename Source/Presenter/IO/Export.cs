using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calculator.Source
{
    partial class Presenter
    {
        public void Export()
        {
            var fileName = view.GetFileName();

            var current = model.GetCurrentNums();

            File.WriteAllText(fileName, current.ExportToString());

            view.ShowMessage("Экспортировано.");
        }
    }
}
