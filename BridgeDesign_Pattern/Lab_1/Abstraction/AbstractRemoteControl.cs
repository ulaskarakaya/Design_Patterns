using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesign_Pattern.Lab_1.Abstraction
{
    public abstract class AbstractRemoteControl
    {
        protected ILEDTV ledTv;
        protected AbstractRemoteControl(ILEDTV ledTv)
        {
            this.ledTv = ledTv;
        }
        public abstract void On();
        public abstract void Off();
        public abstract void GetChannel(int channelNumber);
    }
}
