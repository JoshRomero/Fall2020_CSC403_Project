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
        public static int level;
        private static bool exit;
        public static Fall2020_CSC403_Project.code.Bag bag;
        public static int persistent_health { get; private set; }
        public static bool traded { get; set; }
        public static bool swap_weapons;
        public static int experiance;
        public static int strength  { get; set; }
        public static int PN_CurrentLevel { get; set; }

/// <summary>
/// The main entry point for the application.
/// </summary>
[STAThread]
    static void Main() {
      strength = 2;
      PN_CurrentLevel = 1;
      experiance = 0;
      swap_weapons = false;
      traded = false;
      persistent_health = 20;
      bag = new code.Bag();
      last_level = 1;
      last_level2 = 1;
      level = 1;
      exit = false;
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      while (!exit)
            {
                
                switch (level)
                {
                    case 0:
                        Application.Run(new FrmLevel_0());
                        if (last_level2 == level)
                        {
                            exit = true;
                        }
                        else
                        {
                            last_level2 = level;
                        }
                        break;
                    case 1:
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
                    case 3:
                        Application.Run(new FrmLevel_3());
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
            persistent_health = new_health;
        }

        public static void alterExperiance(int XP)
        {
            experiance += XP;
        }

        public static int GetExperiance()
        {
            return experiance;
        }

        public static void reset_XP()
        {
            experiance = 0;
        }
    }
}
