using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class ArizaManager:IArizaService
    {
        private IArizaDal _arizaDal;

        public ArizaManager(IArizaDal arizaDal)
        {
            _arizaDal = arizaDal;

        }

        public IDataResult<List<Ariza>> GetForTable()
        {
            return new SuccesDataResult<List<Ariza>>(_arizaDal.GetArizaForTable());
        }

        public IDataResult<Ariza> GetById(int arizaId)
        {
            return new SuccesDataResult<Ariza>(_arizaDal.Get(p => p.ArizaId == arizaId));

        }

        public IDataResult<List<Ariza>> GetList()
        {
            return new SuccesDataResult<List<Ariza>>(_arizaDal.GetList());
        }


        public IResult Add(Ariza ariza)
        {
            _arizaDal.Add(ariza);
            return new SuccessResult(Messages.ArizaAdded);
        }

        public IResult Update(Ariza ariza)
        {
            _arizaDal.Update(ariza);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        public IResult Delete(Ariza ariza)
        {
            _arizaDal.Delete(ariza);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IDataResult<ArizaForChart> GetArizaChart()
        {
            return new SuccesDataResult<ArizaForChart>(_arizaDal.GetArizaChart());


        }
    }
}