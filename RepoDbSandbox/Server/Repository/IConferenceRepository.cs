using System.Collections.Generic;
using RepoDbSandbox.Shared.Models;

namespace Aka.Mods.Repository
{
    public interface IConferenceRepository
    {
        IEnumerable<Conference> GetConferences();
        Conference GetConference(int confId);
        Conference AddConference(Conference conference);
        Conference UpdateConference(Conference conference);
        void DeleteConference(int confId);
    }
}
