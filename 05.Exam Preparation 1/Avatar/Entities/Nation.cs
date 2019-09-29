	using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatar.Entities
{
    public class Nation
    {
        private List<Bender> benders;
        private List<Monument> monuments;

        public Nation()
        {
            this.benders = new List<Bender>();
            this.monuments = new List<Monument>();
        }

        public void AddBender(Bender bender)
        {
            this.benders.Add(bender);
        }

        public void AddMonument(Monument monument)
        {
            this.monuments.Add(monument);
        }
    }
}
