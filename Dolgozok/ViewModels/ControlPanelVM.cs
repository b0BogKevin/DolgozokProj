using CommunityToolkit.Mvvm.ComponentModel;
using Dolgozok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok.ViewModels
{
    public partial class ControlPanelVM:ObservableObject
    {
        [ObservableProperty] private int numOfWorkers;
        [ObservableProperty] private int paidWorkersNum;
        [ObservableProperty] private int unpaidWorkersNum;

        [ObservableProperty] private string highestSalaryName;
        [ObservableProperty] private string lowestSalaryName;


        private readonly Repo repo = new();

        public async Task LoadAll()
        {
            NumOfWorkers = repo.CountWorkers();
            PaidWorkersNum = repo.CountPaid();
            UnpaidWorkersNum = repo.CountUnpaid();

            HighestSalaryName = repo.HighestSalaryName();
            LowestSalaryName = repo.LowestSalaryName();

        }
    }
}
