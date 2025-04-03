using Dolgozok.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dolgozok
{
    public class Repo
    {
        private readonly DatabaseContext context = new();

        /* NumOfWorkers = context.Workers.Count();
             PaidWorkersNum = context.Workers.Count(w=>w.Salary>0);
             UnpaidWorkersNum = context.Workers.Count(w => w.Salary == 0);

             HighestSalaryName = context.Workers.OrderByDescending(w => w.Salary).First().Name;
             LowestSalaryName = context.Workers.OrderBy(w => w.Salary).First().Name;*/

        public int CountWorkers() => context.Workers.Count();
        public int CountPaid() => context.Workers.Count(w => w.Salary > 0);
        public int CountUnpaid() => context.Workers.Count(w => w.Salary == 0);
        public string HighestSalaryName() => context.Workers.OrderByDescending(w => w.Salary).First().Name;
        public string LowestSalaryName() => context.Workers.OrderBy(w => w.Salary).First().Name;

        public void AddWorker(Worker worker)
        {
            try
            {
                context.Workers.Add(worker);
                context.SaveChanges();
            }
            catch (Exception e)
            {
            }
        }

        public List<Worker> Search(string s)=> [.. context.Workers.Where(w => w.Name.Contains(s))];
        public List<Worker> LoadAll()=> [.. context.Workers];

    }
}
