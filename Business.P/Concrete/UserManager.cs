using Business.P.Abstract;
using Business.P.Constants;
using Core.Utilities.Results;
using DataAccess.P.Abstract;
using Entities.P.Concrete;

namespace Business.P.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(Users user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(Users user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_userDal.GetAll(), Messages.UsersListed);
        }

        public IDataResult<Users> GetById(int userId)
        {
            return new SuccessDataResult<Users>(_userDal.Get(i => i.Id == userId));
        }

        public IResult Update(Users user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
