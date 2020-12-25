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
        public void ImportAction()
        {
            var fileName = view.GetFileName();

            var sr = new StreamReader(fileName);

            while (!sr.EndOfStream)
            {
                double num;

                var command = sr.ReadLine().Split(' ');
                command[1] = command[1] == "-" ? "0" : command[1];

                if (!double.TryParse(command[1], out num)) 
                {
                    view.ShowMessage("Некорректные данные!");
                    return;
                }

                Result(num, command[0]);
            }

            sr.Close();
        }
    }
}
