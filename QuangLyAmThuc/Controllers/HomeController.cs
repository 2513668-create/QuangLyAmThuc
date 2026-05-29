using Microsoft.AspNetCore.Mvc;
using QuanLyAmThuc.Models;
using System;
using System.Linq;

namespace QuanLyAmThuc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string vungMien)
        {
            var danhSach = DataMockup.DanhSachMonAn;

            // Hàm Contains xử lý bóc tách thông minh loại bỏ hoàn toàn lỗi lệch Emoji nút bấm
            if (!string.IsNullOrEmpty(vungMien))
            {
                danhSach = danhSach.Where(m => vungMien.Contains(m.VungMien, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            ViewBag.VungMienHienTai = vungMien;
            return View(danhSach);
        }

        public IActionResult Details(int id)
        {
            var monAn = DataMockup.DanhSachMonAn.FirstOrDefault(m => m.Id == id);
            if (monAn == null)
            {
                return NotFound();
            }
            return View(monAn);
        }
    }
}