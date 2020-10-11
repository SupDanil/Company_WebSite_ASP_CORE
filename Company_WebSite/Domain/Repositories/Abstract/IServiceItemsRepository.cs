using Company_WebSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company_WebSite.Domain.Repositories.Abstract
{
   public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItem();
        ServiceItem GetErviceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
