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
            int diceRoll = 10;
            if (kostka4.IsChecked)
            {
                diceRoll = r.Next(1, 5);
            }
            if (kostka6.IsChecked)
            {
                diceRoll = r.Next(1, 7);
            }
            if (kostka10.IsChecked)
            {
                diceRoll = r.Next(1, 11);
            }
            if (kostka12.IsChecked)
            {
                diceRoll = r.Next(1, 13);
            }
            Wynik.Text = "Luźny wyniczek mordeczko: " + diceRoll.ToString();
        }
    }

}
