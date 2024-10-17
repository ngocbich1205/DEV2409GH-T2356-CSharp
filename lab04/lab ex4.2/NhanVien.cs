using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_ex4._2
{
    abstract class NhanVien
    {
        public string Ten;
        public string DiaChi;
        public NhanVien() { }
        public NhanVien(string Ten, string DiaChi)
        {
            this.Ten = Ten;
            this.DiaChi = DiaChi;
        }
        public abstract double TinhLuong(double Day, double high);
        public abstract void HienThi(string Ten, string DiaChi);
    }
    class NhanVienBanHang : NhanVien
    {
        public override void HienThi(string Ten, string DiaChi)
        {
            Console.WriteLine("Ten: {0}, Dia chi:{1} ", Ten, DiaChi);
        }

        public override double TinhLuong(double Day, double high)
        {
            return Day * high;
        }
    }
    class CongNhan : NhanVien
    {
        public override void HienThi(string Ten, string DiaChi)
        {
            Console.WriteLine("Ten: {0}, Dia chi{1}: ", Ten, DiaChi);
        }

        public override double TinhLuong(double Day, double high)
        {
            return Day * high;
        }
    }
}
