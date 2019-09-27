using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    class GeographicalUnit
    {
        private String country { get; set; }
        private String capital { get; set; }
        private int population { get; set; }
        public enum formOfGov { US, F }
        private formOfGov form { get; set; }
        public GeographicalUnit(string country, string capital, int population, formOfGov form)
        {
            this.country = country;
            this.capital = capital;
            this.population = population;
            this.form = form;
        }

        public GeographicalUnit()
        {
        }

        public String getInfoTable()
        {
            String output = String.Format("|{0}|{1}|{2}|{3}|", this.country, this.capital, this.population, this.form);
            return output;
        }

    }
}
