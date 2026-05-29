using System.Collections.Generic;

namespace QuanLyAmThuc.Models
{
    public class MonAn
    {
        public int Id { get; set; }
        public string TenMon { get; set; }
        public string VungMien { get; set; }
        public string DacSan { get; set; }
        public string MoTa { get; set; }
        public string NguyenLieu { get; set; }
        public string HinhAnh { get; set; }
    }

    public static class DataMockup
    {
        public static List<MonAn> DanhSachMonAn = new List<MonAn>()
        {
            new MonAn { Id = 1, TenMon = "Phở Bò", VungMien = "Miền Bắc", DacSan = "Hà Nội",
                MoTa = "Món ăn quốc hồn quốc túy với nước dùng thanh ngọt tinh tế ninh từ xương.",
                NguyenLieu = "Bánh phở, thịt bò tươi, xương ống bò, quế, hồi, thảo quả, hành lá.",
                HinhAnh = "https://images.unsplash.com/photo-1582878826629-29b7ad1cdc43?q=80&w=800" },
            new MonAn { Id = 2, TenMon = "Bún Chả", VungMien = "Miền Bắc", DacSan = "Hà Nội",
                MoTa = "Thịt nướng than hoa thơm nức mũi ăn kèm nước chấm chua ngọt đưa miệng.",
                NguyenLieu = "Thịt ba chỉ, thịt nạc vai băm, bún sợi nhỏ, đu đủ xanh, rau thơm.",
                HinhAnh = "https://cdn.zsoft.solutions/poseidon-web/app/media/uploaded-files/090724-bun-cha-ha-noi-buffet-poseidon-1.jpeg" },
            new MonAn { Id = 3, TenMon = "Bún Bò Huế", VungMien = "Miền Trung", DacSan = "Huế",
                MoTa = "Đặc sản cố đô mang hương vị nồng nàn đặc trưng của mắm ruốc xứ Huế.",
                NguyenLieu = "Bún sợi to, thịt bắp bò, giò heo, mắm ruốc Huế, sả, ớt sa tế.",
                HinhAnh = "https://file.hstatic.net/200000700229/article/bun-bo-hue-1_da318989e7c2493f9e2c3e010e722466.jpg" },
            new MonAn { Id = 4, TenMon = "Mì Quảng", VungMien = "Miền Trung", DacSan = "Quảng Nam",
                MoTa = "Sợi mì vàng dai đậm đà ăn kèm tôm thịt và bánh tráng nướng giòn rụm.",
                NguyenLieu = "Sợi mì quảng, tôm, thịt heo, nước nhân, bánh tráng, rau sống.",
                HinhAnh = "https://cooponline.vn/tin-tuc/wp-content/uploads/2025/10/mi-quang-mon-dac-san-dam-da-thom-lung-xu-quang.png" },
            new MonAn { Id = 5, TenMon = "Cơm Tấm", VungMien = "Miền Nam", DacSan = "Sài Gòn",
                MoTa = "Cơm tấm dẻo thơm, sườn nướng mật ong vàng óng kèm mỡ hành mướt mát.",
                NguyenLieu = "Gạo tấm, sườn heo, trứng ốp la, bì chả, mỡ hành, nước mắm ngọt.",
                HinhAnh = "https://i1-giadinh.vnecdn.net/2024/03/07/7-Hoan-thien-thanh-pham-1-6244-1709800134.jpg?w=1020&h=0&q=100&dpr=1&fit=crop&s=Y03-BsY4ORbpVkG4zm_DcA" }
        };
    }
}
