using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;
        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return instance; }
            private set { instance = value; }
        }
        private SanPhamDAO() { }
        public DataTable GetTable()
        {
            string query = "SELECT * FROM tbSanPham";
            DataTable data = DataProVider.Instance.ExcuteQuery(query);
            return data;
        }
    }
}
