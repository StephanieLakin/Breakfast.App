using BreakfastApp.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace BreakfastApp.ViewModels
{
    public partial class BreakfastViewModel : ObservableObject
    {
        [ObservableProperty]
        List<Breakfast> breakfasts;

        [ObservableProperty]
        bool isRefreshing;

        public BreakfastViewModel()
        {
            LoadBreakfastsAsync();
        }

        [RelayCommand]  
       public async void LoadBreakfastsAsync()
        {
            try
            {
                await Task.Delay(2000);
                Breakfasts = new()
            {
                new Breakfast(
                    Name: "Vegan Sushine",
                    Description: "Vegan Everything! Join us for a healthy breakfast full of vegan dishes and cookies 🥑 😋.",
                    StartDateTime: DateTime.UtcNow.AddDays(1),
                    EndDateTime: DateTime.UtcNow.AddDays(1).AddHours(2),
                    Image: new Uri("https://images.unsplash.com/photo-1659778059522-d280d965fde8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"),
                    Savory: new List<string>{"Oatmeal", "Avacado Toast", "Omelet", "Salad" },
                    Sweet: new List<string>{"Cookie"}),
                new Breakfast(
                    Name: "Breakfast@Tiffany's",
                    Description: "Hi, I'm Tiffany, 👋 I'll be your chef on Sunday 💪.",
                    StartDateTime: DateTime.UtcNow,
                    EndDateTime: DateTime.UtcNow.AddHours(2),
                    Image: new Uri("https://plus.unsplash.com/premium_photo-1663858367001-89e5c92d1e0e?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8Ymx1ZWJlcnJ5JTIwcGFuY2FrZXN8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60"),
                    Savory: new List<string> {"Sandwich", "Salad", "Omelet"},
                    Sweet: new List<string>{"Pancakes", "Waffles"}
                    ),
            };
            }
           finally
            {

                IsRefreshing = false;
            }
         
            
        }
        
    }
}
