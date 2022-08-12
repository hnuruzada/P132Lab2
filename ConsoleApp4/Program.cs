using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//========================================================
			//Int array olsun.layihe run olduqda hansi indexdeki deyeri 
			//konsolda gormek isdeyirse hemin indexi konsoldan daxil edir ve
			//hemin konsol penceresinde gorsenir.



			//Konsoldan daxil edilen cumlede bosluqlarin sayin tapan program.//			string sentences =Console.ReadLine();
			//			var count = 0;
			//for(int i = 0; i < sentences.Length; i++)
			//			{
			//				if(sentences[i]==' ')
			//				{
			//					count++;
			//				}
			//			}

			//Console.WriteLine(count);
			//=====================================================
			//task 1
			//=====================================================

			//         // m n den boyuk deyilse ededler yeniden daxil edilsin

			//         bool isSmall;
			//         int n;
			//         int m;
			//         var count = 0;

			//do
			//{
			//             isSmall = false; 
			//              n = Convert.ToInt32(Console.ReadLine());
			//              m = Convert.ToInt32(Console.ReadLine());

			//             if(n > m )
			//	{
			//                 isSmall=true;
			//                 Console.WriteLine("ededleri yeniden daxil edin");
			//	}

			//         } while (isSmall);

			//for (int i = n; i < m; i++)
			//{
			//             if(i % 11 == 0)
			//	{
			//                 count++; 
			//	}
			//}
			//         Console.WriteLine(count); 


			//=================================================
			//

			//=================================================


			//int price1 = Convert.ToInt32(Console.ReadLine());
			//int price2 = Convert.ToInt32(Console.ReadLine());
			//int price3 = Convert.ToInt32(Console.ReadLine());

			//int sum = price1 + price2 + price3;

			//if(price1 < price2)
			//{
			//	// price 1 kicikdir
			//	if(price1 < price3)
			//	{
			//		// price 1 en kiciyidir
			//		sum -= price1;
			//	}
			//	else
			//	{
			//		// price 3 en kicikdir
			//		sum -= price3;
			//	}
			//}
			//else
			//{
			//	// price 2 kicikdir
			//	if(price2< price3)
			//	{
			//		// en kicik price 2
			//		sum -= price2;
			//	}
			//	else
			//	{
			//		// en kicik price3
			//		sum -= price3;
			//	}

			//}
			//Console.Write("toplam mebleg : ");
			//Console.WriteLine(sum);

			int[] arr = { 3, 465, 433, 65, 43, 30 };
			string index=Console.ReadLine();
			int indx=Convert.ToInt32(index);
			for(var i=0;i<arr.Length;i++)
			{
				if(i==indx)
				{
					indx=arr[i];
				}
			}
			Console.WriteLine(indx);






		}
	}
}
