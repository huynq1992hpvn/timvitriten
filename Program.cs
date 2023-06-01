using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosanhten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] student = { "Huy", "Cường", "Đạt", "Quân", "Hà", "Quốc Anh" };
            Console.WriteLine("nhập tên sinh viên cần tìm: ");
            string ten = Console.ReadLine();
            bool tontai = false;
            for (int i = 0; i < student.Length; i++)
            {
                if (student[i].Equals(ten))
                {
                    Console.WriteLine("Vi tri hoc sinh " + ten + " la " + (i + 1));
                    tontai = true;
                    break;
                }
            }
            if (!tontai)
            {
                Console.WriteLine("khong tim thay ten phu hop");
            }
            Console.ReadKey();
        }
            
    }
}
