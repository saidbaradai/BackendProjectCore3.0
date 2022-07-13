﻿using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext())
            {
                var result = from operationClaim in context.operationClaims
                join userOperationClaim in context.userOperationClaims
                on operationClaim.Id equals userOperationClaim.OperationClaimID
                where userOperationClaim.Id == user.Id
                select new OperationClaim {Id= operationClaim.Id, Name= operationClaim.Name};

                return result.ToList();
            }
        }
    }
}
