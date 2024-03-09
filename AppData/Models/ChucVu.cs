using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class ChucVu
    {
        public Guid ID { get; set; }
        public string Ten { get; set; }
        public bool TrangThai { get; set; }

        public ICollection<NhanVien> NhanViens { get; set;}
    }
}
