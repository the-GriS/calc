using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Source
{
    partial class Model
    {
        public int GetOperCount()
        {
            return db.OperCount;
        }

        public void IncOperCount()
        {
            db.OperCount++;
        }

        public void ClearHistory()
        {
            db.History.Clear();
            db.Index = 0;
        }

        public void SetIndex(int id)
        {
            GetCurrentNums().IsSelected = false;

            db.Index = id;

            GetCurrentNums().IsSelected = true;
        }

        public int GetIndex()
        {
            return db.Index;
        }

        public void SetCurrentNums(NumsList numsList)
        {
            numsList.IsSelected = true;
            db.CurrentNums = numsList;
            db.History.Add(numsList);
        }

        public NumsList GetCurrentNums()
        {
            if (db.History.Count == 0)
            {
                return null;
            }

            return db.History[db.Index];
        }

        public NumsList GetPreviousNums()
        {
            if (db.Index == 0)
            {
                return null;
            }

            return db.History[db.Index - 1];
        }

        public void AddCurrentNums(NumsList numsList)
        {
            db.History.RemoveRange(db.Index + 1, db.History.Count - (db.Index + 1));

            db.History[db.History.Count - 1].Num = numsList.Num;
            db.History[db.History.Count - 1].Oper = numsList.Oper;

            numsList.Num = 0;
            numsList.Oper = "";

            db.History.Add(numsList);

            db.CurrentNums = numsList;

            Do();
        }

        public void Undo()
        {
            db.History[db.Index].IsSelected = false;

            db.Index--;

            if (db.Index < 0)
            {
                db.Index = 0;
            }

            db.History[db.Index].IsSelected = true;
        }

        public void Do()
        {
            db.History[db.Index].IsSelected = false;

            db.Index++;

            if (db.Index >= db.History.Count)
            {
                db.Index--;
            }

            db.History[db.Index].IsSelected = true;
        }

        public List<NumsList> GetHistory()
        {
            return db.History;
        }
    }
}
