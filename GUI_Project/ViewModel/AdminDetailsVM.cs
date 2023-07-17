//using CommunityToolkit.Mvvm.ComponentModel;
//using CommunityToolkit.Mvvm.Input;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GUI_Project.ViewModel
//{
//    public partial class AdminDetailsVM : ObservableObject
//    {
//        [ObservableProperty]
//        public string? txtEmail;
//        [ObservableProperty]
//        public string? txtPassword;
//        [ObservableProperty]
//        ObservableCollection<AdminDetails> adminList;

//        public DataBaseContext? context;



//        [RelayCommand]
//        public void CreateAdmin()
//        {


//            AdminDetails tempAdmin = new AdminDetails()
//            {
//                //AdminName = txtEmail,
//                //AdminPassword = txtPassword,
//                // right from mvvm


//            };

//            if (tempAdmin.AdminName != null && tempAdmin.AdminPassword != null)
//            {
//                using (var context = new DataBaseContext())
//                {
//                    context.AdminDetails.Add(tempAdmin);
//                    context.SaveChanges();
//                    adminList.Add(tempAdmin);
//                    Load();
//                }

//            }


//        }
//        public void Load()
//        {
//            context = new DataBaseContext();
//            var list = context.AdminDetails.ToList();
//            adminList = new ObservableCollection<AdminDetails>(list);
//            OnPropertyChanged(nameof(adminList));


//        }
//        public AdminDetailsVM()
//        {
//             Load();
//        }
//    }
//}
