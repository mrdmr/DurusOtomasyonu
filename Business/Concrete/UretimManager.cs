using System.Collections.Generic;
using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class UretimManager:IUretimService
    {
        private IUretimDal _uretimDal;

        public UretimManager(IUretimDal uretimDal)
        {
            _uretimDal = uretimDal;
        }

        public IDataResult<List<UretimForTable>> GetUretimForTable()
        {
            return new SuccesDataResult<List<UretimForTable>>(_uretimDal.GetUretimForTable());
        }

        public IDataResult<Uretim> GetById(int id)
        {
            return new SuccesDataResult<Uretim>(_uretimDal.Get(u => u.UretimId == id));
        }

        public IDataResult<List<Uretim>> GetAll()
        {
            return new SuccesDataResult<List<Uretim>>(_uretimDal.GetList());
        }

        public IResult Add(Uretim uretim)
        {
            _uretimDal.Add(uretim);
            return new SuccessResult(Messages.ArizaAdded);
        }

        public IResult Update(Uretim uretim)
        {
            _uretimDal.Update(uretim);
            return new SuccessResult(Messages.ArizaAdded);
        }

        public IResult Delete(Uretim uretim)
        {
            _uretimDal.Delete(uretim);
            return new SuccessResult(Messages.ArizaAdded);
        }
    }
}