using PrsLibrary.Controllers;
using PrsLibrary.Models;

using System;
using System.Linq;

namespace TestPrsLibrary {

    class Program {

        //static void Print(Product product) {
        //    Console.WriteLine($"{product.Id,-5} {product.PartNbr,-12} {product.Name,-12} {product.Price,10:c} {product.Vendor.Name,-15}");
        //}

        static void Main(string[] args) {


            var context = new PrsDbContext();

            var reqlCtrl = new RequestlinesController(context);

            //var reql = reqlCtrl.GetByPk(1);
            //reql.Quantity = 1;
            //reqlCtrl.Change(reql);

            //var reqCtrl = new RequestsController(context);

            //var reqs = reqCtrl.GetRequestsInReview(3);

            //foreach(var req in reqs) {
            //    Console.WriteLine($"{req.Description} {req.Status} {req.Total} {req.UserId}");
            //}

            //var reqs = reqCtrl.GetByPk(1);

            //reqCtrl.SetReview(req);
            //reqCtrl.SetRejected(req);
            //reqCtrl.SetApproved(req);

            //req = reqCtrl.GetByPk(1);

            //Console.WriteLine($"{req.Description} {req.Status} {req.Total}");




            ////Looking for  User Sa, Sa or a Null user
            var userCtrl = new UsersController(context);

            //var user = userCtrl.Login("sa", "sa");
            //if (user is null) {
            //    Console.WriteLine("User Not Found");
            //} else {
            //    Console.WriteLine(user.UserName);
            //}




           // var username = "gdoud";
           // var password = "password";
           // context.Users.SingleOrDefault(x => x.UserName == username && x.Password == password);
           // SingleOrDefault instead of a where claus which brings back a collection

           //var user = from u in context.Users
           //           where u.UserName == username && u.Password == password
           //           select u;


            //here for comparing GO

            //var reqlCtrl = new RequestlinesController(context);



            //// Returning att Product
            //var requestlines = reqlCtrl.GetAll();

            //foreach (var rl in requestlines) {
            //    Console.WriteLine($" {rl.Id} {rl.Request.Description} {rl.Product.Name}");
            //}

            //var prodCtrl = new ProductsController(context);

            //var products = prodCtrl.GetAll();

            //foreach (var p in products) {
            //    Print(p);
            //}

            //var product = prodCtrl.GetByPk(2);

            //if (product is not null) {
            //    Print(product);
            //}



            ////Create New User
            //var userCtrl = new UsersController(context);

            //var newUser = new User() {
            //    Id = 0, UserName = "BHunter", Password = "bh",
            //    Firstname = "Bobby", Lastname = "Hunter",
            //    Phone = "513-476-9865", Email = "bhunter@user.com",
            //    IsReviewer = false, IsAdmin = false
            //};
            //userCtrl.Create(newUser);

            ////Create New Vendor
            //var vendorCtrl = new VendorsController(context);

            //var newVendor = new Vendor() {
            //    Id = 0, Code = "MS5", Name = "The Music Shoppe",
            //    Address = "175 Harrison Ave.", City = "Harrison",
            //    State = "OH", Zip = "45207", Phone = "513-671-4503",
            //    Email = "Brian@musicshoppe.com"
            //};
            //vendorCtrl.Create(newVendor);


            //Get User by PK
            //var user3 = userCtrl.GetByPk(3);
            //if (user3 is null) {
            //    Console.WriteLine("User not found!");
            //} else {
            //    Console.WriteLine($"User3: {user3.Firstname} {user3.Lastname}");
            //}
            //user3.Lastname = "User3";
            //userCtrl.Change(user3);

            //Vendor
            //var vendor1 = vendorCtrl.GetByPk(1);
            //if (vendor1 is null) {
            //    Console.WriteLine("Vendor not found!");
            //} else {
            //    Console.WriteLine($"Vendor1: {vendor1.Name} {vendor1.Zip}");
            //}
            //vendor1.Name = "Vendor1";
            //vendorCtrl.Change(vendor1);

            //user33 - there is no user 33
            //var user33 = userCtrl.GetByPk(33);
            //if (user33 is null) {
            //    Console.WriteLine("User not found!");
            //} else {
            //    Console.WriteLine($"User33: {user33.Firstname} {user33.Lastname}");
            //}

            //userCtrl.Remove(8);
            //vendorCtrl.Remove(3);

            var users = userCtrl.GetAll();
            foreach (var user in users) {
                Console.WriteLine($"{user.Id} {user.Firstname} {user.Lastname}");
            }
            Console.WriteLine($" "); // only for space between these two cw's

            //var vendors = vendorCtrl.GetAll();
            //foreach (var vendor in vendors) {
            //    Console.WriteLine($"{vendor.Id} {vendor.Name,-20} {vendor.Phone}");
            //}

        }
    }
}
