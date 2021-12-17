using System.Collections.Generic;
using Core.Entities;

#nullable disable

namespace Entities.Concrete
{
    public partial class Personel : IEntity
    {
        public Personel()
        {
            Arizas = new HashSet<Ariza>();
            Makines = new HashSet<Makine>();
        }

        public int PersonelId { get; set; }
        public string Ad { get; set; }
        public decimal? Verimlilik { get; set; }
        public bool? CalismaDurum { get; set; }

        public virtual ICollection<Ariza> Arizas { get; set; }
        public virtual ICollection<Makine> Makines { get; set; }
    }
}
