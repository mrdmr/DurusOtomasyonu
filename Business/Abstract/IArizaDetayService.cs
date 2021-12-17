using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IArizaDetayService
    {
        IDataResult<ArizaDetay> GetById(int id);
        IDataResult<List<ArizaDetay>> GetAll();
        IResult Add(ArizaDetay arizaDetay);
        IResult Update(ArizaDetay arizaDetay);
        IResult Delete(ArizaDetay arizaDetay);
    }
}