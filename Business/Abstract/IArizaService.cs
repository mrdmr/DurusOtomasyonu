using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IArizaService
    {
        IDataResult<List<Ariza>> GetForTable();
        IDataResult<Ariza> GetById(int arizaId);
        IDataResult<List<Ariza>> GetList();
        IResult Add(Ariza ariza);
        IResult Update(Ariza ariza);
        IResult Delete(Ariza ariza);
        IDataResult<ArizaForChart> GetArizaChart();
    }
}