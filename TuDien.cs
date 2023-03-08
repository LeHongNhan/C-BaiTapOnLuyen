using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_CS
{
    class Program
    {
        static Dictionary<string, string> dic = new Dictionary<string, string>();
        static string ta;
        static string tv;
        //Thêm từ
        //Xóa từ
        //Tra cứu
        //Đổi nghĩa
        static void menu()
        {
            Console.WriteLine("------------------Từ điển------------------");
            Console.WriteLine("1. Thêm từ vào từ điển ");
            Console.WriteLine("2. Xóa từ khỏi từ điển");
            Console.WriteLine("3. Tra cứu");
            Console.WriteLine("4. Đổi nghĩa từ");
            Console.WriteLine("0. Thoát");
        }

        static void themTu()
        {


            Console.WriteLine("Hãy nhập từ tiếng Anh muốn thêm:");
            ta = Console.ReadLine();
            if(dic.ContainsKey("ta"))
            {
                Console.WriteLine("Từ " + ta + " đã có trong từ điển");
                return;
            }
            Console.WriteLine("Hãy nhập từ tiếng Việt muốn thêm:");
            tv = Console.ReadLine();
            dic[ta] = tv;
            Console.WriteLine("Đã thêm thành công!");

        }
        static void xoaTu()
        {
            Console.WriteLine("Nhập từ tiếng Anh bạn muốn xóa: ");
            ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                dic.Remove(ta);
                Console.WriteLine("Đã xóa từ" + ta + "khỏi từ điển thành công!");
                return;
            }
            else
            {
                Console.WriteLine("Từ " + ta + " không có trong từ điển! ");
            }

        }
        static void traCuu()
        {
            Console.WriteLine("Nhập từ tiếng Anh: ");
            ta = Console.ReadLine();
            if(dic.ContainsKey(ta))
            {
                Console.WriteLine("Nghĩa của từ là: " + dic[ta]);
                return;
            }
            else
            {
                Console.WriteLine("Từ điển chưa cập nhật từ " + ta);
                return;
            }
        }
        static void doiNghiaTu()
        {
            Console.WriteLine("Nhập từ tiếng Anh để đổi nghĩa: ");
            ta = Console.ReadLine();
            if(dic.ContainsKey(ta))
            {
                Console.WriteLine("Nhập từ tiếng Việt: ");
                tv = Console.ReadLine();
                dic[ta] = tv;
                Console.WriteLine("Đã cập nhật thành công nghĩa từ " + ta);
            }
            else
            {
                Console.WriteLine("Từ điển chưa cập nhật từ " + ta);
                return;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice = 0;
                do
                {
                    menu();
                    Console.WriteLine("Hãy nhập lựa chọn: ");
                    choice = int.Parse(Console.ReadLine());
                    if(choice == 0)
                        break;
                    switch (choice)
                    {
                        case 1:
                            {
                                themTu();
                                break;
                            }
                        case 2:
                            {
                                xoaTu();
                                break;
                            }
                        case 3:
                            {
                                traCuu();
                                break;
                            }
                        case 4:
                            {
                                doiNghiaTu();
                                break;
                            }
                        case 0:
                            {
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Chọn lại đi!");
                                break;
                            }
                    }
                    Console.ReadLine();    
                } while (true);

            Console.ReadLine();
        }

        
    }
}
