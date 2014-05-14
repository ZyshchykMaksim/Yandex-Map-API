/*
 * Autor: Zyshchyk Makism
 * Email: amporioo@gmail.com
 * Date: 11.05.2014
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexAPI.Maps;

namespace YandexAPIGetСoordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Прямое геокодирование API Яндекс.Карт");
            string result = GeoCode.SearchObject("Беларусь, Минск ул.Немига, 3");
            PointD pointD = GeoCode.GetPointD(result);
            Console.WriteLine(pointD);
            Console.ReadKey(true);
        }
    }
}
