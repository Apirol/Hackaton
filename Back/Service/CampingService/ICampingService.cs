using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;

namespace Service.CampingService
{
    public interface ICampingService
    {
        void AddCamping(Camping camping);
        void DeleteCamping(Guid id);

        Camping GetOneCamping(Guid id);
        List<Camping> SearchCampings();
        List<Camping> GetAllCampings();
        List<Camping> GetCampingsByOwner(string owner);
    }
}
