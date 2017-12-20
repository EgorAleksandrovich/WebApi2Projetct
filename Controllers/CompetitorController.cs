using First_appl_MVVM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebGymnasticApp.Controllers
{
    public class CompetitorController : ApiController
    {
        Server _server = new Server();

        [HttpGet]
        public List<Gymnast> GetCompetitors(int id)
        {
            return _server.GetGymnasts(id);
        }

        [HttpPost]
        public void AddCompetitor(int id, Gymnast newGymnastInf)
        {
            if(newGymnastInf.Country == null || newGymnastInf.FirstName == null || newGymnastInf.LastName == null)
            {
                throw new ArgumentNullException("Please specify mandatory fields(FirstName, LastName, Country, idCompetition!");
            }
            else
            {
                _server.AddGymnast(newGymnastInf, id);
            }
        }
        
        [Route("api/competition/{competitionId}/{controller}/{id}")]
        [HttpDelete]
        public void DeleteCompetitor(int competitionId, int id)
        {
            _server.DeleteCompetitor(id, competitionId);
        }
    }
}
