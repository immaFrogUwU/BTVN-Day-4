using System;
using System.IO;
using static System.Console;

namespace HomeWork_Slide
{
    public class Slide 
    {
        public void Main(string[] args)
        {
            WriteLine("Hay nhap vao hai so: ");
            Write("Nhap vao so thu nhat: ");
            int a = Convert.ToInt32(ReadLine());
            Write("Nhap vao so thu hai: ");
            int b = Convert.ToInt32(ReadLine());
            Write("Nhap vao so thu ba: ");
            int c  = Convert.ToInt32(ReadLine());
            Write("Nhap vao so thu tu: ");
            int d = Convert.ToInt32(ReadLine());            
            int TBC = (a+b+c+d)/4;
            WriteLine("Tong hai so la: {0} ", a + b);
            WriteLine("Hieu hai so la: {0} ", a - b);
            WriteLine("Tich hai so la: {0} ", a * b);
            WriteLine("Thuong hai so la: {0}", a/b);
            writeLine("Phan du hai so la: {0}", a%b);            
            WriteLine("Trung binh cong cua 4 so la: " + TBC);       
            
            Slide s1 = new Slide();
            s1.Swap();
            Slide s2 = new Slide();
            s2.Celsius();
            Slide s3 = new Slide();
            s3.InputStream();
          
            
        }
        public void Swap()
        {
            Write("Nhap vao so thu nhat: ");
            int a = Convert.ToInt32(ReadLine());
            Write("Nhap vao so thu hai: ");
            int b = Convert.ToInt32(ReadLine());
            int c = a;
            a = b;
            b = c;
            WriteLine("Gia tri sau khi trao doi cua so thu nhat la: " + a, "sau khi trao doi so thu hai la: " + b)            
           
        }
        
        public void Celsius()
        {
            Console.Write("Nhap vao do C: ");
            int celsius = Convert.ToInt32(ReadLine());
            WriteLine("Do K tuong ung la = {0}", celsius + 273);
            WriteLine("Do F tuong ung la = {0}", celsius * 18 / 10 + 32);
        } 
        public void InputStream()
        {
            Write("Nhap vao mot so: ");            
            int i = Convert.ToInt32(ReadLine());
            int ketqua = Convert.ToInt32(ReadLine());
            ketqua = x * 0;
            Console.WriteLine("Hien thi bang nhan:{0} x {1} = {2}", x, 0, ketqua);
            ketqua = x * 1;
            Console.WriteLine("{0} x {1} = {2}", x, 1, ketqua);
            ketqua = x * 2;
            Console.WriteLine("{0} x {1} = {2}", x, 2, ketqua);
            ketqua = x * 3;
            Console.WriteLine("{0} x {1} = {2}", x, 3,ketqua);
            ketqua = x * 4;
            Console.WriteLine("{0} x {1} = {2}", x, 4, ketqua);
            ketqua = x * 5;
            Console.WriteLine("{0} x {1} = {2}", x, 5, ketqua);
            ketqua = x * 6;
            Console.WriteLine("{0} x {1} = {2}", x, 6, ketqua);
            ketqua = x * 7;
            Console.WriteLine("{0} x {1} = {2}", x, 7, ketqua);
            ketqua = x * 8;
            Console.WriteLine("{0} x {1} = {2}", x, 8, ketqua);
            ketqua = x * 9;
            Console.WriteLine("{0} x {1} = {2}", x, 9, ketqua);
            ketqua = x * 10;
            Console.WriteLine("{0} x {1} = {2}", x, 10, ketqua);
        }
    }
}
