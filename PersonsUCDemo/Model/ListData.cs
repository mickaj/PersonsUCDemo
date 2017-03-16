using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsUCDemo.Model
{
    public class ListData:INotifyPropertyChanged
    {
        public List<Person> Persons { get; set; }

        public ListData()
        {
            Persons = new List<Person>();
            Persons.Add(new Person("John", "Doe", 1980, "Driver", 0.00M));
            Persons.Add(new Person("Jane", "Doe", 1985, "Waitress", 100.00M));
            Persons.Add(new Person("Pierre", "Arronax", 1870, "Marine Biologist", 999.00M));
        }

        private int personIndex;
        public int PersonIndex
        {
            //get
            //{
            //    return personIndex;
            //}
            set
            {
                personIndex = value;
                selectedPerson = Persons[personIndex];
                OnPropertyChanged("personIndex");
                OnPropertyChanged("selectedPerson");
            }
        }

        private Person selectedPerson;
        public Person SelectedPerson
        {
            get
            {
                return selectedPerson;
            }
        }

        //implementation of INotifyPropertyChanged - BEGINS
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(params string[] propertiesChanged)
        {
            if (PropertyChanged != null)
            {
                foreach (string property in propertiesChanged)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
                }
            }
        }
        //implementation of INotifyPropertyChanged - ENDS
    }
}
