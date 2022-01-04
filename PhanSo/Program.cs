using System;
using System.Collections.Generic;

namespace PhanSo
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            So so1 = new So();
            so1.Nhap();
            //so1.Xuat();
            so1.RutGon();

            So so2 = new So();
            so2.Nhap();
            //so2.Xuat();
            so2.RutGon();

            (so1 + so2).RutGon();
            (so1 - so2).RutGon();

            if(so1.SoSanh(so2))
            {
                Console.WriteLine("So 1 >= so 2");
            }
            else
            {
                Console.WriteLine("So 2 > so 1");
            }

            List<So> listPhanSo = new List<So>();

            Console.WriteLine("Nhập số phần tử của danh sach: ");
            int n = int.Parse(Console.ReadLine());
            So a;



            for (int i = 0; i < n; i++)
            {
                a = new So();
                a.Nhap();
                listPhanSo.Add(a);
            }

            Console.WriteLine("Danh sách");
            for (int i = 0; i < n; i++)
            {
                listPhanSo[i].Xuat();
                Console.WriteLine();
            }
            Console.WriteLine("Danh sách sau khi rút gọn");
            for (int i = 0; i < n; i++)
            {
                listPhanSo[i].RutGon();
                Console.WriteLine();
            }


            So temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    if (listPhanSo[j].SoSanh(listPhanSo[j+1]))
                    {
                      
                        temp = listPhanSo[j+1];
                        listPhanSo[j+1] = listPhanSo[j];
                        listPhanSo[j] = temp;
                    }
                }
            }

            Console.WriteLine("Danh sách sau khi sắp xếp giảm dần");
            for (int i = 0; i < n; i++)
            {
                listPhanSo[i].RutGon();
                Console.WriteLine();
            }

            So temp2;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (listPhanSo[j].SoSanh(listPhanSo[j+1])==false)
                    {

                        temp2 = listPhanSo[j + 1];
                        listPhanSo[j + 1] = listPhanSo[j];
                        listPhanSo[j] = temp2;
                    }
                }
            }

            Console.WriteLine("Danh sách sau khi sắp xếp tăng dần");
            for (int i = 0; i < n; i++)
            {
                listPhanSo[i].RutGon();
                Console.WriteLine();
            }

            So TongDaySo=new So();
            TongDaySo.TuSo = 0;
            TongDaySo.MauSo = 1;
            for(int i=0;i<n;i++)
            {
                TongDaySo = TongDaySo + listPhanSo[i];
            }
            Console.WriteLine("Tong cac so: ");
           TongDaySo.RutGon();
            Console.WriteLine();

            So HieuDaySo = new So();
            HieuDaySo.TuSo = listPhanSo[0].TuSo;
            HieuDaySo.MauSo = listPhanSo[0].MauSo;
            for(int i=0;i<n;i++)
            {
                HieuDaySo = HieuDaySo - listPhanSo[i];
            }
            Console.WriteLine("Hieu cac so: ");
            HieuDaySo.RutGon();
            Console.WriteLine();

            So NhanDaySo = new So();
            NhanDaySo.TuSo = listPhanSo[0].TuSo;
            NhanDaySo.MauSo = listPhanSo[0].MauSo;
            for (int i = 0; i < n; i++)
            {
                NhanDaySo = NhanDaySo * listPhanSo[i];
            }
            Console.WriteLine("Nhan cac so: ");
            NhanDaySo.RutGon();
            Console.WriteLine();

            So ChiaDaySo = new So();
            ChiaDaySo.TuSo = listPhanSo[0].TuSo;
            ChiaDaySo.MauSo = listPhanSo[0].MauSo;
            for (int i = 0; i < n; i++)
            {
                ChiaDaySo = ChiaDaySo / listPhanSo[i];
            }
            Console.WriteLine("Nhan cac so: ");
            ChiaDaySo.RutGon();

            Console.ReadKey();
        }

    }

}
