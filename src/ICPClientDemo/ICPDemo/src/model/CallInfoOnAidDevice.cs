using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICPDemo.src.model
{
    /// <summary>
    /// 辅助设备上的通话信息模型
    /// </summary>
    public class CallInfoOnAidDevice
    {
        private string _callId { get; set; }

        //private bool _isGroupTalking { get; set; }

        private bool _hasTalkingOnAidDevice { get; set; }

        public void UpdateCallInfoOnAidDevice(string callID, bool isGroupTalking)
        {
            this._callId = callID;
            this._hasTalkingOnAidDevice = true;
        }

        /// <summary>
        /// 初始化器
        /// </summary>
        public CallInfoOnAidDevice()
        {
            this._callId = String.Empty;
            this._hasTalkingOnAidDevice = false;
            //this._isGroupTalking = false;
        }

        /// <summary>
        /// 判断是否有通话在辅助声卡
        /// </summary>
        /// <returns></returns>
        public bool HasTalkingOnAidDevice()
        {
            return this._hasTalkingOnAidDevice;
        }

        /// <summary>
        /// 若有通话在辅助声卡上则返回CallID
        /// 若没有则返回string.Empty
        /// </summary>
        /// <returns></returns>
        public string GetCallID()
        {
            if (!this._hasTalkingOnAidDevice)
            {
                return string.Empty;
            }

            return this._callId;
        }
    }
}
