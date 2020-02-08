using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Helt_i_fisk.Annotations;

namespace Helt_i_fisk
{
    class AnimalViewModel: INotifyPropertyChanged
    {
        private ObservableCollection<Animal> Animals = new ObservableCollection<Animal>();
        private Animal currentAnimal;
        
        public Animal CurrentAnimal
        {
            get
            {
                return currentAnimal;
            }
            set
            {
                currentAnimal = value;
                OnPropertyChanged("CurrentAnimal");
            }

        }
        public ObservableCollection<Animal> animals
        {
            get { return Animals;}
            set { Animals = value; }
        }
        public AnimalViewModel()
        {
            Animals.Add(new Animal("Butterflyfish","20 cm","n/a", "C:\\Users\\mike5171\\Desktop\\Animalpictures\\butterflyfish.jpg"));
            Animals.Add(new Animal("Tiger Shark", "3.25 to 4.25 m", "385 to 635 kg", "C:\\Users\\mike5171\\Desktop\\Animalpictures\\tigershark.jpg")); 
            Animals.Add(new Animal("Great White Shark", "4.6 m to 6 m", "2.268 kg", "C:\\Users\\mike5171\\Desktop\\Animalpictures\\whiteshark.jpg"));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
