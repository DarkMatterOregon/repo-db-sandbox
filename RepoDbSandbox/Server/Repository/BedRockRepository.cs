using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using RepoDb;
using RepoDbSandbox.Shared.Models;


namespace Aka.Mods.Repository
{
    public class BedRockRepository : DbRepository<SqlConnection>, IConferenceRepository
    {

       
        public BedRockRepository(IConfiguration configurationManager) : base(
            configurationManager.GetConnectionString("BedRockConnection"))
        {
            int foo = 1;
        }

        public IEnumerable<Conference> GetConferences()
        {
            return QueryAll<Conference>();
        }

        public Conference GetConference(int confId)
        {
            return Query<Conference>(c=>c.ConfId==confId).SingleOrDefault();
        }

        public Conference AddConference(Conference conference)
        {
            throw new System.NotImplementedException();
        }

        public Conference UpdateConference(Conference conference)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteConference(int confId)
        {
            throw new System.NotImplementedException();
        }

       
    }
}
