using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoERandomBuildGenerator
{
    public class BuildGenerator
    {
        private readonly int numberOfKeystones;
        private readonly ObservableCollection<Node> keystones;
        private readonly ObservableCollection<Ascendancy> ascendancies;

        private readonly Random randomAscendancy = new();
        private readonly Random randomKeystone = new();

        public BuildGenerator(ObservableCollection<Node> keystones, ObservableCollection<Ascendancy> ascendancies, int numberOfKeystones)
        {
            this.numberOfKeystones = numberOfKeystones;
            this.keystones = new(keystones.Where(x => x.IsActive));
            this.ascendancies = new(ascendancies.Where(x => x.IsActive));
        }

        public Build GenerateBuild()
        {
            List<Node> rndkeystones = new();
            for (int i = 0; i < numberOfKeystones; i++)
            {
                var rndKeystone = keystones[randomKeystone.Next(keystones.Count)];
                while (rndkeystones.Contains(rndKeystone))
                {
                    rndKeystone = keystones[randomKeystone.Next(keystones.Count)];
                }
                rndkeystones.Add(rndKeystone);
            }

            return new Build
            {
                Ascendancy = ascendancies[randomAscendancy.Next(ascendancies.Count)].Name,
                Keystones = new(rndkeystones)
            };
        }
    }
}
