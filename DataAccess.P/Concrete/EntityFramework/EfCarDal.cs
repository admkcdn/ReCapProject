using Core.DataAccess.EntitiesFramework;
using DataAccess.P.Abstract;
using Entities.P.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.P.Concrete.EntityFramework 
{
    public class EfCarDal : EfEntitiyRepositoryBase<Car, ReCapContext>, ICarDal
    
    {
        
    }
}
