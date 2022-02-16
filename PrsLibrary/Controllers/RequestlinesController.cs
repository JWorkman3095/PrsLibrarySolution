using Microsoft.EntityFrameworkCore;

using PrsLibrary.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsLibrary.Controllers {

    public class RequestlinesController {
        private readonly PrsDbContext _context;

        public RequestlinesController(PrsDbContext context) {
            this._context = context;
        }

        private void RecalculateRequestTotal(int requestId) {
            var request = _context.Requests.Find(requestId);

            request.Total = (from rl in _context.RequestLines // an alais for all request lines for all requests
                             join p in _context.Products  // joining to product
                             on rl.ProductId equals p.Id  // how we joined together
                             where rl.RequestId == requestId  // only want the ones tied to the particular request
                             select new { 
                                 LineTotal = rl.Quantity * p.Price // linetotal is the alias for each line item on the request
                             }).Sum(x => x.LineTotal); // wrap everthing in () to call sum method to tally up all line totals
            _context.SaveChanges();
        }

        public IEnumerable<Requestline> GetAll() {
            return _context.RequestLines
                                .Include(x => x.Product)
                                .Include(x => x.Request)
                                .ToList();
        }

        public Requestline GetByPk(int id) {
                return _context.RequestLines
                                .Include(x => x.Product)
                                .Include(x => x.Request)
                                .SingleOrDefault(x => x.Id == id);
        }

        public Requestline Create(Requestline requestline) {
            if (requestline is null) {
                throw new ArgumentNullException("Requestline");
            }
            if (requestline.Id != 0) {
                throw new ArgumentNullException("Requestline.Id must be zero!");
            }

            _context.RequestLines.Add(requestline); // puts it into the Ef cach (editing to make sure (above))
            _context.SaveChanges();
            RecalculateRequestTotal(requestline.RequestId);
            return requestline;
        }
        public void Change(Requestline requestline) {
            _context.SaveChanges();
            RecalculateRequestTotal(requestline.RequestId);
        }
        public void Remove(int id) {
            var requestline = _context.RequestLines.Find(id);
            if (requestline is null) {
                throw new Exception("Requestline not found!");
            }
            _context.RequestLines.Remove(requestline);
            _context.SaveChanges();
            RecalculateRequestTotal(requestline.RequestId);

        }
    }
}
