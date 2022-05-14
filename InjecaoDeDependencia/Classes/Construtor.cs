using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDeDependencia.Classes
{
    public interface IDbconect
    {
        dynamic GetData();
    }

    public class XDatabase : IDbconect
    {
        public dynamic GetData()
        {
            return new { name = "XDatabase" };
        }
    }

    public class YDatabase : IDbconect
    {
        public dynamic GetData()
        {
            return new { name = "YDatabase" };
        }
    }

    public class DbOperation
    {
        private IDbconect _dbconect;

        public DbOperation(IDbconect dbconect)
        {
            _dbconect = dbconect;
        }

        public dynamic GetData()
        {
            return _dbconect.GetData();
        }
    }
}
