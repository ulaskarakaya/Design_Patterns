using BridgeDesign_Pattern.Lab_1.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesign_Pattern.Lab_1.Concrete
{
    public class LedTv_A : ILEDTV
    {
        public void GetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Tv_A");
        }

        public void Off()
        {
            Console.WriteLine("Turning OFF :  TV_A");
        }

        public void On()
        {
            Console.WriteLine("Turning ON : Tv_A");
        }
    }
}
