using JohannasBaksida.Areas.Identity.Data.Entities;
using JohannasBaksida.Areas.Identity.Data.Web;
using JohannasBaksida.Data;
using JohannasBaksida.Infrastructure.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace JohannasBaksida.Infrastructure.Concrete
{
    public class PurchaseManager : IPurchaseManager
    {
        private readonly JohannasBaksidaContext _context;

        public PurchaseManager()
        {
        }

        public PurchaseManager(JohannasBaksidaContext context) => _context = context;


        //public void CreatePurchase(Purchase purchase)
        //{
        //    using (var db = new JohannasBaksidaContext(@"Server=(localdb)\mssqllocaldb; Database = JohannasBaksidaDB"))
        //    {
        //        db.Add(purchase);
        //        db.SaveChanges();
        //    }
        //}

        public void Post(Purchase purchase)
        {
            
            _context.Purchases.Add(purchase);
            //using (var db = _context) ;
            _context.SaveChanges();
        }

        public void Edit(EditPurchaseDTO purchase)
        {
            var foundPurchase = _context.Purchases.Where(x => x.Id == purchase.Id).FirstOrDefault();
            if (foundPurchase != null)
            {
                foundPurchase.Name = purchase.Name;
                foundPurchase.Price = purchase.Price;
                foundPurchase.Date = purchase.Date;

                _context.SaveChanges();
            }
        }
    }
}
