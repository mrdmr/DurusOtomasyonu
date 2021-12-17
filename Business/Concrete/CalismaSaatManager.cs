using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CalismaSaatManager:ICalismaSaatService
    {
        public IDataResult<CalismaSaat> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<CalismaSaat>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IResult Add(CalismaSaat calismaSaat)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(CalismaSaat calismaSaat)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(CalismaSaat calismaSaat)
        {
            throw new System.NotImplementedException();
        }
    }
}