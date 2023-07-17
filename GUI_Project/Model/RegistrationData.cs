using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Model
{
    public class RegistrationData : INotifyPropertyChanged
    {
        private string? name;
        private string? address;
        private string? gender;
        private string? dOB;
        private string? email;
        private string? mobile;
        private string? membership;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (address != value)
                {
                    address = value;
                    OnPropertyChanged("Address");
                }
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (gender != value)
                {
                    gender = value;
                    OnPropertyChanged("Gender");
                }
            }
        }

        public string DOB
        {
            get { return dOB; }
            set
            {
                if (dOB != value)
                {
                    dOB = value;
                    OnPropertyChanged("DOB");
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        public string Mobile
        {
            get { return mobile; }
            set
            {
                if (mobile != value)
                {
                    mobile = value;
                    OnPropertyChanged("Mobile");
                }
            }
        }

        public string Membership
        {
            get { return membership; }
            set
            {
                if (membership != value)
                {
                    membership = value;
                    OnPropertyChanged("Membership");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName
            )
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyAddress));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyGender));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyDOB));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyEmail));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyMobile));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyMembership));
        }


    }
}
