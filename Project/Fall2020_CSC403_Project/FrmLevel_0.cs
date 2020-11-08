﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel_0 : Form
    {
        private Player player;
        private Enemy bossKoolaid;
        private Enemy girl;
        private Character[] walls;
        private DateTime timeBegin;
        private FrmBattle frmBattle;
        private FrmSave frmSave;

        public FrmLevel_0()
        {
            InitializeComponent();
        }
        private void FrmLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 6;

            // the position of the onject 
            player = new Player(CreatePosition(picPlayer0), CreateCollider(picPlayer0, PADDING));
            girl = new Enemy(CreatePosition(picgirl), CreateCollider(picgirl, PADDING));
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));

            // set max health
            bossKoolaid.MaxHealth = 60;
            bossKoolaid.Health = 60;

            // setting the images for the background when hit
            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            girl.Img = picgirl.BackgroundImage;


            // adding the background color when hit
            bossKoolaid.Color = Color.Red;
            girl.Color = Color.HotPink;

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picdarkwall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            Game.player = player;
            timeBegin = DateTime.Now;
        }


        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }
        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            player.ResetMoveSpeed();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime1.Text = "Time: " + time.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
          
            player.ResetWithPersistents(Fall2020_CSC403_Project.Program.persistent_health);
            // move player
            if (player.status)
            {
                player.Move();
            }
            else
            {
                Program.end_game();
                Thread.Sleep(5000);
                Close();
                return;
            }

            // check collision with walls
            if (HitAWall(player))
            {
                player.MoveBack();
            }
            else if (HitAChar(player, bossKoolaid))
            {
                Fight(bossKoolaid);
            }
            else if (HitAChar(player, girl))
            {
                save(girl);
            }

            // update player's picture box
            picPlayer0.Location = new Point((int)player.Position.x, (int)player.Position.y);
            picBossKoolAid.Location = new Point((int)bossKoolaid.Position.x, (int)bossKoolaid.Position.y);

            // if the player passes the boss and exits the screen
            if (picPlayer0.Location.X >= 1176)
            {
                Program.change_level(3);
                Close();
            }
        }

        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++)
            {
                if (c.Collider.Intersects(walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy, Program.bag.current_weapon);
            frmBattle.Show();

            if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }
        }
        private void save(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmSave = FrmSave.GetInstance(enemy);
            frmSave.Show();
            player.status = false;

        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.GoLeft();
                    break;

                case Keys.Right:
                    player.GoRight();
                    break;

                case Keys.Up:
                    player.GoUp();
                    break;

                case Keys.Down:
                    player.GoDown();
                    break;

                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }

    }
}