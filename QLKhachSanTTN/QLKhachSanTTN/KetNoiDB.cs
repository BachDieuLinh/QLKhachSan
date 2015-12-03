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
        static public String KetNoi()
        {
            return (@"Data Source=ADMINISTRATOR\LINH;Initial Catalog=QLKhachSan;Integrated Security=True");
        }
    }
}
