using System;
using Core.Entities;

#nullable disable

namespace Entities.Concrete
{
    public class CalismaSaat : IEntity
    {
        public int CalismaSaatId { get; set; }
        public int? PersonelId { get; set; }
        public DateTime? BaslangicSaati { get; set; }
        public DateTime? BitisSaati { get; set; }
    }
}
