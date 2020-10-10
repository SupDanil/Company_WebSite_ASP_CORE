using Company_WebSite.Domain.Entities;
using Company_WebSite.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Company_WebSite.Domain.Repositories.EntityFramework
{
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        private readonly AppDbContext context;
        public EFTextFieldsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteTextField(Guid Id)
        {
            throw new NotImplementedException();
        }

        public TextField GetTextFieldByCodeWord(string CodeWord)
        {
            return context.TextFields.FirstOrDefault(x => x.CodeWord == CodeWord);
        }

        public TextField GetTextFieldById(Guid Id)
        {
            return context.TextFields.FirstOrDefault(x => x.Id == Id);
        }

        public IQueryable<TextField> GetTextFields()
        {
            return context.TextFields;
        }

        public void SaveTextFields(TextField entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
