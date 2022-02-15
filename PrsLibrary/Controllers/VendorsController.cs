using PrsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsLibrary.Controllers {

    public class VendorsController {

        private readonly PrsDbContext _context;

        public VendorsController(PrsDbContext context) {
            this._context = context;
        }
        public IEnumerable<Vendor> GetAll() {
            return _context.Vendors.ToList();
        }
        //method to read by PK - returnthe instance or null
        public Vendor GetByPk(int id) {
            return _context.Vendors.Find(id);
        }
        public Vendor Create(Vendor vendor) {
            if (vendor is null) {
                throw new ArgumentNullException("vendor");
            }
            if (vendor.Id != 0) {
                throw new ArgumentNullException("Vendor.Id must be zero");
            }
            _context.Vendors.Add(vendor);
            _context.SaveChanges();
            return vendor;
        }
        public void Change(Vendor vendor) {
            _context.SaveChanges();
        }
    }
}
