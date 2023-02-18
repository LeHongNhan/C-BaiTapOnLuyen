using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace GameDoanChu
{
    //Game đoán chữ;
    class Program
    {


        
        static void Game()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int computerNumber;
            int playerNumber;
            int times = 7;
            int choice;
            int rangeNumber = 501;
            int rangeSetup = 501;
            int timeSetup = 7;
            int token = 0;
            token = 500;
            Random number = new Random();
            while(true)
            {
                rangeNumber = rangeSetup;
                times = timeSetup;
                Console.Clear();
                Console.WriteLine("GAME ĐOÁN SỐ");
                Console.WriteLine("1. Thiết đặt game");
                Console.WriteLine("2. Chơi game");
                do
                {
                    Console.WriteLine("Mời bạn lựa chọn: ");
                    choice = int.Parse(Console.ReadLine());
                    if (choice < 1 || choice > 2)
                    {
                        Console.WriteLine("Lựa chọn không hợp lệ, hãy chọn lại!!");
                    }
                } while (choice < 1 || choice > 2);
                switch(choice)
                {
                    case 1:
                        {
                            Console.Clear();
                            int choice2;
                            Console.WriteLine("1. Khoảng cách số của máy");
                            Console.WriteLine("2. Số lần đoán: ");
                            Console.WriteLine("0. Quay lại");
                            do
                            {
                                Console.Write("Mời bạn chọn: ");
                                choice2 = int.Parse(Console.ReadLine());
                                if (choice2 < 0 || choice2 > 2)
                                {
                                    Console.WriteLine("Lựa chọn không hợp lệ, hãy chọn lại!!");
                                }
                            }   while(choice2 < 0 || choice2 > 2);
                            switch(choice2)
                            {
                                case 1:
                                    {
                                        Console.Write("Khoảng cách từ 0 đến: ");
                                        do
                                        {

                                            rangeSetup = int.Parse(Console.ReadLine());
                                            if (rangeSetup < 1)
                                            {
                                                Console.WriteLine("Nhập lại!!!");
                                            }
                                        }   while(rangeSetup < 1);
                                        Console.WriteLine("Thiết đặt thành công!!");
                                        Console.ReadLine();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("Số lần đoán: ");
                                        do
                                        {

                                            timeSetup = int.Parse(Console.ReadLine());
                                            if (timeSetup < 1)
                                            {
                                                Console.WriteLine("Nhập lại!!!");
                                            }
                                        } while (timeSetup < 1);
                                        Console.WriteLine("Thiết đặt thành công!!");
                                        Console.ReadLine();
                                        break;
                                    }
                                case 0:
                                    {
                                        break;
                                    }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Số tiền bạn đang có: " + token);
                            Console.WriteLine("Nhập số tiền cược: ");
                            int pay = 0;
                            do
                            {

                                pay = int.Parse(Console.ReadLine());
                                if (pay > token)
                                {
                                    Console.WriteLine("Không đủ tiền, nhập lại số khác!!!");
                                }
                            } while (pay > token);

                            token -= pay;
                            Console.WriteLine("Game bắt đầu!!");
                            computerNumber = number.Next(rangeNumber);
                            while(true)
                            {
                                if (times == 0)
                                {
                                    Console.WriteLine("Bạn đã thua vì hết lượt đoán. Số của máy là: " + computerNumber);
                                    Console.ReadLine();
                                    break;
                                }
                                Console.Write("Hãy nhập số suy đoán của bạn: ");
                                playerNumber = int.Parse(Console.ReadLine());
                                if(playerNumber == computerNumber)
                                {
                                    Console.WriteLine("Bạn đã thắng! Số của máy là " + computerNumber);
                                    token += pay * 2;
                                    Console.WriteLine("Money: +" + pay);
                                    Console.ReadLine();
                                    break;
                                }
                                else if(playerNumber < computerNumber)
                                {
                                    Console.WriteLine("Số của bạn đang bé hơn số của máy");
                                    times--;
                                    Console.WriteLine("Số lần còn lại: " + times);
                                }
                                else if(playerNumber > computerNumber)
                                {
                                    Console.WriteLine("Số của bạn đang lớn hơn số của máy");
                                    times--;
                                    Console.WriteLine("Số lần còn lại: " + times);
                                }

                            }
                            break;
                        }
                }
            }
        }
        static void Main(string[] args)
        {
            Game();
        }
        
    }
}

