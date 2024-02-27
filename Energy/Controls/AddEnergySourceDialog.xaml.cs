using Energy.Models;
using Energy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Energy.Controls
{
    /// <summary>
    /// Interaction logic for AddEnergySourceDialog.xaml
    /// </summary>
    public partial class AddEnergySourceDialog : UserControl
    {
        public AddEnergySourceDialog()
        {
            InitializeComponent();
        }

        public EnergySource Preset { get; private set; }
        private void OnOkClick(object sender, RoutedEventArgs e) => Preset = (this.DataContext as AddEnergySourceContext).SelectedPreset;
    }
}
