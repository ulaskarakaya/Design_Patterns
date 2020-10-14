using BridgeDesign_Pattern.Lab_1.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesign_Pattern.Lab_1.Concrete
{
    public class RemoteControl_Tv_A : AbstractRemoteControl
    {
        public RemoteControl_Tv_A(ILEDTV ledTv) : base(ledTv)
        {

        }

        public override void On()
        {
            ledTv.On();
        }
        public override void Off()
        {
            ledTv.Off();
        }
        public override void GetChannel(int channelNumber)
        {
            ledTv.GetChannel(channelNumber);
        }
    }
}
