using AutoMapper;
using Business.Abstract;
using DataAccess.Context;
using DataAccess.Entity;
using DTO.DTOEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderCardService : BaseService<OrderCardDTO, OrderCard, OrderCardDTO>, IOrderCardService
    {
        public OrderCardService(IMapper mapper, AppDbContext appDbContext) : base(mapper, appDbContext)
        {
        }
    }
}
