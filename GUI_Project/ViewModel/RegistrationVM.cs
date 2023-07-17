//using CommunityToolkit.Mvvm.ComponentModel;
//using CommunityToolkit.Mvvm.Input;
//using GUI_Project.Model;
//using Microsoft.Windows.Themes;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GUI_Project.ViewModel 
//{
//    public partial class RegistraionVM : ObservableObject
//    {
//        [ObservableProperty]
//        // [NotifyPropertyChangedFor(nameof(Name1))]
//        public string? name;
//        [ObservableProperty]
//        public string? address;
//        [ObservableProperty]
//        public bool sex;
//        [ObservableProperty]
//        public int dOB;
//        [ObservableProperty]
//        public int mobileNo;
//        [ObservableProperty]
//        public bool memberShip;
//        [ObservableProperty]
//        ObservableCollection<Registration>? registrations;
        

//        [RelayCommand]
//        public void registraionF()
//        {
//            Registration p = new Registration();
//            {
//                //Name = name;
//                //Address = address;
//                //Sex = sex;
//                //DOB = dOB;
//                //MobileNo = mobileNo;
//                //memberShip = memberShip;


//            };
//            using (var db = new DataBaseContext())
//            {
//                db.registrations.Add(p);
//                db.SaveChanges();
//            }
//            LoadPerson();

//        }
        
//        // The Error occured 

//        //public  string Name1
//        //{
//        //    get{ return $"{Name}"; } 
//        //}

//        public RegistraionVM()
//        {

//        }

//        public void LoadPerson()
//        {
//            using (var db = new DataBaseContext())
//            {
//                var list = db.registrations
//                    .OrderByDescending(p => p.id)
//                    .ToList();
//                registrations = new ObservableCollection<Registration>(list);
//            }
//        }
//    }

    
//}
