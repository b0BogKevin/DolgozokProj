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


        private readonly DatabaseContext context = new();

        public ManageVM()
        {
            AllWorkers = [.. context.Workers];
           

        }

        [RelayCommand]
        private void AddWorker()
        {
            Worker worker = new(NewWorkerName, NewWorkerEmail);

            try
            {
                context.Workers.Add(worker);
                context.SaveChanges();
                SearchText = " ";
                Search();
            }
            catch (Exception e)
            {
                MessageBox.Show("Nem sikerült, " + e.Message);
            }
            
        }

        [RelayCommand]
        private void Search()
        {
            AllWorkers = context.Workers.Where(w => w.Name.Contains(SearchText)).ToList();

        }
    }
}
