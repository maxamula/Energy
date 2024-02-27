using Energy.Models;
using LiveCharts;
using LiveCharts.Wpf;
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
        public MainWindowContext() 
        {
            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };
            YFormatter = value => value.ToString("C");
        }

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

        private float _discountRate = 0.0f;
        public float DiscountRate
        {
            get => _discountRate;
            set
            {
                _discountRate = value;
                OnPropertyChanged(nameof(DiscountRate));
            }
        }

        #region Plots

        private SeriesCollection _seriesCollection = new SeriesCollection();
        public SeriesCollection SeriesCollection
        {
            get => this._seriesCollection;
            set
            {
                this._seriesCollection = value;
                OnPropertyChanged(nameof(SeriesCollection));
            }
        }

        #endregion

        // TODO
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
    }
}
