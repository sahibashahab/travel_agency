using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencySystem
{
   public interface AbstractVisitor
    {
         void visit(Employeewindow e);
        void visit(AdminWindow Aw);
        void visit(OwnerWindow Ow);


    }
}
