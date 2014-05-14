
/*
 * Autor: Zyshchyk Makism
 * Email: amporioo@gmail.com
 * Date: 14.05.2014
 */
using System;
using YandexAPI.Maps;

namespace YandexAPIGetAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обратное геокодирование API Яндекс.Карт");
            string result = GeoCode.SearchObject(76.904529, 43.254999);
            var address = GeoCode.GetAddress(result);
            Console.WriteLine(address);
            Console.ReadKey(true);
        }
    }
}
