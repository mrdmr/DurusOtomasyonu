using System.Collections.Generic;
using Core.DataAccess;
using Entities;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IArizaDal:IEntityRepository<Ariza>
    {
        List<Ariza> GetArizaForTable();
        ArizaForChart GetArizaChart();

    }
}