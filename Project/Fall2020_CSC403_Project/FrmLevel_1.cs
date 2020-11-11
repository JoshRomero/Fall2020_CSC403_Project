using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;

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
    public FrmLevel_1() {
          if(Fall2020_CSC403_Project.Program.last_level == 2)
            {
                InitializeComponent();
            }
            else
            {
                InitializeComponent1();
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

      dragon.Img = picdragon.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
      potion.Img = pictpotion1.BackgroundImage;
      knife.Img = picbig_knife.BackgroundImage;
      bow.Img = picbow.BackgroundImage;

      dragon.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);
      potion.Color = Color.DeepPink;
      knife.Color = Color.DarkRed;
      bow.Color = Color.DarkGreen;

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
      player.ResetWithPersistents(Fall2020_CSC403_Project.Program.persistent_health);
        if(Fall2020_CSC403_Project.Program.bag.has_hammer())
        {
            walls[4].open_hidden_wall();
        }
      // move player
      if (player.status)
            {
                player.Move();
            }
       else
            {
                player.Move();
                Program.end_game();
                Thread.Sleep(5000);
                Close();
                return;
            }

            // if Mr. peanut's health is at 20% or less he will be baby Mr. peanut
            if (player.Health <= (player.MaxHealth * .2))
            {
                if (Fall2020_CSC403_Project.Program.bag.has_hammer())
                {
                    player.AlterStrenght(3);
                    picPlayer1.BackgroundImage = Fall2020_CSC403_Project.Properties.Resources.superbabyPeanut;
                }
                else
                {
                    player.AlterStrenght(2);
                    picPlayer1.BackgroundImage = Fall2020_CSC403_Project.Properties.Resources.babyPeanut;
                }
            }
            else
            {
                if (Fall2020_CSC403_Project.Program.bag.has_hammer())
                {
                    player.AlterStrenght(3);
                    picPlayer1.BackgroundImage = Fall2020_CSC403_Project.Properties.Resources.superplayer;
                }
                else
                {
                    player.AlterStrenght(2);
                    picPlayer1.BackgroundImage = Fall2020_CSC403_Project.Properties.Resources.player;
                }
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
            if (picPlayer1.Location.X >= 1176)
            {
                Program.change_level(2);
                Close();
            }
            else if (picPlayer1.Location.X <= 0)
            {
                Program.change_level(0);
                Close();
            }
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

            frmBattle = FrmBattle.GetInstance(enemy, Program.bag.current_weapon);
            frmBattle.Show();

        }
        private void Pick_Up(Item item, Item item2 = null)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            if (item.is_weapon && Program.bag.has_weapon() && item2 != null)
            {
                frm_Pick_Up = Frm_Pick_Up1.GetInstance2(item2, item);
                if (item.name == "big knife")
                {

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
