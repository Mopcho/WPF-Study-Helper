using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyHelper
{
    public class WindowHelper
    {
        private MainWindow main;

        private Window2 win2;

        public WindowHelper(MainWindow main, Window2 win2)
        {
            this.main = main;
            this.win2 = win2;
        }

        public void TransferToMain()
        {
            main.objList = win2.objList;
        }
    }
}
