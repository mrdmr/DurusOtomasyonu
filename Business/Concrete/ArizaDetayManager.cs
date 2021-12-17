using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class ArizaDetayManager:IArizaService
    {
        public IDataResult<List<Ariza>> GetForTable()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Ariza> GetById(int arizaId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Ariza>> GetList()
        {
            throw new System.NotImplementedException();
        }

        public IResult Add(Ariza ariza)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Ariza ariza)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Ariza ariza)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<ArizaForChart> GetArizaChart()
        {
            throw new System.NotImplementedException();
        }
    }
}