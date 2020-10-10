using Company_WebSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company_WebSite.Domain.Repositories.Abstract
{
    interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItem();
        ServiceItem GetErviceItemById(Guid Id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid Id);
    }
}
