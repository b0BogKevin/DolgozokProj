using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok.ViewModels
{
    public partial class MainVM:ObservableObject
    {

        private ControlPanelVM controlPanelVM;
        private ManageVM manageVm;

        [ObservableProperty] private object vm;

        public MainVM()
        {
            controlPanelVM = new();
            manageVm = new();

            vm = controlPanelVM;
        }

        [RelayCommand]
        private void ShowControlPanel()
        {
            vm = controlPanelVM;
        }

        [RelayCommand]
        private void ShowManage()
        {
            vm = manageVm;
        }
    }
}
