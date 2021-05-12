using MemoryGameFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MemoryGameFinal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePlay : ContentPage
    {
        GamePlayPageViewModel _viewModel;
        public GamePlay()
        {
            InitializeComponent();
            BindingContext = _viewModel = new GamePlayPageViewModel();

            int x = 5;
            for (int i = 0; i < x; ++i)
                for (int j = 0; j < x; ++j)
                {
                    GamePlayPageGrid.Children.Add(
                        new Button
                        {
                            Text = $"{i}{j}",

                        }, i, j);
                }

            Title = "Memory Game";
        }
    }
}