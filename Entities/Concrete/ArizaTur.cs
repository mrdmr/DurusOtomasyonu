using System.Collections.Generic;
using Core.Entities;

#nullable disable

namespace Entities.Concrete
{
    public partial class ArizaTur : IEntity
    {
        public ArizaTur()
        {
            Arizas = new HashSet<Ariza>();
        }

        public int ArizaTurId { get; set; }
        public string ArizaAd { get; set; }

        public virtual ICollection<Ariza> Arizas { get; set; }
    }
}
