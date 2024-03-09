using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class NhanVien
    {
        public Guid ID { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public int ChucVu { get; set; }
        public string Email { get; set; }
        public int Luong { get; set; }
        public bool TrangThai { get; set; }

        public ChucVu chucVu { get; set; }
    }
}
