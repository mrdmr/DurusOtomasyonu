using System.Collections.Generic;
using Core.Entities;


namespace Entities.Concrete
{
    public class ArizaDetay : IEntity
    {
        public ArizaDetay()
        {
            Arizas = new HashSet<Ariza>();
        }

        public int ArizaDetayId { get; set; }
        public string Detay { get; set; }
        public int? ArizaTurId { get; set; }

        public virtual ArizaTur ArizaTur { get; set; }

        public virtual ICollection<Ariza> Arizas { get; set; }
        public virtual ICollection<ArizaDetay> ArizaDetays { get; set; }
    }
}
