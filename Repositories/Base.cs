using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
  public  class Base
    {
      private CandidateTrackerEntitiesModel _context = null;

      public CandidateTrackerEntitiesModel Context
        {
            get
            {
                if (_context == null)
                    _context = new CandidateTrackerEntitiesModel();
                return _context;
            }
        }
    

    }
}
