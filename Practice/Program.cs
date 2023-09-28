namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //1.Verilmish ededin 2 quvveti olub olmadigini tapan alqoritm(Meselen 8 , 4, 16 ve s. 2-nin quvvetidir amma 12  2-nin quvveti deyil) C# 

            Console.WriteLine("Eded daxil edin:");
            restart:
            int num=int.Parse(Console.ReadLine());
            if(num<0)
            {
                Console.WriteLine("duzgun eded daxil edin!");
                goto restart;
            }
            if (num == 0)
            {
                Console.WriteLine(true);
            }  else  if (num == 1)
            {
                Console.WriteLine(false);
            }
            else
            {

            bool isPow = true;
            while (num > 1) {
            if(num%2!=0)
                {
                    isPow = false;
                }
            num/=2;
            
            }
            Console.WriteLine(isPow);
            }

            #endregion

            #region Task2
            //1-dən N-ə qədər ədədlər arasında neçə digit rəqəmi var?
            Console.WriteLine("\n \n Task 2 \n \n" );
            Console.WriteLine("Hansi edede qeder davam etsin:");
            restartN:
            int.TryParse(Console.ReadLine(),out int N);
            if (N < 0)
            {
                Console.WriteLine("duzgun eded daxil edin");
                goto restartN;
            }
            Console.WriteLine("Hansi reqemi yoxlamaq isteyirsiniz");
            restartDigit:
            string digitStr=Console.ReadLine();
            int.TryParse(digitStr,out int digit);
            if (digitStr.Length != 1)
            {
                Console.WriteLine("duzgun reqem daxil edin");
                goto restartDigit;
            }
            int count = 0;
            if (digit == 0)
                     count++;
            for (int i = digit; i < N; i++)
            {
                int iClone = i;
                while (iClone > 0)
                {
                    if (iClone % 10 == digit)
                    {
                        count++;
                    }
                    iClone /= 10;
                }                
            }

            Console.WriteLine(count);
            #endregion

            #region Task3
            //Ədədin mükəmməl olub-olmamasını yoxlayan proqram yazın. Əgər mükəmməldirsə ekrana true, əks halda false çıxsın.

            Console.WriteLine("\n \n Task3 \n \n");
            Console.WriteLine("Eded daxil edin");
            int.TryParse(Console.ReadLine(), out num);
            count = 0;
            for (int i = 1; i < num; i++)
            {
                if(num%i==0)
                {
                    count += i;
                }
                
            }
            if (num == count)
            {
                Console.WriteLine("Mukemmel ededdir.");
            }
            else
            {
                Console.WriteLine("Mukemmel eded deyil.");
            }

            #endregion


            #region Task4
            //4.Daxil edilən N ədədinin 2-lik say sistemindəki qarşılığını göstərən proqram yazın.
            Console.WriteLine("\n \n Task4 \n \n ");
            Console.WriteLine("eded daxil edin");
            int.TryParse(Console.ReadLine(), out num);
            string binaryNumber="";
            while (num > 1)
            {
                binaryNumber += (num % 2).ToString();
                num/= 2;
            }
            binaryNumber += "1";
            string reverseBinaryNumber = "";
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                reverseBinaryNumber += binaryNumber[i];
            }
            Console.WriteLine(reverseBinaryNumber);

            #endregion

            #region Task5
            //Daxil edilən N ədədinin ən böyük və ən kiçik rəqəmlərinin hasilini ekrana çıxaran proqram yazın.

            Console.WriteLine("\n \n Task5 \n \n");
            Console.WriteLine("Eded daxil edin:");
            restartT5:
            int.TryParse(Console.ReadLine(),out num);
            if(num< 0)
            {
                Console.WriteLine("duzgun eded daxil edin");
                goto restartT5;
            }
            int first=num%10;
            int end=0;
            while (num > 0) {
                end= num%10;
                num /= 10;
            
            }
            int result = end * first;
            Console.WriteLine(result);


            Console.WriteLine(count);
            #endregion

            #region Task6
            // Aşağıda qeyd olunmuş patterni console-a çıxaran proqram yazın. Aşağı kənarın uzunluğunu N olsun.

            Console.WriteLine("\n \n Task6 \n \n");
            Console.WriteLine("uzunlugu daxil edin");
            restartT6:
            int.TryParse(Console.ReadLine(), out num);
            if(num<1)
            {
                Console.WriteLine("duzgun uzunluq daxil edin");
                goto restartT6;
            }
            string symbol = "*";
            for (int i = 1; i < num; i++)
            {
                    Console.WriteLine();
                for (int u = 0; u < i; u++)
                {
                    Console.Write(symbol);
                }
            }
            #endregion

        }
    }
}