using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PoERandomBuildGenerator
{
    public class Build : PropertyChangedBase
    {
        private string ascendancy;
        private ObservableCollection<Node> keystones;

        public ObservableCollection<Node> Keystones
        {
            get => keystones;
            set => SetProperty(ref keystones, value);
        }
        public string Ascendancy
        {
            get => ascendancy;
            set => SetProperty(ref ascendancy, value);
        }
    }
}
