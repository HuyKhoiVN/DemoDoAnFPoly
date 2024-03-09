using AppData.Context;
using AppData.IRepositories;
using AppData.Models;
using AppData.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        INhanVienRepositories<NhanVien> irepos;
        //tao 1 dbcontext de khong bi null
        NhanVienContext context = new NhanVienContext();

        public NhanVienController()
        {
            //tao 1 allrepos de gan cho IAllrepos
            NhanVienRepositories<NhanVien> repos = new NhanVienRepositories<NhanVien>(context, context.NhanViens);
            irepos = repos;
            
        }
        [HttpGet("get-all-nhanvien")]
        public IEnumerable<NhanVien> GetAll()
        {
            return irepos.GetAllItems();
        }

        [HttpPost("crate-nhanvien")]
        public bool CreateNhanVien(string ten, int tuoi, int chucvu, string email, int luong, bool trangthai)
        {
            NhanVien nv = new NhanVien();
            nv.ID = Guid.NewGuid();
            nv.Ten = ten;
            nv.Tuoi = tuoi;
            nv.ChucVu = chucvu;
            nv.Email = email;
            nv.Luong = luong;
            nv.TrangThai = trangthai;

            return irepos.CreateItem(nv);
        }

        [HttpPut("update-nhanvien")]
        public bool UpdateNhanVien(Guid id, string ten, int tuoi, int chucvu, string email, int luong, bool trangthai)
        {
            NhanVien nv = new NhanVien();
            nv.ID = id;
            nv.Ten = ten;
            nv.Tuoi = tuoi;
            nv.ChucVu = chucvu;
            nv.Email = email;
            nv.Luong = luong;
            nv.TrangThai = trangthai;

            return irepos.UpdateItem(nv);
        }

        [HttpDelete("delete-nhanvien")]
        public bool DeleteNhanVien(Guid id)
        {
            NhanVien nv = new NhanVien();
            nv.ID = id;
            return irepos.DeleteItem(nv);
        }

    }
}
