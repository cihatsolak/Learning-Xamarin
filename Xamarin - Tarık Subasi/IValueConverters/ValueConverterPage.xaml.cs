using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApplication.IValueConverters
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ValueConverterPage : ContentPage
    {
        public ValueConverterPage()
        {
            InitializeComponent();

            var myList = new List<FootballTeams>()
            {
                new FootballTeams(){TeamName="Galasataray", GoalCount="5"},
                new FootballTeams(){TeamName="Fenerbahçe", GoalCount="10"},
                new FootballTeams(){TeamName="Beşiktaş", GoalCount="15"},
                new FootballTeams(){TeamName="Trabzon", GoalCount="20"},
                new FootballTeams(){TeamName="Bursaspor", GoalCount="7"},
                new FootballTeams(){TeamName="Juventus", GoalCount="13"},
                new FootballTeams(){TeamName="Bayern Munich", GoalCount="18"},
                new FootballTeams(){TeamName="Başahsehir", GoalCount="16"}
            };

            footballListView.ItemsSource = myList;
        }
    }
}