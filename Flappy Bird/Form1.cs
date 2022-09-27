namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        
        //Creates an instance of the game ad about screen window
        GameScreen inGameScreen = new GameScreen();
        AboutScreen inAboutScreen = new AboutScreen();

        public Form1()
        {
            InitializeComponent();
        }

        private void GameScreen(object sender, EventArgs e)
        {
            //Uses the game screen instance to display on screen once clicked
            inGameScreen.Show();
        }

        private void AboutScreen(object sender, EventArgs e)
        {
            //Uses the game screen instance to display on screen once clicked
            inAboutScreen.Show();
        }
    }
}