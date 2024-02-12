using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Energy.Models
{
    [DataContract]
    public class EnergySource : ViewModels.ViewModelBase
    {
        private string _name;
        [DataMember]
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private string _path;
        public string Path
        {
            get => _path;
            set
            {
                _path = value;
                OnPropertyChanged(nameof(Path));
            }
        }

        private float _cost;
        [DataMember]
        public float Cost
        {
            get => _cost;
            set
            {
                _cost = value;
                OnPropertyChanged(nameof(Cost));
            }
        }


        private float _installationCost;
        [DataMember]
        public float InstallationCost
        {
            get => _installationCost;
            set
            {
                _installationCost = value;
                OnPropertyChanged(nameof(InstallationCost));
            }
        }


        private float _lifetime;
        [DataMember]
        public float Lifetime
        {
            get => _lifetime;
            set
            {
                _lifetime = value;
                OnPropertyChanged(nameof(Lifetime));
            }
        }


        private float _annualOutput;
        [DataMember]
        public float AnnualOutput
        {
            get => _annualOutput;
            set
            {
                _annualOutput = value;
                OnPropertyChanged(nameof(AnnualOutput));
            }
        }

        private byte[] _image;
        [DataMember]
        public byte[] Image
        {
            get => _image;
            set
            {
                _image = value;
                OnPropertyChanged(nameof(Image));
            }
        }
    }
}
