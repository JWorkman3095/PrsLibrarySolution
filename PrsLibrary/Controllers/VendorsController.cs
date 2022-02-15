using PrsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsLibrary.Controllers {

    public class VendorsController {
        //defining _context
        private readonly PrsDbContext _context;
        //constructor
        public VendorsController(PrsDbContext context) {
            this._context = context;
        }
        //this method is going to returns (a collection) all vendors (no void)
        public IEnumerable<Vendor> GetAll() {
            return _context.Vendors.ToList();
        }
        //method to read by PK - return the instance of vendor or null
        // in real world you would want to make sure what returns is vaild
        public Vendor GetByPk(int id) {
            return _context.Vendors.Find(id);
        }
        //passes up all the vendor instance adding it to the dB
        public Vendor Create(Vendor vendor) {
            if (vendor is null) {
                throw new ArgumentNullException("vendor");
            }
            if (vendor.Id != 0) {
                throw new ArgumentNullException("Vendor.Id must be zero");
            }
            _context.Vendors.Add(vendor); // puts it into the Ef cach (editing to make sure (above))
            _context.SaveChanges();
            return vendor;
        }
        public void Change(Vendor vendor) {
            _context.SaveChanges();
        }
        public void Remove(int id) {
            var vendor = _context.Vendors.Find(id);
            if (vendor is null) {
                throw new Exception("User not found!");
            }
            _context.Vendors.Remove(vendor);
            _context.SaveChanges();

        }
    }
}
