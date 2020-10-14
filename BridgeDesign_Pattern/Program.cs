using BridgeDesign_Pattern.Lab_1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesign_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl_Tv_B remoteControl_Tv_B = new RemoteControl_Tv_B(new LedTv_B());
            remoteControl_Tv_B.On();
            remoteControl_Tv_B.GetChannel(101);
            remoteControl_Tv_B.Off();

            Console.WriteLine();
            RemoteControl_Tv_A remoteControl_Tv_A = new RemoteControl_Tv_A(new LedTv_A());
            remoteControl_Tv_A.On();
            remoteControl_Tv_A.GetChannel(101);
            remoteControl_Tv_A.Off();

            Console.ReadKey();
        }
    }
}
