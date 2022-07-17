
using System;
using static Matematik.DortIslem;



namespace Matematik // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);
            dortIslem.Topla(6, 9);
        }
    }
}