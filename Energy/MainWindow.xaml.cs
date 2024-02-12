using Energy.ViewModels;
using OxyPlot.Series;
using OxyPlot.Wpf;
using OxyPlot;
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
            var plotModel = new PlotModel { Title = "Мне похуй" };

            // Create a line series with some random data
            var lineSeries = new LineSeries();
            for (double x = 0; x < 10; x += 0.1)
            {
                double y = Math.Sin(x);
                lineSeries.Points.Add(new DataPoint(x, y));
            }

            // Add the line series to the plot model
            plotModel.Series.Add(lineSeries);

            // Assign the plot model to the PlotView
            plotView.Model = plotModel;
        }

        private async void OnAddSourceClick(object sender, RoutedEventArgs e) =>
            await LightBox.ShowAsync(this, new Controls.AddEnergySourceDialog((this.DataContext as MainWindowContext).EnergySources));

        private void OnRemoveSourceClick(object sender, RoutedEventArgs e)
        {
            var vm = (MainWindowContext)this.DataContext;
            if(vm.SelectedEnergySource != null)
                vm.EnergySources.Remove(vm.SelectedEnergySource);
        }
    }
}