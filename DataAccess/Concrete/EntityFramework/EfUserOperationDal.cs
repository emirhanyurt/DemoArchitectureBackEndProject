﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserOperationDal : EfEntityRepositoryBase<UserOperationClaims,SimpleDbContext> , IUserOperationDal
    {
    }
}
