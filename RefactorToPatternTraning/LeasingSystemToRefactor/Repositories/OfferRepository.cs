using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor.Repositories
{
    public class OfferRepository : BaseRepository<Offer>
    {
        public List<Offer> GetActive()
        {
            return ObjectDbContext.Offers.Where(x => x.IsActive && x.IsCompleted).ToList();
        }

        public override void Add(Offer item)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Offer> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Offer GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
