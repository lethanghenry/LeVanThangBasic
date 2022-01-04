using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanSo
{
    class So
    {
        public int MauSo { get; set; }
        public int TuSo { get; set; }
        public So()
        { }
        public So(int MauSo, int TuSo)
        {
            this.MauSo = MauSo;
            this.TuSo = TuSo;
        }
        public void Nhap()
        {
            Console.WriteLine("----- MOI NHAP PHAN SO -----");
            Console.WriteLine("TU SO: ");
            TuSo = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("MAU SO: ");
                MauSo = int.Parse(Console.ReadLine());
            } while (MauSo == 0);


        }
        public void Xuat()
        {
            Console.Write(" {0}/{1} ", TuSo, MauSo);
        }
        public int Ucln(int a, int b)
        {
            if (b == 0)
                return a;
            if (a % b == 0)
                return b;
            return Ucln(b, a % b);
        }

        public void RutGon()
        {
            So so = new So();
            int uoc = Ucln(TuSo, MauSo);
            if (TuSo % MauSo==0)
            {
                Console.WriteLine(TuSo/MauSo);
            }
            else
            {
                if (uoc != 0)
                {
                    so.TuSo = TuSo / uoc;
                    so.MauSo = MauSo / uoc;
                }
                else
                {
                    so.TuSo = TuSo;
                    so.MauSo = MauSo;
                }
                Console.WriteLine(" {0}/{1} ", so.TuSo, so.MauSo);
            }

        }

        public static So operator +(So so1, So so2)
        {
            So so = new So();
            so.TuSo = so1.TuSo * so2.MauSo + so1.MauSo * so2.TuSo;
            so.MauSo = so1.MauSo * so2.MauSo;
            return so;
        }

        public static So operator -(So so1, So so2)
        {
            So so = new So();
            so.TuSo = so1.TuSo * so2.MauSo - so1.MauSo * so2.TuSo;
            so.MauSo = so1.MauSo * so2.MauSo;
            return so;
        }

        public static So operator *(So so1, So so2)
        {
            So so = new So();
            so.TuSo = so1.TuSo * so2.TuSo;
            so.MauSo = so1.MauSo * so2.MauSo;
            return so;
        }

        public static So operator /(So so1, So so2)
        {
            So so = new So();
            so.TuSo = so1.TuSo * so2.MauSo;
            so.MauSo = so1.MauSo * so2.TuSo;
            return so;
        }

        public bool SoSanh(So a) 
        {
            int x;
            int y;
            if (MauSo != a.MauSo)
            {
                x = TuSo * a.MauSo;
                y = MauSo * a.TuSo;
            }
            else
            {
                y = TuSo;
                x = a.TuSo;
            }
            if (x >= y)
                return true;
            return false;
        }
    }
}
