using System;

namespace MvcApp.Models
{
    public class Bai1
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }

        // Tính tuổi từ năm sinh
        public int Tuoi
        {
            get
            {
                return DateTime.Now.Year - NamSinh;
            }
        }
    }
}
