using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi2
{
    public struct Product
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Product(string _name, int _age)
        {
            Name = _name;
            Age = _age;
        }

}
    class Program
    {
        static void Main(string[] args)
        {
            //bai1();
            //bai2();
            //bai3();
            //bai4();
            //bai5();     // KHONG HIEU DE BAI
            bai6();

        }
        //In dãy số nguyên tố nhỏ hơn số được nhập vào từ bàn phím
        public static void bai1()
        {
            //step 1: kiem tra nhap vao co phai so nguyen hay khong 
            var checkIsNumber = true;
            var numberInt = 0;
            do
            {
                try
                {
                    checkIsNumber = true;
                    Console.WriteLine("hay nhap vao 1 nguyen bat ky");
                    var numnberChar = Console.ReadLine();
                        numberInt = Int32.Parse(numnberChar);
                }
                catch (Exception)
                {
                    checkIsNumber = false;
                }

            } while (checkIsNumber == false);


            Console.WriteLine("so nguyen to la : ");
            //step 2: chay vong lap va kiem tra 
            for (int i = 1; i < numberInt; i++)
            {
               if(i == 1)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    var checkNumber = 0;
                    for (int j = 1; j < i; j++)
                    {
                        if (i % j == 0) checkNumber++;
                    }
                    if (checkNumber == 2) Console.WriteLine(i);
                }

            }
            
            Console.ReadLine();
        }

        //Viết chương trình c# Nhập vào 1 chuỗi bất kỳ sau đó hãy đảo ngược chuổi đó
        public static void bai2()
        {
            Console.WriteLine("Hay nhap vao 1 chuoi bat ky ");
            var chuoiNhapVao = Console.ReadLine();
            Console.WriteLine("Chuoi dao nguoc la");
            var chuoiNhapVaoArr = chuoiNhapVao.ToCharArray();
            for (int i = chuoiNhapVaoArr.Length -1; i >= 0 ; i--)
            {
                Console.Write(chuoiNhapVaoArr[i]);
            }


            Console.ReadLine();
        }

        //Đếm số lần xuất hiện của một ký tự trong chuỗi
        public static void bai3()
        {
            Console.WriteLine("Hay nhap vao chuoi bat ky");

            //step 1 : Chuoi co nhung ky tu gi 
            var InputString = Console.ReadLine();
            var InputCharArr = InputString.ToCharArray();
            List<string> saveStringCount = new List<string>();
            foreach (char c in InputCharArr)
            {
                var count = 0;
                for (int i = 0; i < InputCharArr.Length; i++)
                {
                    if (c == InputCharArr[i])
                    {
                        count++;
                    }
                }
                saveStringCount.Add("So lan xuat kien ky tu " + c + "------>" + count + " Lan");
                //Console.WriteLine("So lan xuat kien ky tu " + c + "------>" + count + " Lan");
            }
            var removeDuplicate = saveStringCount.Distinct().ToList();
            foreach (var item in removeDuplicate)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
        //sử dụng do-while để Tính giai thừa của một số
        public static void bai4()
        {
            //step 1: kiem tra nhap vao co phai so nguyen hay khong 
            var checkIsNumber = true;
            var numberInt = 0;
            do
            {
                try
                {
                    checkIsNumber = true;
                    Console.WriteLine("hay nhap vao 1 nguyen duong bat ky");
                    var numnberChar = Console.ReadLine();
                    numberInt = Int32.Parse(numnberChar);
                }
                catch (Exception)
                {
                    checkIsNumber = false;
                }

            } while (checkIsNumber == false);

            //step 2: Tinh giai thua
            int tmpNo = 1;
            var tinhGiaiThua  = tmpNo;
            do
            {
                tinhGiaiThua = tinhGiaiThua * tmpNo;
                tmpNo++;
            } while (tmpNo <= numberInt);

            Console.WriteLine("Giai thua cua so " + numberInt + " la " + tinhGiaiThua);
            Console.ReadLine();

        }
        //Sử dụng do-while để Đoán số ngẫu nhiên(nhập vào bàn phím 1 số bất kỳ và so sánh với số được sinh ra từ Class Random trong c#)
        public static void bai5()
        {

        }
        //Sử dụng do-while để kiểm tra mật khẩu được nhập từ bàn phím(Mật khẩu phải từ 6-12 ký tự và có ký tự @)
        public static void bai6()
        {
            var count = 0;
            bool check = true;
            do
            {
                Console.WriteLine("Hay Nhap Mat Khau tu 6-12 ky tu va co ky tu @");
                var chuoiNhapVao = Console.ReadLine();
                var chuoiNhapVaoArr = chuoiNhapVao.ToCharArray();
                count = chuoiNhapVaoArr.Length;
                foreach (var item in chuoiNhapVaoArr)
                {
                    if (item == '@') check = false;
                }

            } while (count > 12 || count < 6 || check);

            Console.WriteLine("MAT KHAU CUA BAN DA DUOC THIET LAP");
            Console.ReadLine();

        }
    }
}
