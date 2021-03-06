﻿using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
    public partial class FrmLevel_1 : Form
    {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy dragon;
    private Enemy enemyCheeto;
    private Item potion;
    private Character[] walls;
    private Item knife;
    private Item bow;
    private bool traded;

    private DateTime timeBegin;
    private FrmBattle frmBattle;
    private Frm_Pick_Up1 frm_Pick_Up;
    private wall4_NoHammer wall4_nohammer;

    public FrmLevel_1() {
          // checks last level and replay to make sure the player did not die and wants to playe again
          // if last level == 2 and not replay will produce a different initializecomponent
          if(Program.last_level == 2 && !Program.replay)
            {
                InitializeComponent();
            }
            else
            {
                InitializeComponent1();
                if (Program.replay)
                {
                    Program.replay = false;
                }
            }
      
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;
      traded = false;

      // the position of the onject 
      player = new Player(CreatePosition(picPlayer1), CreateCollider(picPlayer1, PADDING));
      dragon = new Enemy(CreatePosition(picdragon), CreateCollider(picdragon, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
      potion = new Item(CreatePosition(pictpotion1), CreateCollider(pictpotion1, PADDING));
      knife = new Item(CreatePosition(picbig_knife), CreateCollider(picbig_knife, PADDING));
      bow = new Item(CreatePosition(picbow), CreateCollider(picbow, PADDING));
      

      // set max health
      dragon.MaxHealth = 20;
      dragon.Health = 20;
      // setting if an item is a weapon of not 
      knife.is_weapon = true;
      bow.is_weapon = true;
      potion.is_weapon = false;
      // names of the items
      potion.name = "Healing potion";
      knife.name = "big knife";
      bow.name = "long bow";

      // set all images
      dragon.Img = picdragon.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
      potion.Img = pictpotion1.BackgroundImage;
      knife.Img = picbig_knife.BackgroundImage;
      bow.Img = picbow.BackgroundImage;

      // set every things color
      dragon.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);
      potion.Color = Color.DeepPink;
      knife.Color = Color.DarkRed;
      bow.Color = Color.DarkGreen;

      // handles the creation of the walls
      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;
    }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    /// <summary>
    ///  handles the players interaction with the game
    /// </summary>
    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      player.ResetWithPersistents(Program.persistent_health);

        // if players has the knife it will not put it to the screen
        // if player does not have the knife it will generate it
        if(Program.bag.current_weapon == "big knife")
            {
                knife.remove_item();
                picbig_knife.Location = new Point((int)knife.Position.x, (int)knife.Position.y);
            }
        else
        {
            knife.return_item(583, 74);
            picbig_knife.Location = new Point((int)knife.Position.x, (int)knife.Position.y);
        }

        if (Program.bag.has_hammer())
        {
            walls[4].open_hidden_wall();
        }
      // move player
      if (Program.level == 1)
            {
                if (Program.replay == true && Program.last_level != 2)
                {
                    Close();
                    return;
                }
                player.Move();
            }
       else
            {
                Close();
                return;
            }

            // if Mr. peanut's health is at 20% or less he will be baby Mr. peanut
            if (player.Health <= (player.MaxHealth * .2))
            {
                // changes to super babypeanut if they have hammer
                if (Program.bag.has_hammer())
                {
                    picPlayer1.BackgroundImage = Properties.Resources.superbabyPeanut;
                }
                else
                {
                    picPlayer1.BackgroundImage = Properties.Resources.babyPeanut;
                }
            }
            else
            {
                // changes to super peanut if they have hammer
                if (Program.bag.has_hammer())
                {
                    picPlayer1.BackgroundImage = Properties.Resources.superplayer;
                }
                else
                {
                    picPlayer1.BackgroundImage = Properties.Resources.player;
                }
            }

        // check collision with walls
        if (HitAWall(player)) {
            player.MoveBack();
        }

        // check collision with enemies or items
        if (HitAChar(player, enemyPoisonPacket)) {
            Fight(enemyPoisonPacket);
        }
        else if (HitAChar(player, enemyCheeto)) {
            Fight(enemyCheeto);
        }
        else if (HitAChar(player, dragon)) {
            Fight(dragon);
        }
        else if (HitAItem(player, potion))
        {
            Pick_Up(potion);
        }
        else if (HitAItem(player, knife))
        {
            if (Program.bag.has_weapon())
            {
                Pick_Up(knife, bow);
            }
            else
            {
                Pick_Up(knife);
            }
         }
         else if (HitAItem(player, bow))
         {
                if (Program.bag.has_weapon())
                {
                    Pick_Up(bow, knife);
                }
                else
                {
                    Pick_Up(bow);
                }
         }

            // update player's picture box
            picPlayer1.Location = new Point((int)player.Position.x, (int)player.Position.y);
            picEnemyPoisonPacket.Location = new Point((int)enemyPoisonPacket.Position.x, (int)enemyPoisonPacket.Position.y);
            picEnemyCheeto.Location = new Point((int)enemyCheeto.Position.x, (int)enemyCheeto.Position.y);
            picdragon.Location = new Point((int)dragon.Position.x, (int)dragon.Position.y);
            
            // changes screen if player leave the level
            if (picPlayer1.Location.X >= 1176)
            {
                Program.change_level(2);
            }
            else if (picPlayer1.Location.X <= 0)
            {
                Program.change_level(0);
            }
        }

        /// <summary>
        /// checks which wall the play may have hit
        /// </summary>
        /// <returns></returns> the wall the player hit
        private bool HitAWall(Character c) {
        bool hitAWall = false;
        for (int w = 0; w < walls.Length; w++) {
            if (c.Collider.Intersects(walls[w].Collider)) {
            hitAWall = true;
                if (c.Collider.Intersects(walls[4].Collider)&& !Program.bag.has_hammer())
                {
                        odd_wall();
                }
            break;
        }
      }
      return hitAWall;
    }

        /// <summary>
        /// checks which character the play may have hit
        /// </summary>
        /// <returns></returns> the character the player hit
        private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

        /// <summary>
        /// checks which item the play may have hit
        /// </summary>
        /// <returns></returns> the item the player hit  
        private bool HitAItem(Character you, Item other)
    {
        return you.Collider.Intersects(other.Collider);
    }

        /// <summary>
        /// starts the fight with an enemy
        /// </summary>
        /// <param name="enemy"></param> the enemy the player is fighting
        private void Fight(Enemy enemy) {
            player.ResetMoveSpeed();
            player.MoveBack();

            frmBattle = FrmBattle.GetInstance(enemy, Program.bag.current_weapon);
            frmBattle.Show();

        }
        /// <summary>
        /// starts the hidden wall screen
        /// </summary>
        private void odd_wall()
        {
            player.ResetMoveSpeed();
            player.MoveBack();

            wall4_nohammer = wall4_NoHammer.GetInstance();
            wall4_nohammer.Show();

        }

        /// <summary>
        /// deals with the picking up potions and weapons process 
        /// </summary>
        /// <param name="item"></param> the item the player hit 
        /// <param name="item2"></param> the weapon the player already has in bag
        private void Pick_Up(Item item, Item item2 = null)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            if (item.is_weapon && Program.bag.has_weapon() && item2 != null)
            {
                frm_Pick_Up = Frm_Pick_Up1.GetInstance2(item2, item);
                if (item.name == "big knife")
                {
                    Program.swap_weapons = true;
                    traded = item2.drop_item((int)knife.Position.x, (int)knife.Position.y);
                    item.remove_item();
                }
                else if (item.name == "long bow")
                {
                    traded = item2.drop_item((int)bow.Position.x, (int)bow.Position.y);
                    item.remove_item();
                }

            }
            else
            {
                frm_Pick_Up = Frm_Pick_Up1.GetInstance(item);
                item.remove_item();
            }
            
            if (!item.is_weapon)
            {
                pictpotion1.Location = new Point((int)potion.Position.x, (int)potion.Position.y);
            }
            else if (item.is_weapon)
            {
                if (traded)
                {
                    if (item2.name == "big knife")
                    {
                        picbig_knife.Location = new Point((int)item2.Position.x, (int)item2.Position.y);
                        picbow.Location = new Point((int)item.Position.x, (int)item.Position.y);
                    }
                    else if (item2.name == "long bow")
                    {
                        picbow.Location = new Point((int)item2.Position.x, (int)item2.Position.y);
                        picbig_knife.Location = new Point((int)item.Position.x, (int)item.Position.y);
                    }
                }
                else
                {
                    if (item.name == "big knife")
                    {
                        picbig_knife.Location = new Point((int)knife.Position.x, (int)knife.Position.y);
                    }
                    else if (item.name == "long bow")
                    {
                        picbow.Location = new Point((int)bow.Position.x, (int)bow.Position.y);
                    }
                }
            }

            frm_Pick_Up.Show();
        }

        /// <summary>
        /// handles the keyboard interaction of the player
        /// </summary>
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
