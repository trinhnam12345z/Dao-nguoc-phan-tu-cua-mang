using System;

namespace DaoNguocPhanTuCuaMang
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bước 1: Khai báo các biến, nhập và kiểm tra kích thước mảng

            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                {
                    Console.WriteLine("Size does not exceed 20");
                }
            } while (size > 20);
            //Thực thi chương trình.

            //Bước 2: Nhập giá trị cho các phần tử của mảng

            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Enter element " + (i + 1) + ": ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            //Thực thi chương trình.

            //Bước 3: In ra mảng đã nhập

            Console.WriteLine("Elements in array: ", "");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }
            //Thực thi chương trình.

            //Bước 4: Đảo ngược thứ tự các phần tử trong mảng

            //Sử dụng biến trung gian để hoán đổi giá trị giữa 2 phần tử.
            DaoNguoc(array);
            
            //Bước 5: In ra mảng sau khi đã đảo ngược thứ tự các phần tử

            Console.WriteLine("Reverse array: ", "");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }
        }
        
        
        
        
        
        
        
        
        
        static void DaoNguoc(int []array){
            for (int j = 0; j < array.Length / 2; j++)
            {
                int temp = array[j];
                array[j] = array[size - 1 - j];
                array[size - 1 - j] = temp;
            }
        }
    }
}
