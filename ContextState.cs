using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencySystem
{
    class ContextState:AbstractState
    {
        AbstractState aState;
        public ContextState(AbstractState aState)
        {
            this.aState = aState;
        }
        public void setCustomerState(AbstractState aState)
        {
            this.aState = aState;
            
        }

        public override void req()
        {
            aState.req();
        }
    }
}
