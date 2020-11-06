﻿using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Fall2020_CSC403_Project {
    public partial class FrmLevel_1 : Form
    {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Item potion;
    private Character[] walls;
    private Item knife;

    private DateTime timeBegin;
    private FrmBattle frmBattle;
    private Frm_Pick_Up1 frm_Pick_Up;
    public FrmLevel_1() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      // the position of the onject 
      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
      potion = new Item(CreatePosition(pictpotion), CreateCollider(pictpotion, PADDING));
      knife = new Item(CreatePosition(picbig_knife), CreateCollider(picbig_knife, PADDING));
      
      // names of the items
      potion.name = "Healing potion";
      knife.name = "big knife";

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
      potion.Img = pictpotion.BackgroundImage;
      knife.Img = picbig_knife.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);
      potion.Color = Color.DeepPink;
      knife.Color = Color.DarkRed;

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

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      if (player.status)
            {
                player.Move();
            }
       else
            {
                player.Move();
                Thread.Sleep(5000);
                Close();
            }

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket)) {
        Fight(enemyPoisonPacket);      
            }
      else if (HitAChar(player, enemyCheeto)) {
        Fight(enemyCheeto);
            }
      else if (HitAChar(player, bossKoolaid)) {
        Fight(bossKoolaid);
            }
      else if (HitAItem(player, potion))
      {
          Pick_Up(potion);
      }
      else if (HitAItem(player, knife))
        {
            Pick_Up(knife);
        }

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
            picEnemyPoisonPacket.Location = new Point((int)enemyPoisonPacket.Position.x, (int)enemyPoisonPacket.Position.y);
            picEnemyCheeto.Location = new Point((int)enemyCheeto.Position.x, (int)enemyCheeto.Position.y);
            picBossKoolAid.Location = new Point((int)bossKoolaid.Position.x, (int)bossKoolaid.Position.y);
        }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
        if (c.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }
    private bool HitAItem(Character you, Item other)
    {
        return you.Collider.Intersects(other.Collider);
    }

        private void Fight(Enemy enemy) {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy, player.bag.has_knife());
            frmBattle.Show();

            if (enemy == bossKoolaid) {
                frmBattle.SetupForBossBattle();
            }
        }
        private void Pick_Up(Item item)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frm_Pick_Up = Frm_Pick_Up1.GetInstance(item);
            item.remove_item();
            if (item == potion)
            {
                pictpotion.Location = new Point((int)potion.Position.x, (int)potion.Position.y);
            }
            else if (item == knife)
            {
                picbig_knife.Location = new Point((int)knife.Position.x, (int)knife.Position.y);
            }
            frm_Pick_Up.Show();
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
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

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }
  }
}
