using Core.Utilities.Results;
using Entities.P.Concrete;

namespace Business.P.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rentals rental);
        IResult Update(Rentals rental);
        IResult Delete(Rentals rental);
        IDataResult<List<Rentals>> GetAll();
        IDataResult<Rentals> GetById(int rentId);
    }
}
