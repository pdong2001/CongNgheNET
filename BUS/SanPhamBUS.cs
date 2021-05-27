using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;

namespace BUS
{
    public class SanPhamBUS
    {
        private static SanPhamBUS instance;
        public static SanPhamBUS Instance
        {
            get { if (instance == null) instance = new SanPhamBUS(); return instance; }
            private set { instance = value; }
        }
        private SanPhamBUS() { }
        public DataTable GetTable()
        {
            DataTable data = SanPhamDAO.Instance.GetTable();
            return data;
        }
    }
}
