using System.Collections.Generic;
using Core.Entities;

#nullable disable

namespace Entities.Concrete
{
    public partial class Bolum : IEntity
    {
        public Bolum()
        {
            Makines = new HashSet<Makine>();
        }

        public int BolumId { get; set; }
        public string BolumAd { get; set; }

        public virtual ICollection<Makine> Makines { get; set; }
    }
}
