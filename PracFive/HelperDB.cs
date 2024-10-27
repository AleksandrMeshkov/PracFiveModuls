using PracFive.ModelsModifierDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracFive
{
    public class HelperDB
    {
        private static Security_AgencyEntities _context;

        public static Security_AgencyEntities GetContext()
        {
            if (_context == null)
            {
                _context = new Security_AgencyEntities();
            }
            return _context;
        }
    }
}
