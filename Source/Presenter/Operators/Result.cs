using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Source
{
    partial class Presenter
    {
        public void Result()
        {
            var inputNum = view.GetNum();
            inputNum = inputNum == "-" ? "0" : inputNum;

            var num = double.Parse(inputNum);
            var oper = view.GetOperation();

            if (oper == "")
            {
                return;
            }

            Count(num, oper);

            view.ClearInput();
            view.Print();

            model.IncOperCount();
        }

        private void Result(double num, string oper)
        {
            Count(num, oper);

            view.ClearInput();

            view.Print();

            model.IncOperCount();
        }

        public void Count(double num, string oper)
        {
            if (oper == "")
            {
                return;
            }

            var currentNums = model.GetCurrentNums();
            if (currentNums == null)
            {
                return;
            }

            var nums = model.GetCurrentNums().Nums;

            var answer = new List<double>();

            if (oper == "M")
            {
                Median();

                view.ClearInput();

                return;
            }

       

            if (oper == "S")
            {
                StandartDeviation();

                view.ClearInput();

                return;
            }

            foreach (var n in nums)
            {
                if (double.IsNaN(n))
                {
                    view.ShowMessage("Один из операндов не число. Отмена действий.");

                    return;
                }

                if (double.IsInfinity(n))
                {
                    view.ShowMessage("Один из операндов бессконечностью. Отмена действий.");

                    return;
                }

                var result = 0d;
                switch (oper)
                {
                    case "^2":
                        result = Math.Pow(n, 2);
                        break;
                    case "sqrt":
                        result = Math.Sqrt(n);
                        break;
                    case "+":
                        result = n + num;
                        break;
                    case "-":
                        result = n - num;
                        break;
                    case "*":
                        result = n * num;
                        break;
                    case "/":
                        result = n / num;
                        break;
                    case "√":
                        result = Math.Pow(n, 1 / num);
                        break;
                    case "^":
                        result = Math.Pow(n, num);
                        break;
                    case "log":
                        result = Math.Log(n, num);
                        break;
                    case "!":
                        result = Factorial(n);
                        break;
                    default:
                        view.ShowMessage("Неизвестная операция. Отмена действий.");
                        break;
                }

                if (double.IsNaN(result))
                {
                    view.ShowMessage("Один из операндов стал не числом. Отмена действий.");

                    return;
                }

                if (double.IsInfinity(result))
                {
                    view.ShowMessage("Один из операндов стал бессконечностью. Отмена действий.");

                    return;
                }

                answer.Add(result);
            }

            model.AddCurrentNums(new NumsList(answer, num, oper));
        }

        public void Median()
        {
            var nums = model.GetCurrentNums().Nums;
            var answer = 0d;

            foreach (var n in nums)
            {
                answer += n;
            }

            answer /= nums.Count;

            var list = new List<double>();
            list.Add(answer);

            model.AddCurrentNums(new NumsList(list, 0, "M"));
        }

        public void StandartDeviation()
        {
            var nums = model.GetCurrentNums().Nums;
            if (nums.Count <= 2)
            {
                model.AddCurrentNums(new NumsList( nums, 0, "S"));
                return;
            }

            var answer = 0d;

            var avg = 0d;

            foreach (var n in nums)
            {
                avg += n;
            }

            avg /= nums.Count;

            for (var i = 0; i < nums.Count; i++)
            {
                answer += (nums[i] - avg) * (nums[i] - avg);
            }

            answer /= (nums.Count - 1);
            answer = Math.Sqrt(answer);

            var list = new List<double>();
            list.Add(answer);

            model.AddCurrentNums(new NumsList(list, 0, "S"));
        }

        public double Factorial(double n)
        {
            if (n < 0)
            {
                return n;
            }

            var intNum = Math.Truncate(n);
            var answer = 1d;

            for (var i = intNum; i > 1; i--)
            {
                answer *= i;
            }

            return answer;
        }
    }
}
