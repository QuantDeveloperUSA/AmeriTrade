using System.Collections.Generic;
using System.Linq;


namespace AmeriTrade.API.Models
{
    public class AvailableQuotes
    {
        private readonly SortedSet<Markets> realtime = new SortedSet<Markets>();
        private readonly SortedSet<Markets> delayed = new SortedSet<Markets>();

        public List<Markets> All
        {
            get { return this.realtime.Union(this.delayed).ToList(); }
        }

        public List<Markets> RealTime
        {
            get { return this.realtime.ToList(); }
        }

        public List<Markets> Delayed
        {
            get { return this.delayed.ToList(); }
        }

        internal void Add(Markets market, bool isRealTime)
        {
            if (isRealTime)
            {
                this.realtime.Add(market);
            }
            else
            {
                this.delayed.Add(market);
            }
        }
    }
}
