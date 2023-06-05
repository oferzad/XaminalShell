﻿using System.Collections.ObjectModel;
using System.Windows.Input;
using Xaminals.Data;
using Xaminals.Models;

namespace Xaminals.ViewModels
{
    public class ElephantsPageViewModel : ViewModel
    {
        
        private DataSource _dataSource;

        public ObservableCollection<Animal> Elephants { get; set; }

        private Animal selectedElephant;
        public Animal SelectedElephant { get => selectedElephant; set { selectedElephant = value; OnPropertyChanged(); } }
        public ICommand SelectCommand { get; private set; }

        public ElephantsPageViewModel(DataSource dataSource)
        {
            _dataSource = dataSource;
            Elephants = new ObservableCollection<Animal>(_dataSource.GetElephants());


            //write here the neccesary command to pass both the name of the elephant
            //and elepahant object itself to the elephant details page
            var navParam = new Dictionary<string, object>()
            {
                { "Elephant",SelectedElephant }
            };
            SelectCommand = new Command(async () => { await Shell.Current.GoToAsync($"elephantdetail?name={SelectedElephant.Name}", navParam); }) ;

        }

       


    }
}
