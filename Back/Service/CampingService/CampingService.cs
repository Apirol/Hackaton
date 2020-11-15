using System;
using System.Collections.Generic;
using System.Text;
using Data.DB;
using Data.Models;
using System.Linq;

namespace Service.CampingService
{
    public class CampingService : ICampingService
    {
        private readonly DB db;

        public CampingService() { }
        public CampingService(DB db)
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
            var campings = db.Camping.ToList();
            campings.ForEach(x => x.location = GetLocation(x.Id));
            campings.ForEach(x => x.facilities = GetFacilities(x.Id));
            return campings;
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

        private Location GetLocation(Guid id)
        {
            return db.Location.ToList().Find(x => x.Id == id);
        }

        private Facilities GetFacilities(Guid id)
        {
            return db.Facilities.ToList().Find(x => x.Id == id);
        }
    }
}
