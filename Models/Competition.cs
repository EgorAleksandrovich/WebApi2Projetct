
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_appl_MVVM.Data
{
    public class Competition
    {
        private DateTime _dateCompetition = DateTime.Now;
        public string CompetitionName { get; set; }
        public int Id { get; set; }
        public string Country { get; set; }
        public DateTime DateCompetition
        {
            get
            {
                return _dateCompetition;
            }
            set
            {
                _dateCompetition = value;
            }
        }
    }
}