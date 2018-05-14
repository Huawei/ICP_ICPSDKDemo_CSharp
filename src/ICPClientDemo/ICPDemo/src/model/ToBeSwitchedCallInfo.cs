using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICPDemo.src.model
{
    /// <summary>
    /// 将要被切换的通话信息模型，
    /// 最多只保存一路将要被切换的通话信息
    /// </summary>
    public class ToBeSwitchedCallInfo
    {

        /// <summary>
        /// 初始化器
        /// </summary>
        public ToBeSwitchedCallInfo()
        {
            this._isToAidDevice = false;
            this._toBeSwitchedCallId = string.Empty;
        }

        private string _toBeSwitchedCallId { get; set; }

        private bool _isToAidDevice { get; set; }

        
        /// <summary>
        /// 更新将要被切换的通话信息
        /// </summary>
        /// <param name="callid">被切换的通话ID</param>
        /// <param name="isToAidDevice">是将要被切换到辅助设备</param>
        public void UpdateToBeSwitchedCallInfo(string callid, bool isToAidDevice)
        {
            this._toBeSwitchedCallId = callid;
            this._isToAidDevice = isToAidDevice;
        }


        /// <summary>
        /// 删除将要被切换的通话
        /// </summary>
        public void DeleteToBeSwitchedCallInfo()
        {
            this._isToAidDevice = false;
            this._toBeSwitchedCallId = string.Empty;
        }
        
        /// <summary>
        /// 获取将要切换的通话ID
        /// </summary>
        /// <returns></returns>
        public string GetToBeSwitchedCallId()
        {
            return this._toBeSwitchedCallId;
        }

        /// <summary>
        /// 是否要被切换到辅助声卡
        /// </summary>
        /// <returns></returns>
        public bool IsSwitchToAidDevice()
        {
            return this._isToAidDevice;
        }
    }
}
