using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Source
{
    partial class Presenter
    {
        Model model;
        UserView view;

        public Presenter(Calc form)
        {
            model = new Model();
            view = new UserView(form, this);
        }

        public List<NumsList> GetHistory()
        {
            return model.GetHistory();
        }

        public int GetIndex()
        {
            return model.GetIndex();
        }

        public int GetOperCount()
        {
            return model.GetOperCount();
        }

    }
}
