using Business.Abstarct;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserOperationManager : IUserOperationService
    {
        private readonly IUserOperationDal _userOperationDal;
public UserOperationManager(IUserOperationDal userOperationDal)
        {
            _userOperationDal = userOperationDal;
        }

        public void Add(UserOperationClaims userOperationClaims)
        {
            _userOperationDal.Add(userOperationClaims);
        }
    }
}
