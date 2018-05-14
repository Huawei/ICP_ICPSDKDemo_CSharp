using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICPDemo
{
    public class CallInfo
    {
        // 文字会话ID,即呼叫标识
        public string m_strCallId { get; set; }

        // 当前发送内容的唯一编号，当needCheck为true时，该参数生效
        public int m_iChatId { get; set; }

        // 用户访问标志
        public int m_iUvid { get; set; }

        // 呼叫主叫
        public string m_strCaller { get; set; }

        // 呼叫被叫
        public string m_strCalled { get; set; }

        // 实际主叫信息
        public string m_strRealCaller { get; set; }

        // 用户显示名称
        public string m_strDisplayName { get; set; }

        // 其他用户信息
        public string m_strUserInfo { get; set; }

        // 当前是否有呼叫
        private bool m_bIsInited;

        public void SetState(bool isInited)
        {
            m_bIsInited = isInited;
        }
    }
}
