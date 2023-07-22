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
    public class OperationClaimsManager : IOperationClaimsService
    {
        private readonly IOperationClaimDal _operationClaimDal;

        public OperationClaimsManager(IOperationClaimDal operationClaimDal)
        {
            _operationClaimDal = operationClaimDal;
        }

        public void Add(OperationClaims operationClaims)
        {
            _operationClaimDal.Add(operationClaims);
        }
    }
}
