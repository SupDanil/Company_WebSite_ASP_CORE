using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Company_WebSite.Domain.Entities
{
    public abstract class EntityBase // Базовый класс для наших сущьностей
    {
        protected EntityBase() => DataAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }

        [Display(Name="Название (заголовок)")]
        public virtual string Title { get; set; }

        [Display(Name = "Кратко описание")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Полное описание")]
        public virtual string Text { get; set; }

        [Display(Name = "Титульная картинка")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO метатег Title")]
        public  string MetaTitle { get; set; }

        [Display(Name = "SEO метатег Discription")]
        public  string MetaDiscription { get; set; }

        [Display(Name = "SEO метатег MetaKeywords")]
        public  string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DataAdded { get; set; }


    }
}
