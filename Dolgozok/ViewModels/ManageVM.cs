using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dolgozok.Models;
using System.Windows;

namespace Dolgozok.ViewModels
{
    public partial class ManageVM : ObservableObject
    {

        [ObservableProperty] private List<Worker> allWorkers;

        [ObservableProperty] private string newWorkerName;
        [ObservableProperty] private string newWorkerEmail;
        [ObservableProperty] private string searchText;


        private readonly Repo repo = new();

        public ManageVM()
        {
            AllWorkers = repo.LoadAll();
           

        }

        [RelayCommand]
        private void AddWorker()
        {
            Worker worker = new(NewWorkerName, NewWorkerEmail);

            repo.AddWorker(worker);
            SearchText = " ";
            Search();

        }

        [RelayCommand]
        private void Search()
        {
            AllWorkers = repo.Search(SearchText);

        }
    }
}
