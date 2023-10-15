//Using CommunityToolkit.Mvvm
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MyMobileApp.ViewModel
{

    /*
     * FOLLOWING CODE INSPIRED BY JAMES MONTEMAGNO, DOTNET MAUI YOUTUBE TUTORIAL
     * Link: https://www.youtube.com/watch?v=Hh279ES_FNQ&list=PLdo4fOcmZ0oUBAdL2NwBpDs32zwGqb9DY&index=1
     */
    public partial class MainViewModel : ObservableObject
    {
        
        public MainViewModel() 
        {
            //Creating instance of Entries object
            Entries = new ObservableCollection<string>();
        }


        //will automatically trigger different notifications when things are added or removed
        [ObservableProperty]
        ObservableCollection<string> entries;


        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()//Change to something different?
        {
            //Checking to see if entry line is empty
            if (string.IsNullOrWhiteSpace(Text))
                return;

            //Adding entry to collection
            Entries.Add(Text);

            //Emptying input line
            Text = string.Empty;
        }
    }
}
