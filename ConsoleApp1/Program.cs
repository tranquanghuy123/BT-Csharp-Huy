using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào 2 số nguyên bất kì
            //và cho xuất ra màn hình các giá trị là +, -, *, /
            // và người dùng chỉ chọn 1 trong 4

            Console.Write("Nhap a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=====   Cac phep tinh   =====");
            Console.WriteLine("1.Tinh tong");
            Console.WriteLine("2.Tinh hieu");
            Console.WriteLine("3.Tinh tich");
            Console.WriteLine("4.Tinh thuong");
            Console.Write(" Xin hay chon phep tinh: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice) 
            {
                case 1:
                    Console.WriteLine("Tong cua {0} va {1} la: {2}",a,b, a + b);
                    break;
                case 2:
                    Console.WriteLine("Hieu cua {0} va {1} la: {2}", a, b, a - b);
                    break;
                case 3:
                    Console.WriteLine("Tich cua {0} va {1} la: {2}", a, b, a * b);
                    break;
                case 4:
                    Console.WriteLine("Thuong {0} va {1} la: {2}", a, b, a / b);
                    break;
            }
        }
    }
}
