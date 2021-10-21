using JohannasBaksida.Areas.Identity.Data.Entities;
using JohannasBaksida.Areas.Identity.Data.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohannasBaksida.Infrastructure.Abstract
{
   public interface IPurchaseManager
    {
         void Post(Purchase purchase);
        void Edit(EditPurchaseDTO purchase);
    }
}
