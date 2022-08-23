using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generic_examples
{

    class Program
    {
        
        public static int[] ConvertAll { get; private set; }

        public static string Methodum1<T>(T a) => a.ToString();
        public static List<int> Methodum2<T>(T[] array)
        {
            var list = new List<int>();
            foreach (var m in array)
                list.Add(Convert.ToInt32(m));
            return list;
        }
        public static List<T> Methodum6<T>(Dictionary<T,object> b)
        {
            var list = new List<T>();
            foreach (T m in b.Keys)
                list.Add(m);
            return list;
        }
        public static List<double > Methodum3<T>(T[] array3)
        {
            var list3 = new List<double>();
            foreach (T n in array3)
                list3.Add(Convert.ToDouble(n));
            return list3;
        }
        public static List<T> Methodum5<T>(T[] array5)
        {
            var list5 = new List<T>();
            foreach (T item in array5)
                list5.Add(item);
            return list5;
        }
        public static List<T>Methodum7<T>(Dictionary<object,T>d)
        {
            var list7 = new List<T>();
            foreach (T item in d.Values)
                list7.Add(item);
            return list7;
        }
        public static List<T> Methodum4<T>(ArrayList arrayList)
        {
            List<T> list4 = new List<T>();
            foreach (object item in arrayList)
                if(item.GetType()==typeof(T))
                    list4.Add((T)item);
            return list4;
        }
        public static T[,] Methodum8<T>(Dictionary<T, T> s)
        {
            var keys = s.Keys.ToArray();
            var values = s.Values.ToArray();
            T[,] matris = new T[2, values.Length];
            for (int i = 0; i <= matris.GetUpperBound(1); i++)
            {
                matris[0, i] = keys[i];
                matris[1, i] = values[i];

            }
            return matris;
        }
        public static bool SadeEded(int a,int b)
        {
            for (int i= a; i < b; a++)
            {
                
                    if ( a % i == 0)
                    return false;
                
                
            }
            return true;
        }
        static void Main(string[] args)
        { 
            var result1 =  Methodum1<int>(12);
            int[] nums = { 2, 45, 67, 23, 67, 12, };
            //var result3 = Methodum3<double>(nums);
            Console.WriteLine(SadeEded(4,16));

        }
        
    }
}
