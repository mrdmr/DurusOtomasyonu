using System.Collections.Generic;
using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;

namespace Business.Concrete
{
    public class MakineManager:IMakineService
    {
        private IMakineDal _makineDal;

        public MakineManager(IMakineDal makineDal)
        {
            _makineDal = makineDal;
        }

        public IDataResult<Makine> GetById(int id)
        {
            return new SuccesDataResult<Makine>(_makineDal.Get(p=>p.MakineId==id));
        }

        public IDataResult<List<Makine>> GetAll()
        {
            return new SuccesDataResult<List<Makine>>(_makineDal.GetList());
        }

        public IResult Add(Makine makine)
        {
            _makineDal.Add(makine);
            return new SuccessResult(Messages.ArizaAdded);
        }

        public IResult Update(Makine makine)
        {
            _makineDal.Update(makine);
            return new SuccessResult(Messages.ArizaAdded);
        }

        public IResult Delete(Makine makine)
        {
            _makineDal.Delete(makine);
            return new SuccessResult(Messages.ArizaAdded);
        }
    }
}