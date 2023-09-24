using System;
using System.Collections.Generic;
using System.IO;

namespace PhamThienTan
{
    internal class HangTonKho
    {
        public string Ma_SP { get; set; }
        public string Ten_SP { get; set; }
        public int SL_Ton { get; set; }
        public DateTime NgayNhap { get; set; }
        public static void ThemSanPhamTuFile(string filePath, List<HangTonKho> danhSachSanPham)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 3)
                {
                    HangTonKho sanPham = new HangTonKho
                    {
                        Ma_SP = parts[0],
                        Ten_SP = parts[1],
                        SL_Ton = int.Parse(parts[2]),
                        NgayNhap = DateTime.Now
                    };

                    danhSachSanPham.Add(sanPham);
                }
            }
        }
    }

}