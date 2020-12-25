using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator.Source
{
    partial class UserView
    {
        Timer timer = new Timer();

        private void StatusBar()
        {
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += UpdateStatusBar;
            timer.Enabled = true;
        }

        private void UpdateStatusBar(object sender, EventArgs e)
        {
            var operCount = presenter.GetOperCount();
            var currentId = presenter.GetIndex();
            var allCount = presenter.GetHistory().Count - 1;

            form.StatusBar.Text = $"Всего операций: {operCount}.Операция {currentId}/{allCount}.";
        }
    }
}
