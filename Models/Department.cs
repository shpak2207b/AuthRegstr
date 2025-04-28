

namespace WpfApp8.Models
{
    public class Department : EntityBase
    {
        private string _name = null!;
        private string _location = null!;
        public string Name { 
            get { return _name; }
            set { _name = value;OnPropertyChanged(); } 
        }
        public string Location {
            get { return _location; }
            set { _location = value; OnPropertyChanged(); }
            }
     }
}
