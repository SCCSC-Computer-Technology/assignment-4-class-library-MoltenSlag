using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseQueryLibrary
{
    public class DataQuery
    {
        private StateDataClassesDataContext db;

        public DataQuery()
        {
            db = new StateDataClassesDataContext();
        }

        public IQueryable<string> GetStateNames()
        {
            /* This query generates an IQueryable object full of state names
             from the database and returns it. */

            IQueryable<string> results = from state in db.States
                                         select state.StateName;
            return results;
        }

        public State GetRowByState(string row)
        {
            /* This query finds a State object, representing an entire
             row of the table, based on the stateName. */
            var results = from state in db.States
                          where state.StateName == row
                          select state;
            return results.FirstOrDefault();
        }
    }
}
