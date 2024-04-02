using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi3
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //1.Viết function Nhập vào một mảng số nguyên và trả về danh sách mảng số nguyên đó
        public int [] traMangSoNguyen()
        {
            //Nhap vao mang so nguyen 
            Console.WriteLine("hay nhap vao so phan tu mang");
            var soPhanTuArr = Console.ReadLine();


            return null;
        }
        public void kiemTraNhapXuatDuLieu(numnberChar)
        {
            var checkIsNumber = true;
            var numberInt = 0;
            do
            {
                try
                {
                    checkIsNumber = true;
                    numberInt = Int32.Parse(numnberChar);
                }
                catch (Exception)
                {
                    checkIsNumber = false;
                    Console.WriteLine("Du lieu nhap khong dung, xin hay nhap lai");
                }

            } while (checkIsNumber == false);

        }
    }
}
