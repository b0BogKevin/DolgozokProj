using CommunityToolkit.Mvvm.ComponentModel;
using Dolgozok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok.ViewModels
{
    public partial class ManageVM : ObservableObject
    {

        [ObservableProperty] private List<Worker> allWorkers;

        private readonly DatabaseContext context = new();

        public async Task LoadAll()
        {
            AllWorkers = context.Workers.ToList();
        }
    }
}
