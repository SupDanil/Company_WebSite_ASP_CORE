using Company_WebSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company_WebSite.Domain.Repositories.Abstract
{
    interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid Id);
        TextField GetTextFieldByCodeWord(string CodeWord);
        void SaveTextFields(TextField entity);
        void DeleteTextField(Guid Id);
    }
}
