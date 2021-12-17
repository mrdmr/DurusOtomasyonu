using System.Collections.Generic;
using Core.Entities;

#nullable disable

namespace Entities.Concrete
{
    public partial class Makine:IEntity
    {
        public Makine()
        {
            Arizas = new HashSet<Ariza>();
        }

        public int MakineId { get; set; }
        public string Name { get; set; }
        public int? PersonelId { get; set; }
        public int? BolumId { get; set; }
        public string Serial { get; set; }

        public virtual Bolum Bolum { get; set; }
        public virtual Personel Personel { get; set; }
        public virtual ICollection<Ariza> Arizas { get; set; }
    }
}
