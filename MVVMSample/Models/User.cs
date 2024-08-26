using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSample.Models
{
    internal class User : ObservableObject
    {
        // propfull then tab tab to create automatically - then changing name, type ... using tabs
        private int id;
        private string? name;
        private string? userName;
        private string? email;
        private string? phone;
        private string? password;
        private DateTime dateBirth;
        private string? usrPhoto;
        public static int baseId = 0;


        public string? Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(); }
        }
        public string? Phone
        {
            get { return phone; }
            set { phone = value; OnPropertyChanged(); }
        }
        public string? Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(); }
        }

        public DateTime DateBirth
        {
            get { return dateBirth; }
            set { dateBirth = value; OnPropertyChanged(); }
        }
        public string? UsrPhoto
        {
            get { return usrPhoto; }
            set { usrPhoto = value; OnPropertyChanged(); }
        }


        public string? Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        public string? UserName
        {
            get { return userName; }
            set { userName = value; OnPropertyChanged(); }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public User()
        {
            this.id = ++baseId;
        }

    }
}
