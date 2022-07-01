using Business.P.Abstract;
using Business.P.Constants;
using Core.Utilities.Results;
using DataAccess.P.Abstract;
using Entities.P.Concrete;

namespace Business.P.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rentals rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentAdded);
        }

        public IResult Delete(Rentals rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentDeleted);
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_rentalDal.GetAll(), Messages.RentListed);
        }

        public IDataResult<Rentals> GetById(int rentId)
        {
            return new SuccessDataResult<Rentals>(_rentalDal.Get(i => i.Id == rentId));
        }

        public IResult Update(Rentals rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentUpdated);
        }
    }
}
