using MauiMixAWord.Gui.ViewModels;

namespace MauiMixAWord.Gui
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MixViewModel();
        }


     
    }

}
