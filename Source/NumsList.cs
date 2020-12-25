using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Source
{
    class NumsList
    {
        public bool IsSelected { get; set; } = false;
        public double Num { get; set; } = 0d;
        public string Oper { get; set; } = "";

        public List<double> Nums { get; }

        public NumsList()
        {
            Nums = new List<double>();
        }

        public NumsList(List<double> nums)
        {
            Nums = nums;
        }

        public NumsList(List<double> nums, double num, string oper)
        {
            Nums = nums;
            Num = num;
            Oper = oper;
        }

        public string ExportToString()
        {
            if (Nums.Count == 0)
            {
                return "";
            }

            var result = $"{Nums[0].ToString()}";

            for (var i = 1; i < Nums.Count; i++)
            {
                result += $" {Nums[i].ToString()}";
            }

            return result;
        }

        public override string ToString()
        {
            if (Nums.Count == 0)
            {
                return "{ }";
            }

            var result = $"{{ {Nums[0].ToString()}";

            for (var i = 1; i < Nums.Count; i++)
            {
                result += $"; {Nums[i].ToString()}";
            }

            result += " }";

            if (IsSelected)
            {
                result += " <===";
            }

            return result;
        }
    }
}
