using System.Collections.Generic;
using Core.Utilities.Results;
using Entities;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMakineService
    {
        IDataResult<Makine> GetById(int id);
        IDataResult<List<Makine>> GetAll();
        IResult Add(Makine makine);
        IResult Update(Makine makine);
        IResult Delete(Makine makine);
    }
}