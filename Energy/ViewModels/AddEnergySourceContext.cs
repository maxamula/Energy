using Energy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy.ViewModels
{
    public class AddEnergySourceContext : ViewModelBase
    {
        public AddEnergySourceContext() 
        {
            Presets.Add(new EnergySource() { Name = "Empty", Path = "-" });
            try
            {
                string presetsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Presets");
                string[] files = Directory.GetFiles(presetsPath, $"*.preset");
                foreach (string file in files)
                {
                    var preset = Utils.Serializer.Deserialize<EnergySource>(file);
                    preset.Path = file;
                    Presets.Add(preset);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public ObservableCollection<EnergySource> Presets { get; set; } = new ObservableCollection<EnergySource>();

        private EnergySource _selectedPreset;
        public EnergySource SelectedPreset
        {
            get => _selectedPreset;
            set
            {
                _selectedPreset = value;
                OnPropertyChanged(nameof(SelectedPreset));
            }
        }
    }
}
