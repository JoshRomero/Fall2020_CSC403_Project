using System;
using Fall2020_CSC403_Project.code;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel_2 : Form
    {
        private Player player;
        private Item potion;
        private Character[] walls;
        private DateTime timeBegin;
        private FrmBattle frmBattle;
        private Frm_Pick_Up1 frm_Pick_Up;
        public FrmLevel_2()
        {
            InitializeComponent();
        }


        private void FrmLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 10;

            // the position of the onject 
            player = new Player(CreatePosition(picPlayer2), CreateCollider(picPlayer2, PADDING));
            potion = new Item(CreatePosition(pictpotion2), CreateCollider(pictpotion2, PADDING));

            // name of the items
            potion.name = "Healing potion";

            // setting the images for the background when hit
            potion.Img = pictpotion2.BackgroundImage;

            // adding the background color when hit
            potion.Color = Color.DeepPink;

            walls = new Character[NUM_WALLS];
            for (int w = 13; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
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

      /*  private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }*/

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
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
            if (HitAWall(player))
            {
                player.MoveBack();
            }
            else if (HitAItem(player, potion))
            {
                Pick_Up(potion);
            }
            // update player's picture box
            picPlayer2.Location = new Point((int)player.Position.x, (int)player.Position.y);
            //TODO add level 3 
            // if the player passes the boss and exits the screen
            /*if (picPlayer2.Location.X >= 1176)
            {
                Close();
            }*/
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
        private bool HitAItem(Character you, Item other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy, player.bag.has_knife());
            frmBattle.Show();

            // TODO set boss up
            /*if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }*/
        }
        private void Pick_Up(Item item)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frm_Pick_Up = Frm_Pick_Up1.GetInstance(item);
            item.remove_item();
            if (item == potion)
            {
                pictpotion2.Location = new Point((int)potion.Position.x, (int)potion.Position.y);
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

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }





    }
    }
