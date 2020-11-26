using SingletonDesign_Pattern.Lab_1;
using SingletonDesign_Pattern.Lab_2;
using System;

namespace SingletonDesign_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            var systemManager = SystemManager.CreateSingleObject();
            systemManager.Add();
            #endregion

            #region
            int toplma_1 = SingletonClass.Sinif.Toplam(1, 2);
            Console.WriteLine(toplma_1);
            Console.ReadKey();
            #endregion
        }
    }
}
