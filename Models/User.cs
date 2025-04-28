using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Models
{
    public class User : EntityBase
    {
        public string _position = null!;
        public float _salary;
        private Department _department = null!;
        private WorkStatus _workStatus = null!;
        public string EmployeeId { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Position{ 
            get { return _position; }
            set { _position = value; OnPropertyChanged(); }
        }
        public DateTime HiredDate { get; set; }
        public float Salary { 
            get { return _salary; }
            set { _salary = value; OnPropertyChanged(); }
        }
        public int DepartmentId { get; set; }
        public int ContactInfoId { get; set; }
        public int WorkStatusId { get; set; }
        
        public Department Department {
            get { return _department; }
            set { _department = value; OnPropertyChanged(); }
        }
        public ContactInfo ContactInfo { get; set; } = null!;
        public WorkStatus WorkStatus
        {
            get { return _workStatus; }
            set { _workStatus = value; OnPropertyChanged(); }
        }
    }
}
