using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
    
  static class Program {
        private static int level;
        private static bool run;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
    static void Main() {
      level = 1;
      run = true;
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      while (run)
            {
                switch (level)
                {
                    case 1:
                        Application.Run(new FrmLevel_1());
                        break;
                    case 2:
                        Application.Run(new FrmLevel_2());
                        break;
                    case -1:
                        run = false;
                        break;
                }

                
            }
        }
        public static void change_level(int next_level)
        {
            level = next_level;
        }
        public static void end_game()
        {
            level = -1;
        }
  }
}
