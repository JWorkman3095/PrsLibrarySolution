using PrsLibrary.Controllers;
using PrsLibrary.Models;
using System;
using System.Linq;

namespace TestPrsLibrary {

    class Program {

        static void Print(Requestlines product) {
            Console.WriteLine($"{product.Id,-5} {product.PartNbr,-12} {product.Name,-12} {product.Price,10:c} {product.Vendor.Name,-15}");
        }

        static void Main(string[] args) {


            var context = new PrsDbContext();

            var userCtrl1 = new UsersController(context);

            var user = userCtrl1.Login("sa", "sa");
            if(user is null) {
                Console.WriteLine("User Not Found");

            }else {
                Console.WriteLine(user.UserName);
            }

            //var username = "gdoud";
            //var password = "password";
            //context.Users.SingleOrDefault(x => x.Username == username && x.Password == password);
            ////where claus brings back a collection

            //var user = from u in context.Users
            //        where u.UserName == username && u.Password == passwordselect u;

            //var context = new PrsDbContext();

            //var prodCtrl = new ProductsController(context);
            //var products = prodCtrl.GetAll();

            //foreach(var p in products) {
            //    Print(p);
            //}

            //var product = prodCtrl.GetByPk(2);
            //if (product is not null) {
            //    Print(product);
            //}



            //var userCtrl = new UsersController(context);
            //var vendorCtrl = new VendorsController(context);

            //var newUser = new User() {
            //    Id = 0, UserName = "zz", Password = "xx",
            //    Firstname = "User", Lastname = "zz",
            //    Phone = "211", Email = "xx@user.com",
            //    IsReviewer = false, IsAdmin = false
            //};

            //var newVendor = new Vendor() {
            //    Id = 0, Code = "MS3", Name = "Guitar Center",
            //    Address = "43 West Kemper", City = "Cincinnati",
            //    State = "OH", Zip = "45246", Phone = "513-671-4502",
            //    Email = "Dbags@GC.com"
            //};

            ////userCtrl.Create(newUser);
            ////vendorCtrl.Create(newVendor);

            //var user3 = userCtrl.GetByPk(3);
            //if (user3 is null) {
            //    Console.WriteLine("User not found!");
            //} else {
            //    Console.WriteLine($"User3: {user3.Firstname} {user3.Lastname}");
            //}
            //user3.Lastname = "User3";
            //userCtrl.Change(user3);

            //////Vendor
            ////var vendor3 = vendorCtrl.GetByPk(3);
            ////if (vendor3 is null) {
            ////    Console.WriteLine("Vendor not found!");
            ////} else {
            ////    Console.WriteLine($"Vendor3: {vendor3.Name} {vendor3.Zip}");
            ////}
            ////vendor3.Name = "Vendor3";
            ////vendorCtrl.Change(vendor3);

            //////vendor

            ////var user33 = userCtrl.GetByPk(33);
            ////if (user33 is null) {
            ////    Console.WriteLine("User not found!");
            ////} else {
            ////    Console.WriteLine($"User33: {user33.Firstname} {user33.Lastname}");
            ////}

            ////userCtrl.Remove(8);
            ////vendorCtrl.Remove(3);

            //var users = userCtrl.GetAll();           
            //foreach (var user in users) {
            //    Console.WriteLine($"{user.Id} {user.Firstname} {user.Lastname}");
            //}
            //    Console.WriteLine($" ");

            //var vendors = vendorCtrl.GetAll();
            //foreach (var vendor in vendors) {
            //    Console.WriteLine($"{vendor.Id} {vendor.Name} {vendor.Phone}");
            //}

        }
    }
}
