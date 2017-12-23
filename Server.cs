using First_appl_MVVM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebGymnasticApp
{
    public class Server
    {
        Repository _repository = new Repository();
        List<Competition> _competitions;
        List<Gymnast> _gymnasts;
        List<Competitor> _competitors;
        
        //Competition methods
        public List<Competition> GetCompetitions()
        {
            _competitions = _repository.GetCompetitions().ToList();
            return _competitions;
        }

        public void Addcompetition([FromBody]Competition value)
        {
            _repository.AddCompetition(value);
        }
        public void DeleteCompetition(int competitionId)
        {
            _repository.RemoveCompetition(competitionId);
            _repository.RemoveCompetitor(competitionId);
        }

        //Competitors method
        public List<Competitor> GetCompetitors(int idCompetition)
        {
            return _repository.GetCompetitors(idCompetition);
        }

        public void AddCompetitor(int idGymnast, int idCompetition)
        {
            _repository.AddCompetitor(idGymnast, idCompetition);
        }

        //Gymnast method
        public List<Gymnast> GetGymnasts(int idCompetition)
        {
            _competitors = GetCompetitors(idCompetition);
            _gymnasts = _repository.GetGymnasts(_competitors);
            return _gymnasts;
        }

        public void AddGymnast(Gymnast newGymnast, int idCompetition)
        {
            int idNewGymnast;
            idNewGymnast = _repository.AddGymnast(newGymnast);
            _repository.AddCompetitor(idCompetition, idNewGymnast);
        }

        public void DeleteCompetitor(int id, int idCompetition)
        {
            _repository.RemoveCompetitor(id, idCompetition);
        }

        //Rating method
        public List<Rating> GetRatings(int idCompetition, string discipline)
        {
            return _repository.GetDisciplineRatings(discipline, idCompetition);
        }
    }
}