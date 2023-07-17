using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GUI_Project.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GUI_Project.ViewModel
{
    public partial class CreateAdminVM : ObservableObject
    {
        //[ObservableProperty]
        //public string adminName;
        //[ObservableProperty]
        //public string adminPassword;
        //[ObservableProperty]
        //ObservableCollection<CreateAdmin> admins;

        //[RelayCommand]
        //public void CreateAdminF()
        //{
        //    CreateAdmin p = new CreateAdmin()
        //    {
        //        AdminName = adminName,
        //        AdminPassword = adminPassword,
                
        //    };
        //    using (var db = new DataBaseContext())
        //    {
        //        db.createAdmins.Add(p);
        //        db.SaveChanges();
        //    }
        //    LoadPerson();
            
        //}

        //public void AdminLogin()
        //{
        //    string username = "admin";
        //    string password = "2a1b";
        //    if (adminName ==  && adminPassword == password)
        //    {
        //        var adminmenu = new adminMenu();
        //        adminmenu.Show();

        //    }

        //}

        //public CreateAdminVM()
        //{

        //}

        //public void LoadPerson()
        //{
        //    using (var db = new DataBaseContext())
        //    {
        //        var list = db.createAdmins
        //            .OrderByDescending(p => p.id)
        //            .ToList();
        //        admins = new ObservableCollection<CreateAdmin>(list);
        //    }
        //}
       
        //public void CreateAdminVM()
        //{
        //    LoadPerson();
        //}
    }

    //public partial class CreateAdminVM : ObservableObject
    //{
    //    [ObservableProperty]
    //    public string? txtEmail;
    //    [ObservableProperty]
    //    public string? txtPassword;
    //    [ObservableProperty]
    //    ObservableCollection<AdminDetails> adminList;

    //    public DataBaseContext? context;



    //    [RelayCommand]
    //    public void CreateAdmin()
    //    {


    //        CreateAdmin tempAdmin = new CreateAdmin()
    //        {
    //            AdminName = txtEmail,
    //            AdminPassword = txtPassword,
    //            // right from mvvm


    //        };

    //        if (tempAdmin.AdminName != null && tempAdmin.AdminPassword != null)
    //        {
    //            using (var context = new DataBaseContext())
    //            {
    //                context.AdminDetails.Add(tempAdmin);
    //                context.SaveChanges();
    //                adminList.Add(tempAdmin);
    //                Load();
    //            }

    //        }


    //    }
    //    public void Load()
    //    {
    //        context = new DataBaseContext();
    //        var list = context.AdminDetails.ToList();
    //        adminList = new ObservableCollection<CreateAdmin>(list);
    //        OnPropertyChanged(nameof(adminList));


    //    }
    //    public CreateAdminVM()
    //    {
    //        Load();
    //    }
    //}

}
