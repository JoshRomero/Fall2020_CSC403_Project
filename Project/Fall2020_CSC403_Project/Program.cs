using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {

    static class Program {
        public static int last_level { get; private set; }
        public static int last_level2 { get; private set; }
        private static int level;
        private static bool exit;
        public static Fall2020_CSC403_Project.code.Bag bag;
        public static int[] levels;
        public static int persistent_health { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
    static void Main() {
      levels = new int[] { 0, 0, 0, 0 };
      persistent_health = 20;
      bag = new code.Bag();
      last_level = 1;
      last_level = 1;
      level = 1;
      exit = false;
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      while (!exit)
            {
                
                switch (level)
                {
                    case 1:
                        levels[1] = levels[1] + 1;
                        Application.Run(new FrmLevel_1());
                        if (last_level2 == level)
                        {
                            exit = true;
                        }
                        else
                        {
                            last_level2 = level;
                        }
                        break;
                    case 2:
                        levels[2] = levels[2] + 1;
                        Application.Run(new FrmLevel_2());
                        if (last_level2 == level)
                        {
                            exit = true;
                        }
                        else
                        {
                            last_level2 = level;
                        }
                        break;
                    case -1:
                        exit = true;
                        break;
                }

                
            }
        }
        public static void change_level(int next_level)
        {
            last_level = level;
            level = next_level;
        }

        public static void end_game()
        {
            level = -1;
        }
        public static void updatePersistentHealth(int new_health)
        {
            Fall2020_CSC403_Project.Program.persistent_health = new_health;
        }
    }
}
