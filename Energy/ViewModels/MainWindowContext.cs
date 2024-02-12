using Energy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy.ViewModels
{
    public class MainWindowContext : ViewModelBase
    {
        public ObservableCollection<Models.EnergySource> EnergySources { get; set; } = new ObservableCollection<Models.EnergySource>();

        private EnergySource _selectedEnergySource = null;
        public EnergySource SelectedEnergySource
        {
            get => _selectedEnergySource;
            set
            {
                _selectedEnergySource = value;
                OnPropertyChanged(nameof(SelectedEnergySource));
            }
        }
    }
}
