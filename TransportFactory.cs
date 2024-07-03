using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencySystem
{
    public  class TransportFactory
    {
        public Transport getTransport(String type)
        {
            if ("Airplane" == type)
            {
                return new Airplane();
            }
            else if("Train" == type)
            {
                return new Train();
            }
            else
            {
                return new Buss();
            }
        }

        public void Air()
        {

        }
    }
}
