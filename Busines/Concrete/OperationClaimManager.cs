using Busines.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Concrete
{
    public class OperationClaimManager : IOperationClaimService
    {
        private readonly IOperationClaimService _operationClaimService;

        public OperationClaimManager(IOperationClaimService operationClaimService)
        {
            _operationClaimService = operationClaimService;
        }

        public void Add(OperationClaims operationClaims)
        {
            _operationClaimService.Add(operationClaims);
        }
    }
}
