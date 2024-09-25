namespace RzutKostka
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //Braian K 5g
            Random r = new Random();
            int diceRoll = r.Next(1, 7);
            CounterBtn.Text = "Luźny wyniczek mordeczko: " + diceRoll.ToString();
        }
    }

}
