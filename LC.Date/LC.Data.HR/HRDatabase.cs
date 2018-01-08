using LC.Date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC.Data.HR
{
    public class HRDatabase : BaseDatabase, IDatabase
    {
        public string DefaultDbName => "zupo-hr";

        public string WriteDbName => "zupo-hr";

        public string ReadDbName => "zupo-hr";
        public string ConnString
        {
            get
            {
                if (string.IsNullOrEmpty(this._connString))
                {
                    string filename = $"{DefaultDbName}Settings.txt";
                    base.LoadConnString(filename);
                    if (string.IsNullOrEmpty(this._connString)) { this._connString = "data source=DESKTOP-D51E9P0;initial catalog=zupo-hr;persist security info=True;user id=sa;password=l88888888;"; }
                }
                return _connString;
            }
        }

        public string MappingsAssembly => "LC.Data.HR";

        public string DataContextName => "LC.Data.HR";
    }
}
