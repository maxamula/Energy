using Energy.ViewModels;
using SourceChord.Lighty;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Energy.Models;
using LiveCharts;
using LiveCharts.Wpf;

namespace Energy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void OnAddSourceClick(object sender, RoutedEventArgs e)
        {
            var dialog = new Controls.AddEnergySourceDialog();
            await LightBox.ShowAsync(this, dialog);
            if(dialog.Preset != null)
            {
                var vm = (MainWindowContext)this.DataContext;
                vm.EnergySources.Add(dialog.Preset);

                Random random = new Random(Guid.NewGuid().GetHashCode());
                var chart = new LineSeries()
                {
                    Title = dialog.Preset.Name,
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15,
                    Values = new ChartValues<double> { random.Next(1, 10), 6, random.Next(1, 10), 2, random.Next(1, 10) }
                };
                dialog.Preset.Chart = chart;
                vm.SeriesCollection.Add(chart);
            }
        }
            

        private void OnRemoveSourceClick(object sender, RoutedEventArgs e)
        {
            var vm = (MainWindowContext)this.DataContext;
            if (vm.SelectedEnergySource != null)
            {
                if (vm.SelectedEnergySource.Chart != null)
                    vm.SeriesCollection.Remove(vm.SelectedEnergySource.Chart);

                vm.EnergySources.Remove(vm.SelectedEnergySource);
            } 
        }
    }
}