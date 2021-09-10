using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace PoERandomBuildGenerator
{
    public class PassiveTreeHelper
    {
        private List<long> disabledByDefaultKeyStones;

        public PassiveTreeHelper()
        {
            disabledByDefaultKeyStones = new() {
                12953,
                60069,
                40561,
                3354,
                30847,
                57280,
                32118
            };
            Init();
        }

        private void Init()
        {
            var json = File.ReadAllText("data.json");
            var passiveTree = JsonConvert.DeserializeObject<PassiveTree>(json);
            Keystones = passiveTree.Nodes.Select(x => x.Value).Where(x => x.IsKeystone == true && x.Skill != 37081).OrderBy(x => x.Name).ToList();

            foreach (var item in disabledByDefaultKeyStones)
            {
                Keystones.First(x => x.Skill == item).IsActive = false;
            }

            Ascendancies = passiveTree.Classes.OrderBy(x => x.Name).SelectMany(x => x.Ascendancies).ToList();
        }

        public List<Node> Keystones { get; private set; }
        public List<Ascendancy> Ascendancies { get; private set; }

    }
}
