﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMixAWord.Gui.ViewModels;

public partial class MixViewModel : ObservableObject
{

    [ObservableProperty]
    private string _word =string.Empty;


    // variable  in der oberfläche zugreifen es soll eine Eigenschaft
    // werden er schreibt im Hintergrund eine Eigenschaft für mich
    [ObservableProperty]
    private string _mix = string.Empty;



   

    // Das ich es ausgeben kann
    [RelayCommand]
    void Do()


    {
        if (Word.Length < 3)
        {
            // nichts so schöne Ausgabe
            App.Current.MainPage.DisplayAlert("Achtung! Fehler!", "Geben sie bitte mehr als 3 Buchstaben ein", "OK");
        }
        else 
        {
            //this.Mix = Rasser.Lib.String.Shuffle(this.Word);
            //this.Word = string.Empty;

            MauiAppMixWord.Core7.Mix m = new MauiAppMixWord.Core7.Mix();
            this.Mix=m.MixIt(this.Word);
            this.Word=string.Empty;
        }3,
    }

}
