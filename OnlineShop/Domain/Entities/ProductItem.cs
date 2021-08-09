using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entities
{
    public class ProductItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните название продукта")]
        [Display(Name = "Название продукта")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание продукта")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание продукта")]
        public override string Text { get; set; }
    }
}
