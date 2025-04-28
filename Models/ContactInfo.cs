
namespace WpfApp8.Models
{
    public class ContactInfo : EntityBase
    {
        private string _email = null!;
        private string _phoneNumber = null!;
        private string? _telegramNickname;
        public string Email
        {
            get { return _email;  }
            set { _email = value; OnPropertyChanged(); }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; OnPropertyChanged(); }
        }
        public string? TelegramNickname
        {
            get { return _telegramNickname; }
            set { _telegramNickname = value; OnPropertyChanged(); }
        }
    }
}
