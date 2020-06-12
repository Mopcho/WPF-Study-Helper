using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyHelper
{
   public static class  Startup
    {
        public static void Start()
        {
            Window2 win2 = new Window2();
            MainWindow main = new MainWindow();
            WindowHelper winHelp = new WindowHelper(main,win2);
            winHelp.TransferToMain();
        }
    }
}
