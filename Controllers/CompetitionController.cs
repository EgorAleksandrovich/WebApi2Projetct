using First_appl_MVVM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebGymnasticApp.Controllers
{
    public class CompetitionController : ApiController
    {
        Server _server = new Server();

        [HttpGet]
        public IEnumerable<Competition> Get()
        {
            return _server.GetCompetitions();
        }
        public List<Gymnast> GetCompetitors(int id)
        {
            return _server.GetGymnasts(id);
        }

        [HttpPost]
        public void Addcompetition(Competition newCompetition)
        {
            if (newCompetition.Country == null || newCompetition.CompetitionName == null)
            {
                throw new ArgumentNullException("Pleas fill in information about competition!");
            }
            _server.Addcompetition(newCompetition);
        }

        [HttpDelete]
        public void DeleteCompetition(int id)
        {
            _server.DeleteCompetition(id);
        }
    }
}
