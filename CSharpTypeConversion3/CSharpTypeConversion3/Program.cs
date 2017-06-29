using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypeConversion3
{
    class Program
    {
        static void Main(string[] args)
        {
            //装箱和拆箱，比较耗费计算机资源
            //装箱操作，需要在计算机内存中开辟一个空间，把值放进去
            int itoBox = 5;
            object box = itoBox;
            //拆箱操作,如果为空，则会报异常，从堆中拿出来放到栈上
            int unbox=(int)box;
            Console.WriteLine(unbox);

            //创建一个值类型可以为空
            int? inullable = 100;
            System.Nullable<int> inullable2 = 100;
            int? a = null;
            //如果 a的值为空a.Value会报异常
            //Console.WriteLine(a.Value);
            //使用HasValue,如果值为空，则返回false
            Console.WriteLine(a.HasValue);
            //如果值为空，让其返回他当前类型的默认值
            Console.WriteLine(a.GetValueOrDefault());

            //双问号 ??,如果双问号前面有值，则返回双问号前面的，如果没有则返回双问号后面的值
            int iii = a ?? 500;
            Console.WriteLine(iii);


            Console.ReadLine();
        }
    }
}
