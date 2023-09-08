using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class ProductOwner : IProductOwnerActivities, IWorkTeamActivities
    {
        public void Comunicate()
        {
            throw new NotImplementedException();
        }

        public void Plan()
        {
            throw new NotImplementedException();
        }

        void IProductOwnerActivities.ProductDesign()
        {
            throw new NotImplementedException();
        }

        void IProductOwnerActivities.RequirementsAssignement()
        {
            throw new NotImplementedException();
        }
    }
}