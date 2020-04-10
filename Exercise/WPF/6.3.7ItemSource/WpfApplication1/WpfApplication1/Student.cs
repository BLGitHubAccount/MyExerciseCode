using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApplication1
{
    public class Student : INotifyPropertyChanged
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(null,new PropertyChangedEventArgs("Id"));

                }
            }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(null, new PropertyChangedEventArgs("Name"));

                }
            }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(null, new PropertyChangedEventArgs("Age"));

                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
