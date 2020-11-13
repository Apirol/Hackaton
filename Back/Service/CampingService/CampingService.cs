using System;
using System.Collections.Generic;
using System.Text;
using Data.DB;
using Data.Models;
using System.Linq;

namespace Service.CampingService
{
    public class CampingService :ICampingService
    {
        private readonly DB db;

        CampingService(DB db)
        {
            this.db = db;
        }

        public void AddCamping(Camping camping)
        {
            db.Camping.Add(camping);
            db.SaveChanges();
        }

        public void DeleteCamping(Camping camping)
        {
            db.Camping.Remove(camping);
        }

        public List<Camping> GetAllCampings()
        {
            return db.Camping.ToList();
        }

        public Camping GetOneCamping(Guid id)
        {
            return db.Camping.ToList().Find(x => x.Id == id);
        }

        public List<Camping> SearchCampings()
        {
            throw new NotImplementedException();
        }

        public List<Camping> GetCampingsByOwner(string owner)
        {
            return db.Camping.Where(x => x.Owner == owner).ToList();
        }

  
    }
}
