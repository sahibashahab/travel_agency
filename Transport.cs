using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencySystem
{
    abstract public class   Transport
    {
        public abstract string UpdateTransportInfo();
        public abstract string createTransportInfo();
        public abstract void DeleteTransportInfo(int a);
    }
}
