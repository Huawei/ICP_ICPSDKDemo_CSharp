using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasSoftPhoneTester
{
    public class ToBeSwitchedCallInfo
    {

        public ToBeSwitchedCallInfo()
        {
            this._isToAidDevice = false;
            this._toBeSwitchedCallId = string.Empty;
        }

        private string _toBeSwitchedCallId { get; set; }

        private bool _isToAidDevice { get; set; }

        public void UpdateToBeSwitchedCallInfo(string callid, bool isToAidDevice)
        {
            this._toBeSwitchedCallId = callid;
            this._isToAidDevice = isToAidDevice;
        }

        public void DeleteToBeSwitchedCallInfo()
        {
            this._isToAidDevice = false;
            this._toBeSwitchedCallId = string.Empty;
        }

        public string GetToBeSwitchedCallId()
        {
            return this._toBeSwitchedCallId;
        }

        public bool IsSwitchToAidDevice()
        {
            return this._isToAidDevice;
        }
    }
}
