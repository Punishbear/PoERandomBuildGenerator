using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoERandomBuildGenerator
{
    public class PoERandomBuildGeneratorViewModel : PropertyChangedBase
    {
        private ObservableCollection<Node> keystones;
        private ObservableCollection<Ascendancy> ascendancies;
        private Build build;
        private int maxKeystoneAmount;

        public int KeystoneAmount { get; set; }
        public ObservableCollection<Node> Keystones
        {
            get => keystones;
            set => SetProperty(ref keystones, value);
        }
        public ObservableCollection<Ascendancy> Ascendancies
        {
            get => ascendancies;
            set => SetProperty(ref ascendancies, value);
        }
        public Build Build
        {
            get => build;
            set => SetProperty(ref build, value);
        }
        public int MaxKeystoneAmount
        {
            get => maxKeystoneAmount;
            set => SetProperty(ref maxKeystoneAmount, value, () =>
            {
                if (KeystoneAmount > maxKeystoneAmount)
                {
                    KeystoneAmount = maxKeystoneAmount;
                }
            });
        }

        private void Keystones_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
                foreach (Node item in e.NewItems)
                    item.PropertyChanged += Node_PropertyChanged;

            if (e.OldItems != null)
                foreach (Node item in e.OldItems)
                    item.PropertyChanged -= Node_PropertyChanged;
        }

        private void Node_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName is nameof(Node.IsActive))
                MaxKeystoneAmount = Keystones.Where(x => x.IsActive).Count();
        }

        public PoERandomBuildGeneratorViewModel()
        {
            var passiveTree = new PassiveTreeHelper();

            Keystones = new();
            Keystones.CollectionChanged += Keystones_CollectionChanged;

            foreach (var item in passiveTree.Keystones)
            {
                Keystones.Add(item);
            }
            MaxKeystoneAmount = Keystones.Count(x => x.IsActive);
            Ascendancies = new(passiveTree.Ascendancies);
        }

        public void GenerateBuild()
        {
            var bg = new BuildGenerator(Keystones, Ascendancies, KeystoneAmount);
            Build = bg.GenerateBuild();
        }
    }
}
