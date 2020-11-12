using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmBattle : Form
    {
        public static FrmBattle instance = null;
        private Enemy enemy;
        private Player player;

        /// <summary>
        /// Creates the initial screen for battle 
        /// </summary>
        /// <param name="current_weapon"></param> changes the attack button depending on the type of weapon in bag
        private FrmBattle(string current_weapon)
        {
            if (current_weapon == "big knife")
            {
                InitializeComponent1();
            }
            else if (current_weapon == "long bow")
            {
                InitializeComponent2();
            }
            else
            {
                InitializeComponent();
            }
            player = Game.player;
            UpdatePotionsCount();

        }

        /// <summary>
        /// sets the appropriate enemy that player is fighting
        /// </summary>
        public void Setup()
        {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;

            UpdateXPBars();
            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
            player.AttackEvent += EnemyDamage;

            // show health
            UpdateHealthBars();
        }

        /// <summary>
        /// set the special features for final battle
        /// </summary>
        public void SetupForBossBattle()
        {
            picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;


            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();

            tmrFinalBattle.Enabled = true;
        }

        /// <summary>
        /// creates and return the intance with the specific enemy
        /// </summary>
        /// <returns></returns>
        public static FrmBattle GetInstance(Enemy enemy, string current_weapon = null)
        {
            if (instance == null)
            {
                instance = new FrmBattle(current_weapon);
                instance.enemy = enemy;
                instance.Setup();
            }
            return instance;
        }

        /// <summary>
        /// updates the potion count on the battle screen during battle
        /// </summary>
        private void UpdatePotionsCount()
        {
            num_potions.Text = ("X " + Program.bag.num_potions().ToString());
        }

        /// <summary>
        /// updates the health bars during battle
        /// </summary>
        private void UpdateHealthBars()
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString();
            lblEnemyHealthFull.Text = enemy.Health.ToString();
        }

        private void UpdateXPBars()
        {
            int MaxXP = (Program.PN_CurrentLevel * 10);

            float playerXP_Per = Program.GetExperiance() / (float)MaxXP;

            const int MAX_XPBAR_WIDTH = 226;
            XPamount.Width = (int)(MAX_XPBAR_WIDTH * playerXP_Per);

            XPamount.Text = Program.GetExperiance().ToString();
            PN_Current_Level.Text = Program.PN_CurrentLevel.ToString();
            if (Program.GetExperiance() >= Program.PN_CurrentLevel * 10)
            {
                Program.updatePersistentHealth(player.MaxHealth);
                if ( Program.PN_CurrentLevel <= 3)
                {
                    Program.reset_XP();
                    Program.PN_CurrentLevel += 1;
                    Program.strength += 1;
                }
                else
                {
                    Program.experiance = Program.PN_CurrentLevel * 10;
                }
           
            }
        }


        /// <summary>
        /// applies the damage to the enemy and player when the attack button is pressed
        /// </summary>
        private void btnAttack_Click(object sender, EventArgs e)
        {
            player.OnAttack(-3, Program.strength);
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2, Program.strength);
            }
            UpdateHealthBars();
            if (player.Health <= 0 || enemy.Health <= 0)
            {
                if (enemy.Health <= 0)
                {
                    enemy.death();
                    Program.alterExperiance(5);
                    UpdateXPBars();
                }
                else
                {
                    player.death();
                    Death();
                }
                instance = null;
                Close();
            }
        }
        /// <summary>
        /// increases the health of the player when the potion button is pressed
        /// </summary>
        private void btnpotion_Click(object sender, EventArgs e)
        {
            if ((Program.bag.get_bag_size() > 0) && (Program.bag.num_potions() > 0) && (player.Health != player.MaxHealth))
            {
                Program.bag.use_item("Healing potion");
                player.AlterHealth(5, "heal");
                UpdateHealthBars();
                Program.updatePersistentHealth(player.Health);
                UpdatePotionsCount();

            }
        }

        /// <summary>
        /// modifies the enemy's health
        /// </summary>
        /// <param name="amount"></param> how much the enemy health will be changed
        private void EnemyDamage(int amount)
        {
            enemy.AlterHealth(amount);
        }

        /// <summary>
        /// modifies the player's health 
        /// </summary>
        /// <param name="amount"></param> how much the players health will be changed
        private void PlayerDamage(int amount)
        {
            player.AlterHealth(amount);
            Program.updatePersistentHealth(player.Health);
        }

        private void tmrFinalBattle_Tick(object sender, EventArgs e)
        {
            picBossBattle.Visible = false;
            tmrFinalBattle.Enabled = false;
        }


        /// <summary>
        /// applies the damage to the enemy and player when the stab button is pressed
        /// </summary>
        private void Stab_Click(object sender, EventArgs e)
        {
            player.OnAttack(-7, Program.strength);
            
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2, Program.strength);
            }

            UpdateHealthBars();

            if (player.Health <= 0 || enemy.Health <= 0)
            {
                if (enemy.Health <= 0)
                {
                    enemy.death();
                    Program.alterExperiance(5);
                    UpdateXPBars();
                }
                else
                {
                    player.death();
                    Death();
                }
                instance = null;
                Close();
            }

        }

        /// <summary>
        /// applies the damage to the enemy and player when the attack button is pressed
        /// </summary>
        private void Shoot_Click(object sender, EventArgs e)
        {           
            player.OnAttack(-10, Program.strength);

            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2, Program.strength);
            }

            UpdateHealthBars();
            if (player.Health <= 0 || enemy.Health <= 0)
            {
                if (enemy.Health <= 0)
                {
                    enemy.death();
                    Program.alterExperiance(enemy.MaxHealth/4);
                    UpdateXPBars();
                }
                else
                {
                    player.death();
                    Death();
                }
                instance = null;
                Close();
            }
        }

        private static void Death()
        {
            death Death = new death();
            Death.Show();
        }

        /// <summary>
        /// this disables the cancel button on the top right of the screen
        /// </summary>
        private void Form1_Closing(Object sender, CancelEventArgs e)
        {
            if (instance == null)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnrun_Click(object sender, EventArgs e)
        {
            instance = null;
            Close();
        }
    } 
}

   