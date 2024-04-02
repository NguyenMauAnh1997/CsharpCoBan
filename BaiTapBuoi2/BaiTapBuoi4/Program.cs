using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BaiTapBuoi4
{
    class Program
    {
        static void Main(string[] args)
        {
            //BAI TAP 1
            QuanLyThongTinSach();

            //BAI TAP 2
            //QuanLyThongTinHocSinh();

            Thread.Sleep(5000);
        }
        public static void QuanLyThongTinSach()
        {
            bool checkYeuCau = false;
            List<ThongTinSach> danhsach = new List<ThongTinSach>();
            do
            {
                LoiChao();
                var yeuCau = Console.ReadLine();
                try
                {
                    switch (yeuCau)
                    {
                        case "1":
                            XemDanhSach(danhsach);
                            break;
                        case "2":
                            ThemSach(danhsach);
                            break;
                        case "3":
                            TimKiem(danhsach);
                            break;
                        case "4":
                            Thoat();
                            checkYeuCau = true;
                            break;
                        default:
                            break;
                    }
                    
                }
                catch (Exception)
                {

                    checkYeuCau = false;
                }
                

            } while (checkYeuCau == false);
            
        }
        private static void LoiChao()
        {
            Console.WriteLine("CHUONG TRINH QUAN LY THONG TIN SACH");
            Console.WriteLine("Hay nhap yeu cau cua ban theo huong dan ban duoi day ");
            Console.WriteLine(" An 1 + Enter : Xem danh sach Sach hien co");
            Console.WriteLine(" An 2 + Enter : Them Sach Moi");
            Console.WriteLine(" An 3 + Enter : Tim Kiem Sach Theo Tieu De");
            Console.WriteLine(" An 4 + Enter : Thoat Chuong Trinh");
        }
        private static void XemDanhSach(List<ThongTinSach> danhsach)
        {
            if(danhsach.Count > 0)
            {
                Console.WriteLine("DANH SACH SACH HIEN CO LA ");
                for (int i = 0; i < danhsach.Count; i++)
                {
                    Console.WriteLine(i + ". " + danhsach[i].TieuDe);
                }
                Console.WriteLine("-----------------------------");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("KHONG CO QUYEN SACH NAO");
                Console.WriteLine("");
                Console.WriteLine("");
            }

            
        }
        private static void ThemSach(List<ThongTinSach> danhsach)
        {
            Console.WriteLine("HAY NHAP THONG TIN SACH MOI VAO");
            bool checkNhapTieuDe = false;
            int countInput = 0;
            do
            {
                if(countInput > 0) Console.WriteLine("BAN DA NHAP SAI HAY NHAP LAI");
                Console.Write("Tieu de : ");
                var tieuDe = Console.ReadLine();
                Console.Write("Tac gia : ");
                var tacGia = Console.ReadLine();
                Console.Write("Nam xuat ban : ");
                var namXuatBan = Console.ReadLine();

                if (String.IsNullOrEmpty(tieuDe) 
                    || String.IsNullOrEmpty(tacGia)
                    || String.IsNullOrEmpty(namXuatBan)
                    || int.TryParse(namXuatBan, out int n) == false
                    )
                {
                    checkNhapTieuDe = true;
                    countInput++;
                }
                else
                {
                    Console.WriteLine("THONG TIN SACH DA DUOC LUU");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    ThongTinSach thongtinsach = new ThongTinSach();
                    thongtinsach.TieuDe = tieuDe;
                    thongtinsach.TacGia = tacGia;
                    thongtinsach.NamXuatBan = namXuatBan;
                    danhsach.Add(thongtinsach);

                    checkNhapTieuDe = false;
                }

            } while (checkNhapTieuDe);
            

        }
        private static void TimKiem(List<ThongTinSach> danhsach)
        {
            Console.WriteLine("HAY NHAP THONG TIN TIM KIEM");
            Console.Write("Tieu de : ");
            var tieuDeTimKiem = Console.ReadLine();
            Console.Write("Tac gia : ");
            var tacGiaTimKiem = Console.ReadLine();
            Console.Write("Nam xuat ban : ");
            var namXuatBanTimKiem = Console.ReadLine();

            List<ThongTinSach> dsKetQua = new List<ThongTinSach>();
            foreach (var item in danhsach)
            {
                if (tieuDeTimKiem == item.TieuDe
                    || tacGiaTimKiem == item.TacGia
                    || namXuatBanTimKiem == item.NamXuatBan
                    )
                {
                    dsKetQua.Add(item);
                }
            }
            if(dsKetQua.Count > 0)
            {
                Console.WriteLine("KET QUA TIM KIEM LA ");
                for (int i = 0; i < dsKetQua.Count; i++)
                {
                    Console.WriteLine((i + 1) + "-----------------------");
                    Console.WriteLine("Tieu de "+ dsKetQua[i].TieuDe);
                    Console.WriteLine("Tac gia "+ dsKetQua[i].TacGia);
                    Console.WriteLine("Nam xuat ban "+ dsKetQua[i].NamXuatBan);
                }
            }

        }
        private static void Thoat()
        {
            Console.WriteLine("-----------CHUONG TRINH KET THUC TRONG 5S ---------------");
            Console.WriteLine("---------------------XIN CAM ON --------------------- ");
        }


        public static void QuanLyThongTinHocSinh()
        {
            bool checkYeuCauHS = false;
            List<ThongTinHocSinh> danhsachHS = new List<ThongTinHocSinh>();
            do
            {
                LoiChaoHS();
                var yeuCau = Console.ReadLine();
                try
                {
                    switch (yeuCau)
                    {
                        case "1":
                            XemDanhSachHS(danhsachHS);
                            break;
                        case "2":
                            ThemHS(danhsachHS);
                            break;
                        case "3":
                            TimKiemHS(danhsachHS);
                            break;
                        case "4":
                            ThoatHS();
                            checkYeuCauHS = true;
                            break;
                        default:
                            break;
                    }

                }
                catch (Exception)
                {

                    checkYeuCauHS = false;
                }


            } while (checkYeuCauHS == false);
        }

        private static void LoiChaoHS()
        {
            Console.WriteLine("CHUONG TRINH QUAN LY THONG HOC SINH");
            Console.WriteLine("Hay nhap yeu cau cua ban theo huong dan ban duoi day ");
            Console.WriteLine(" An 1 + Enter : Xem danh sach Hoc sinh");
            Console.WriteLine(" An 2 + Enter : Them Hoc Sinh");
            Console.WriteLine(" An 3 + Enter : Tim Kiem Hoc Sinh");
            Console.WriteLine(" An 4 + Enter : Thoat Chuong Trinh");
        }
        private static void XemDanhSachHS(List<ThongTinHocSinh> danhsach)
        {
            if (danhsach.Count > 0)
            {
                Console.WriteLine("DANH SACH SACH HIEN CO LA ");
                for (int i = 0; i < danhsach.Count; i++)
                {
                    Console.WriteLine(i + ". " + danhsach[i].Ten);
                }
                Console.WriteLine("-----------------------------");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("KHONG CO HOC SINH NAO");
                Console.WriteLine("");
                Console.WriteLine("");
            }


        }
        private static void ThemHS(List<ThongTinHocSinh> danhsach)
        {
            Console.WriteLine("HAY NHAP THONG TIN HOC SINH MOI VAO");
            bool checkNhapTieuDe = false;
            int countInput = 0;
            do
            {
                if (countInput > 0) Console.WriteLine("BAN DA NHAP SAI HAY NHAP LAI");
                Console.Write("Ten : ");
                var ten = Console.ReadLine();
                Console.Write("Tuoi: ");
                var tuoi = Console.ReadLine();
             

                if (String.IsNullOrEmpty(ten)
                    || String.IsNullOrEmpty(tuoi)
                    || int.TryParse(tuoi, out int n) == false
                    )
                {
                    checkNhapTieuDe = true;
                    countInput++;
                }
                else
                {
                    Console.WriteLine("THONG TIN HOC SINH DUOC LUU");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    ThongTinHocSinh thongtinhHS = new ThongTinHocSinh();
                    thongtinhHS.Ten = ten;
                    thongtinhHS.Tuoi = Int32.Parse(tuoi);
                    danhsach.Add(thongtinhHS);

                    checkNhapTieuDe = false;
                }

            } while (checkNhapTieuDe);


        }
        private static void TimKiemHS(List<ThongTinHocSinh> danhsach)
        {
            Console.WriteLine("HAY NHAP THONG TIN TIM KIEM");
            Console.Write("Ten : ");
            var tenTimKiem = Console.ReadLine();
            Console.Write("Tac gia : ");
            var tuoiTimKiem = Console.ReadLine();
            Console.Write("Diem Trung Binh : ");
            var diemTimKiem = Console.ReadLine();

            List<ThongTinHocSinh> dsKetQua = new List<ThongTinHocSinh>();
            foreach (var item in danhsach)
            {
                if (tenTimKiem == item.Ten
                    || tuoiTimKiem == item.Tuoi.ToString()
                    || diemTimKiem == item.DiemTB.ToString()
                    )
                {
                    dsKetQua.Add(item);
                }
            }
            if (dsKetQua.Count > 0)
            {
                Console.WriteLine("KET QUA TIM KIEM LA ");
                for (int i = 0; i < dsKetQua.Count; i++)
                {
                    Console.WriteLine((i + 1) + "-----------------------");
                    Console.WriteLine("Ten " + dsKetQua[i].Ten);
                    Console.WriteLine("Tuoi " + dsKetQua[i].Tuoi.ToString());
                    Console.WriteLine("Diem TB " + dsKetQua[i].DiemTB.ToString());
                }
            }

        }
        private static void ThoatHS()
        {
            Console.WriteLine("-----------CHUONG TRINH KET THUC TRONG 5S ---------------");
            Console.WriteLine("---------------------XIN CAM ON --------------------- ");
        }
    }
}
