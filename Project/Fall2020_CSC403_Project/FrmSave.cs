using Fall2020_CSC403_Project.code;
using System.Windows.Forms;


namespace Fall2020_CSC403_Project
{
    public partial class FrmSave : Form
    {

        public static FrmSave instance = null;
        private Enemy enemy;
        private FrmSave()
        {
            InitializeComponent();
        }
        public void Setup()
        {
            // update for this enemy
            picgirl.BackgroundImage = enemy.Img;
            picgirl.Refresh();
            BackColor = enemy.Color;
        }
        public static FrmSave GetInstance(Enemy enemy)
        {
            if (instance == null)
            {
                instance = new FrmSave();
                instance.enemy = enemy;
                instance.Setup();
            }
            return instance;
        }
    }
}
