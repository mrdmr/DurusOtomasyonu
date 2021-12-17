using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ArizaTurManager:IArizaTurService
    {
        private IArizaTurDal _arizaTurDal;

        public ArizaTurManager(IArizaTurDal arizaTurDal)
        {
            _arizaTurDal = arizaTurDal;
        }

        public IDataResult<ArizaTur> GetById(int arizaTurId)
        {
            return new SuccesDataResult<ArizaTur>(_arizaTurDal.Get(p => p.ArizaTurId == arizaTurId));
        }
    }
}