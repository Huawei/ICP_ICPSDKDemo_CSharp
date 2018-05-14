using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Com.Huawei.Device.ServiceModel;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ICPDemo
{
    class Helper
    {
        /// <summary>
        /// 把对象属性拼接为字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToString(object obj)
        {
            if (obj == null)
            {
                return null;
            }
            else if (obj is AgentInfo)
            {
                return ToString((AgentInfo)obj);
            }
            else if (obj is DialContent)
            {
                return ToString((DialContent)obj);
            }
            else if (obj is CallListDetails)
            {
                return ToString((CallListDetails)obj);
            }
            else if (obj is CallListDetailsChanged)
            {
                return ToString((CallListDetailsChanged)obj);
            }
            else if (obj is WirelessDeviceInfo)
            {
                return ToString((WirelessDeviceInfo)obj);
            }
            else if (obj is SkillGroup)
            {
                return ToString((SkillGroup)obj);
            }
            else if (obj is RestReason)
            {
                return ToString((RestReason)obj);
            }
            else if (obj is LostCall)
            {
                return ToString((LostCall)obj);
            }
            else if (obj is MaliciousCall)
            {
                return ToString((MaliciousCall)obj);
            }
            else if (obj is RedList)
            {
                return ToString((RedList)obj);
            }
            else if (obj is BlackListEx)
            {
                return ToString((BlackListEx)obj);
            }
            else if (obj is BlackList)
            {
                return ToString((BlackList)obj);
            }
            else if (obj is AccessCode)
            {
                return ToString((AccessCode)obj);
            }
            else if (obj is AgentCallInfo)
            {
                return ToString((AgentCallInfo)obj);
            }
            else if (obj is IvrInfo)
            {
                return ToString((IvrInfo)obj);
            }
            else if (obj is AgentSkillGroup)
            {
                return ToString((AgentSkillGroup)obj);
            }
            else if (obj is IDictionary)
            {
                return ToString((IDictionary)obj);
            }
            else if (obj is IList)
            {
                return ToString((IList)obj);
            }
            else
            {
                return obj.ToString();
            }
        }

        public static string ToString(AgentCallInfo agentCallInfo)
        {
            if (agentCallInfo == null)
            {
                return null;
            }

            return "{callID = " + agentCallInfo.CallID
                + ", calleeNumber = " + agentCallInfo.CalleeNumber
                + ", callerNumber = " + agentCallInfo.CallerNumber
                + ", GroupName = " + agentCallInfo.GroupName
                + ", logonTime = " + agentCallInfo.LogonTime
                 + ", trunkNo = " + agentCallInfo.TrunkNo
                 + ", mediaAbility = " + agentCallInfo.mediaAbility
                + "}";
        }

        public static string ToString(BlackList blackList)
        {
            if (blackList == null)
            {
                return null;
            }
            return "{"
                + "PhoneNumber = " + blackList.PhoneNumber
                + ", Duration = " + blackList.Duration
                + ", CreatedBy = " + blackList.CreatedBy
                + ", CreateDate = " + blackList.CreateDate
                + "}";
        }

        public static string ToString(BlackListEx blackList)
        {
            if (blackList == null)
            {
                return null;
            }
            return "{"
                + "PhoneNumber = " + blackList.PhoneNumber
                + ", Duration = " + blackList.Duration
                + ", CreatedBy = " + blackList.CreatedBy
                + ", CreateDate = " + blackList.CreateDate
                + ", FilterMode = " + blackList.FilterMode
                + "}";
        }

        public static string ToString(RedList redList)
        {
            if (redList == null)
            {
                return null;
            }
            return "{"
                + "PhonePrefix = " + redList.PhonePrefix
                + ", Priority = " + redList.Priority
                + "}";
        }

        //拼接骚扰对象信息字符串
        public static string ToString(MaliciousCall maliciousCall)
        {
            if (maliciousCall == null)
            {
                return null;
            }

            return "{"
                + "CallId = " + maliciousCall.CallId
                + ", Callee = " + maliciousCall.Callee
                + ", Caller = " + maliciousCall.Caller
                + ", CallTime = " + maliciousCall.CallTime
                + "}";
        }

        //拼接丢话记录信息字符串
        public static string ToString(LostCall lostCall)
        {
            if (lostCall == null)
            {
                return null;
            }

            return "{"
                + "CallId = " + lostCall.CallId
                + ", Callee = " + lostCall.Callee
                + ", Caller = " + lostCall.Caller
                + ", Begintime = " + lostCall.Begintime
                + ", Losttime = " + lostCall.Losttime
                + "}";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentInfo"></param>
        /// <returns></returns>
        public static string ToString(AgentInfo agentInfo)
        {
            if (agentInfo == null)
            {
                return null;
            }

            return "{AgentId = " + agentInfo.AgentId
                + ", AgentStatus = " + agentInfo.AgentStatus.ToString()
                + ", AgentTpe = " + agentInfo.AgentType.ToString()
                + ", PhoneNumber = " + agentInfo.PhoneNumber
                + "}";
        }

        public static string ToString(SkillGroup skillGroup)
        {
            if (skillGroup == null)
            {
                return null;
            }

            return "{GroupId = " + skillGroup.GroupId
                + ", GroupName = " + skillGroup.GroupName.ToString()             
                + "}";
        }

        public static string ToString(RestReason restReason)
        {
            if (restReason == null)
            {
                return null;
            }

            return "{RestCode = " + restReason.RestCode.ToString()
                + ", RestReasonInfo = " + restReason.RestReasonInfo
                + "}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static string ToString(AccessCode info)
        {

            return "{"
                + "AccessCode = " + info.SystemAccessCode
                + ", MediaType = " + info.MediaType
                + ", AccessCodeDesc = " + info.AccessCodeDesc
                + "}";
        }

        //拼接IVR信息字符串
        public static string ToString(IvrInfo ivrInfo)
        {

            return "{"
                + "Id = " + ivrInfo.Id
                + ", InNo = " + ivrInfo.InNo
                + ", ServiceNo = " + ivrInfo.ServiceNo
                 + ", Description = " + ivrInfo.Description
                + "}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dialContent"></param>
        /// <returns></returns>
        public static string ToString(DialContent dialContent)
        {
            if (dialContent == null)
            {
                return null;
            }

            return "{CallId = " + dialContent.CallId
                + ", CallType = " + dialContent.CallType
                + ", DeviceId = " + dialContent.DeviceId
                + ", PhoneType = " + dialContent.PhoneType
                + ", PhoneNumber = " + dialContent.PhoneNumber
                + ", Status = " + dialContent.Status
                + "}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dialContent"></param>
        /// <returns></returns>
        public static bool NewMasterPhoneNumber(DialContent dialContent, AgentInfo agentInfo)
        {
            if (dialContent == null || agentInfo == null || string.IsNullOrEmpty(dialContent.PhoneNumber))
            {
                return false;
            }
            if (dialContent.PhoneNumber.Equals(agentInfo.PhoneNumber))
            {
                return true;
            }
            return false; ;
        }

        /// <summary>
        /// 转换CallListDetails对象为字符串
        /// </summary>
        /// <param name="callList"></param>
        /// <returns></returns>
        public static string ToString(CallListDetails callList)
        {
            if (callList == null)
            {
                return null;
            }

            return "{"
                + "CallId = " + callList.CallId
                + ", CallerNumber = " + callList.CallerNumber
                + ", CalleeNumber = " + callList.CalleeNumber
                + ", CallTime = " + callList.CallTime
                + ", CustomerLevel = " + callList.CustomerLevel
                + "}";
        }

        /// <summary>
        /// 转换CallListDetailsChanged对象为字符串
        /// </summary>
        /// <param name="callList"></param>
        /// <returns></returns>
        public static string ToString(CallListDetailsChanged callList)
        {
            if (callList == null)
            {
                return null;
            }

            return "{IsAddCall = " + callList.BIsAddCall.ToString()
                + ", CallId = " + callList.CallId
                + ", CallerNumber = " + callList.CallerNumber
                + ", CalleeNumber = " + callList.CalleeNumber
                + ", CallTime = " + callList.CallTime
                + ", CustomerLevel = " + callList.CustomerLevel
                + "}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wirelessDeviceInfo"></param>
        /// <returns></returns>
        public static string ToString(WirelessDeviceInfo wirelessDeviceInfo)
        {
            if (wirelessDeviceInfo == null)
            {
                return null;
            }

            return "{DeviceId = " + wirelessDeviceInfo.DeviceId
                + ", DeviceMode = " + wirelessDeviceInfo.DeviceMode.ToString()
                + ", DeviceName = " + wirelessDeviceInfo.DeviceName
                + ", Status = " + wirelessDeviceInfo.Status.ToString()
                + ", DeviceType = " + wirelessDeviceInfo.DeviceType
                + "}";
        }

        /// <summary>
        /// 技能队列状态信息
        /// </summary>
        /// <param name="skillGroupStatus"></param>
        /// <returns></returns>
        public static string ToString(SkillGroupStatus skillGroupStatus)
        {
            if (skillGroupStatus == null)
            {
                return null;
            }

            return "{"
                    + "AvaliableAgents = " + skillGroupStatus.AvaliableAgents
                    + ", GroupId = " + skillGroupStatus.GroupId
                    + ", EstWaitTime = " + skillGroupStatus.EstWaitTime
                    + ", LogonAgents = " + skillGroupStatus.LogonAgents
                    + ", QueueSize = " + skillGroupStatus.QueueSize
                    + ", LongestQueueTime = " + skillGroupStatus.LongestQueueTime
                    + ", GroupName = " + skillGroupStatus.GroupName
                    + "}";
        }

        /// <summary>
        /// 座席技能配置信息
        /// </summary>
        /// <param name="agentSkillGroup"></param>
        /// <returns></returns>
        public static string ToString(AgentSkillGroup agentSkillGroup)
        {
            if (agentSkillGroup == null)
            {
                return null;
            }

            return "{"
                    + "GroupId = " + agentSkillGroup.GroupId
                    + ", IsConfiged = " + agentSkillGroup.IsConfiged
                    + ", IsSignin = " + agentSkillGroup.IsSignin
                    + "}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static string ToString(IDictionary dictionary)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                return null;
            }

            StringBuilder buffer = new StringBuilder();

            buffer.Append("{");

            int count = dictionary.Count;
            int num = 0;

            foreach (DictionaryEntry item in dictionary)
            {
                num++;

                buffer.AppendFormat("{0} = {1}", item.Key, ToString(item.Value));

                if (num < count)
                {
                    buffer.Append(", ");
                }
            }

            buffer.Append("}");

            return buffer.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string ToString(IList list)
        {
            if (list == null || list.Count == 0)
            {
                return null;
            }

            StringBuilder buffer = new StringBuilder();
            buffer.Append("{");

            for (int i = 0; i < list.Count; i++)
            {
                var obj = list[i];

                buffer.Append(ToString(obj));

                if (i < list.Count - 1)
                {
                    buffer.Append(", ");
                }
            }

            buffer.Append("}");

            return buffer.ToString();
        }

        public enum OperationToken
        {
            QueryAgentStatus,
            QueryCallList,
            SelectPickup,
            ForceLogout,
            SetCallData,
            QueryMaliciousCalls,
            SetCustomerLevel,
            QuerySkillGroupStatus,
            QueryAgentSkillGroups,
            QueryCallIdOnAgent,
        }
    }
}