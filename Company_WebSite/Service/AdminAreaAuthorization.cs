using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Authorization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Company_WebSite.Service
{
    public class AdminAreaAuthorization : IControllerModelConvention
    {
        private readonly string area;
        private readonly string policy;

        public AdminAreaAuthorization(string area,string policy)
        {
            this.area = area;
            this.policy = policy;
        }
        public void Apply(ControllerModel controller)
        {
            if (controller.Attributes.Any(a => 
                   a is AreaAttribute && (a as AreaAttribute).RouteValue.Equals(area, StringComparison.OrdinalIgnoreCase))
                || controller.RouteValues.Any(r => 
                   r.Key.Equals("area", StringComparison.OrdinalIgnoreCase) && r.Value.Equals(area, StringComparison.OrdinalIgnoreCase)))
            {
                controller.Filters.Add(new AuthorizeFilter(policy));
            }
        }
    }
}
