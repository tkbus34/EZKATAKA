using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MollaevYaroshevski.DataFolder
{
    public partial class DBEnities : DbContext
    {
        private static DBEnities context;
        
        public static DBEnities GetContext()
        {
            if (context == null)
                context = new DBEnities();
            return context;
        }

    }
}
