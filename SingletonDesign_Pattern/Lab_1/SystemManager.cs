using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesign_Pattern.Lab_1
{
    public class SystemManager
    {
        private static SystemManager _systemManager; 

        public SystemManager()
        {
            
        }

       
        public static SystemManager CreateSingleObject()
        {

            
            if (_systemManager == null)
            {
                _systemManager = new SystemManager();
            }

            return _systemManager;
        }

        public void Add()
        {
            Console.WriteLine("An object was created..!");
            Console.ReadKey();
        }
    }
}
