using System;
using Fall2020_CSC403_Project.code;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel_3 : Form
    {
        private Player player;
        private Item potion;
        private Enemy cookieMonster;
        private Enemy enemyBatie;
        private Character[] walls;
        private DateTime timeBegin;
        private FrmBattle frmBattle;
        private Frm_Pick_Up1 frm_Pick_Up;
        private Item hammer;
        public FrmLevel_3()
        {
            InitializeComponent();
        }


        private void FrmLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 5;


            // the position of the onject 
            player = new Player(CreatePosition(picPlayer2), CreateCollider(picPlayer2, PADDING));
            potion = new Item(CreatePosition(pictpotion2), CreateCollider(pictpotion2, PADDING));
            cookieMonster = new Enemy(CreatePosition(piccookie), CreateCollider(piccookie, PADDING));
            enemyBatie = new Enemy(CreatePosition(picbat), CreateCollider(picbat, PADDING));
            hammer = new Item(CreatePosition(pichammer), CreateCollider(pichammer, PADDING));

            // adjust enemies health
            enemyBatie.MaxHealth = 25;
            cookieMonster.MaxHealth = 30;
            enemyBatie.Health = 25;
            cookieMonster.Health = 30;

            // name of the items
            potion.name = "Healing potion";
            hammer.name = "Mjölnir";

            // setting the images for the background when hit
            potion.Img = pictpotion2.BackgroundImage;
            cookieMonster.Img = piccookie.BackgroundImage;
            enemyBatie.Img = picbat.BackgroundImage;
            hammer.Img = pichammer.BackgroundImage;

            // adding the background color when hit
            potion.Color = Color.DeepPink;
            cookieMonster.Color = Color.Blue;
            enemyBatie.Color = Color.DarkSlateGray;
            hammer.Color = Color.DarkBlue;

            walls = new Character[NUM_WALLS];
            for (int w = 22; w < NUM_WALLS + 13; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w - 22] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
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
            player.ResetWithPersistents(Program.persistent_health);

            if (Program.bag.has_hammer())
            {
                hammer.remove_item();
                pichammer.Location = new Point((int)hammer.Position.x, (int)hammer.Position.y);
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

            // turns Mr. peanut into baby peanut if at 20% or under
            if (player.Health <= (player.MaxHealth * .2))
            {
                // changes peanut to superpeanut if they have thor's hammer and increases strenght
                if (Program.bag.has_hammer())
                {
                    picPlayer2.BackgroundImage = Properties.Resources.superbabyPeanut;
                }
                else
                {
                    picPlayer2.BackgroundImage = Properties.Resources.babyPeanut;
                }
            }
            else
            {
                if (Program.bag.has_hammer())
                {
                    picPlayer2.BackgroundImage = Properties.Resources.superplayer;
                }
                else
                {
                    picPlayer2.BackgroundImage = Properties.Resources.player;
                }
            }

            // check collision with walls
            if (HitAWall(player))
            {
                player.MoveBack();
            }
            else if (HitAItem(player, potion))
            {
                Pick_Up(potion);
            }
            else if (HitAItem(player, hammer))
            {
                Pick_Up(hammer);
            }
            // check collision with enemies
            if (HitAChar(player, enemyBatie))
            {
                Fight(enemyBatie);
            }
            else if (HitAChar(player, cookieMonster))
            {
                Fight(cookieMonster);
            }
 
            // update player's picture box
            picPlayer2.Location = new Point((int)player.Position.x, (int)player.Position.y);
            picbat.Location = new Point((int)enemyBatie.Position.x, (int)enemyBatie.Position.y);
            piccookie.Location = new Point((int)cookieMonster.Position.x, (int)cookieMonster.Position.y);

            // if the player passes the boss and exits the screen
            if (picPlayer2.Location.X >= 1176)
            {
                Program.change_level(3);
                Close();
            }
            else if (picPlayer2.Location.X <= 0)
            {
                Program.change_level(1);
                Close();
            }
        }

        // if player hit a wall check
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

        // if player hits a character check
        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }
        private bool HitAItem(Character you, Item other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        // player hit a enemy and will fight 
        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy, Program.bag.current_weapon);
            frmBattle.Show();

        }

        // player hit a item go to pick it up if it is a weapon and they already have a weapon then trade it
        private void Pick_Up(Item item, Item item2 = null)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frm_Pick_Up = Frm_Pick_Up1.GetInstance(item);
            item.remove_item();


            if (!item.is_weapon)
            {
                if (item.name == "Healing potion")
                {
                    pictpotion2.Location = new Point((int)potion.Position.x, (int)potion.Position.y);

                }
                else
                {
                    pichammer.Location = new Point((int)hammer.Position.x, (int)hammer.Position.y);
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
