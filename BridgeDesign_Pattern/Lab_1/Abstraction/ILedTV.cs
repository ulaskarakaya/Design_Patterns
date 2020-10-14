using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesign_Pattern.Lab_1.Abstraction
{
    public interface ILEDTV
    {
        void On();
        void Off();
        void GetChannel(int channelNumber);
    }
}
