﻿using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmBattle : Form
    {
        public static FrmBattle instance = null;
        private Enemy enemy;
        private Player player;

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

        public void Setup()
        {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;

            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
            player.AttackEvent += EnemyDamage;

            // show health
            UpdateHealthBars();
        }

        public void SetupForBossBattle()
        {
            picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;

            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();

            tmrFinalBattle.Enabled = true;
        }

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

        private void UpdatePotionsCount()
        {
            num_potions.Text = ("X " + player.bag.num_potions().ToString());
        }
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


        private void btnAttack_Click(object sender, EventArgs e)
        {
            player.OnAttack(-3);
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2);
            }
            UpdateHealthBars();
            if (player.Health <= 0 || enemy.Health <= 0)
            {
                if (enemy.Health <= 0)
                {
                    enemy.death();
                }
                else
                {
                    player.death();
                }
                instance = null;
                Close();
            }
        }
        private void btnpotion_Click(object sender, EventArgs e)
        {
            if ((player.bag.get_bag_size() > 0) && (player.bag.num_potions() > 0))
            {
                player.bag.use_item("Healing potion");
                player.AlterHealth(5, "heal");
                UpdateHealthBars();
                UpdatePotionsCount();

            }
        }

        private void EnemyDamage(int amount)
        {
            enemy.AlterHealth(amount);
        }

        private void PlayerDamage(int amount)
        {
            player.AlterHealth(amount);
        }

        private void tmrFinalBattle_Tick(object sender, EventArgs e)
        {
            picBossBattle.Visible = false;
            tmrFinalBattle.Enabled = false;
        }


        private void Stab_Click(object sender, EventArgs e)
        {
            if(player.bag.current_weapon == "big knife")
            {
                player.OnAttack(-6);
            }
            else
            {
                player.OnAttack(-10);
            }
            
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2);
            }

            UpdateHealthBars();
            if (player.Health <= 0 || enemy.Health <= 0)
            {
                if (enemy.Health <= 0)
                {
                    enemy.death();
                }
                else
                {
                    player.death();
                }
                instance = null;
                Close();
            }

            }

        private void Shoot_Click(object sender, EventArgs e)
        {
            if (player.bag.current_weapon == "big knife")
            {
                player.OnAttack(-6);
            }
            else
            {
                player.OnAttack(-10);
            }

            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2);
            }

            UpdateHealthBars();
            if (player.Health <= 0 || enemy.Health <= 0)
            {
                if (enemy.Health <= 0)
                {
                    enemy.death();
                }
                else
                {
                    player.death();
                }
                instance = null;
                Close();
            }
        }
     } 
}

   