using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment03
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> input) => input.SelectMany(x=>x).ToList();
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate) => items.Where(i => predicate(i));
        public static IEnumerable<int> Filter2(this IEnumerable<int> items) => items.Where(i => (i % 7 == 0 && i > 42));
        public static bool IsSecure(this Uri uri) => uri.ToString().StartsWith("https://");
        public static int WordCount(this string text) => Regex.Split(text, @"\P{L}+").Count();
    }
}
