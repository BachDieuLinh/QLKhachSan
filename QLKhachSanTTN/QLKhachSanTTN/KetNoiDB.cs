using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLKhachSanTTN
{
    public class KetNoiDB
    {
        public String KetNoi()
        {
            return (@"Data Source=HOME;Initial Catalog=QL_KhachSan;Integrated Security=True");
        }
    }
}
