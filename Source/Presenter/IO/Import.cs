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
        public void Import()
        {
            var fileName = view.GetFileName();

            if (fileName == "")
            {
                return;
            }

            var sr = new StreamReader(fileName);

            var nums = new List<double>();

            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine().Split(' ');

                foreach(var l in line)
                {
                    if (l == " " || l == "")
                    {
                        continue;
                    }

                    var num = 0d;

                    if (!double.TryParse(l, out num))
                    {
                        sr.Close();

                        view.ShowMessage("Ошибка в переданных числах.");

                        return;
                    }

                    nums.Add(num);
                }
            }

            sr.Close();

            model.ClearHistory();
            
            var numsList = new NumsList(nums);

            model.SetCurrentNums(numsList);

            view.Print();
        }
    }
}
