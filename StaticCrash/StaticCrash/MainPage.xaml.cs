using System.ComponentModel;

namespace StaticCrash
{
    [DesignTimeVisible(false)]
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            listView.ItemsSource = new[] {"Item1", "Item2"};
        }
    }
}