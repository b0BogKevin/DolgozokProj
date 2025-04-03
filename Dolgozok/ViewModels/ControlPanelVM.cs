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


        private readonly DatabaseContext context = new();

        public async Task LoadAll()
        {
            NumOfWorkers = context.Workers.Count();
            PaidWorkersNum = context.Workers.Count(w=>w.Salary>0);
            UnpaidWorkersNum = context.Workers.Count(w => w.Salary == 0);

            HighestSalaryName = context.Workers.OrderByDescending(w => w.Salary).First().Name;
            LowestSalaryName = context.Workers.OrderBy(w => w.Salary).First().Name;

        }
    }
}
