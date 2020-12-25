using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Source
{
    class DataBase
    {
        public NumsList CurrentNums { get; set; }
        public List<NumsList> History { get; }
        public int OperCount { get; set; } = 0;

        public int Index { get; set; } = 0;

        public DataBase()
        {
            CurrentNums = new NumsList();
            History = new List<NumsList>();
        }
    }
}
