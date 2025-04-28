
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace WpfApp8.Models
{
    public abstract class EntityBase : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
