using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDeDependencia.Classes
{
    public interface IDbconectSeG
    {
        dynamic GetData();
    }

    public class ODatabase : IDbconectSeG
    {
        public dynamic GetData()
        {
            return new { name = "ODatabase" };
        }
    }

    public class VDatabase : IDbconectSeG
    {
        public dynamic GetData()
        {
            return new { name = "VDatabase" };
        }
    }

    public class DbOperationSeG
    {
        public IDbconectSeG _dbconect { set; get; }

        public dynamic GetData()
        {
            return _dbconect.GetData();
        }
    }
}
/*
DbOperationSeG db = new DbOperationSeG()
{
    _dbconect = new VDatabase()
};

Console.WriteLine(db.GetData().name); 
*/