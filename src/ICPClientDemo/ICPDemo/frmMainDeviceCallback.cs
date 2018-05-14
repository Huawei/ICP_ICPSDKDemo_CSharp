using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Com.Huawei.Device.Contract;
using Com.Huawei.Device.ServiceModel;
using Com.Huawei.Device;
using AD;

namespace ICPDemo
{
    /// <summary>
    /// 设备回调接口实现
    /// </summary>
    public partial class frmMainDeviceCallback : IDeviceEventsAdapter
    {
        /// <summary>
        /// 返回代码548,首次登录必须修改密码
        /// </summary>
        private const int ICD_548 = 548;

        static frmMain main = null;
        //ToBeSwitchedCallInfo _toBeSwitchedCallInfo = new ToBeSwitchedCallInfo();
        private static frmMainDeviceCallback mainDeviceCallback = null;
        public static frmMainDeviceCallback GetMainDeviceCallback(frmMain frmmain)
        {
            if (mainDeviceCallback == null)
            {
                mainDeviceCallback = new frmMainDeviceCallback();
                main = frmmain;
            }
            return mainDeviceCallback;
        }

        /// <summary>
        /// 将对象转换为Json字符串
        /// </summary>
        /// <param name="input">待转换对象</param>
        /// <returns></returns>
        public static string Serialize(object input)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            var result = jss.Serialize(input);
            return result;
        }

        /// <summary>
        /// 将Json字符串转换为T类型对象
        /// </summary>
        /// <typeparam name="T">转换类型</typeparam>
        /// <param name="input">待转换字符串</param>
        /// <returns></returns>
        public static T Deserialize<T>(string input)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            return jss.Deserialize<T>(input);
        }

        /// <summary>
        /// 将字节数组转换为T类型对象
        /// </summary>
        /// <typeparam name="T">转换类型</typeparam>
        /// <param name="input">待转换字节数组</param>
        /// <returns></returns>
        public static T Deserialize<T>(byte[] input)
        {
            string strInput = System.Text.Encoding.UTF8.GetString(input);

            return Deserialize<T>(strInput);
        }

        /// <summary>
        ///话机联动信息
        /// </summary>
        public override void OnLinkageResultNotify(string callId, int result)
        {
            main.WriteLog("Device back: OnLinkageResultNotify. callId = {0}, result = {1}", callId, result);
        }

        /// <summary>
        /// 重置技能队列
        /// </summary>
        public override void OnResetAgentSkillGroupsResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnResetAgentSkillGroupsResult. callId = {0},flag = {1},errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 成员加入事件
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="dialContent"></param>
        public override void OnMeetingMemberJoin(string callId, string meetingId, DialContent dialContent)
        {
            main.WriteLog("Device back: OnMeetingMemberJoin. callId = {0},meetingId = {1},dialContent={2}", callId, meetingId, Helper.ToString(dialContent));
            main.OnAddMeetingDialContent(dialContent);
        }

        /// <summary>
        /// 请求耳语
        /// </summary>
        public override void OnWhisperResult(string callId, string agentId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnWhisperResult. callId = {0},agentId = {1},flag = {2},errorCode = {3}", callId, agentId, flag, errorCode);
        }

        /// <summary>
        /// 停止质检
        /// </summary>
        public override void OnSuperviseStopResult(string callId, string agentId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSuperviseStopResult. callId = {0},agentId = {1},flag = {2},errorCode = {3}", callId, agentId, flag, errorCode);
        }

        /// <summary>
        /// 被耳语
        /// </summary>
        public override void OnBeWhispered(string callId, AgentInfo agentInfo, AgentInfo fromAgentInfo)
        {
            main.WriteLog("Device back: OnBeWhispered. callId = {0},agentInfo = {1},fromAgentInfo = {2}", callId, Helper.ToString(agentInfo), Helper.ToString(fromAgentInfo));
        }

        /// <summary>
        /// 被侦听
        /// </summary>
        public override void OnBeMonitored(string callId, AgentInfo agentInfo, AgentInfo fromAgentInfo)
        {
            main.WriteLog("Device back: OnBeMonitored. callId = {0},agentInfo = {1},fromAgentInfo = {2}", callId, Helper.ToString(agentInfo), Helper.ToString(fromAgentInfo));
        }

        /// <summary>
        /// 质检切换
        /// </summary>
        public override void OnSuperviseSwitchResult(string callId, string agentId, int operType, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSuperviseSwitchResult. callId = {0},agentId = {1},operType = {2} ,flag = {3},errorCode = {4}", callId, agentId, operType, flag, errorCode);
        }

        /// <summary>
        /// 被停止质检
        /// </summary>
        public override void OnBeStopSupervise(string callId, AgentInfo agentInfo, AgentInfo fromAgentInfo, int operType)
        {
            main.WriteLog("Device back: OnBeStopSupervise. callId = {0},agentInfo = {1},fromAgentInfo = {2}, operType = {3}", callId, Helper.ToString(agentInfo), Helper.ToString(fromAgentInfo), operType);
        }

        /// <summary>
        /// 静音/取消静音
        /// </summary>
        public override void OnMuteResult(string callId, bool isMute, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnMuteResult. callId = {0},isMute = {1},flag = {2},errorCode = {3}", callId, isMute, flag, errorCode);
        }

        /// <summary>
        /// 会议主席变更
        /// </summary>
        public override void OnMeetingMasterChange(string callId, string meetingId, DialContent newMaster)
        {
            main.WriteLog("Device back: OnMeetingMasterChange. callId = {0},meetingId = {1},newMaster = {2}", callId, meetingId, Helper.ToString(newMaster));
        }

        /// <summary>
        /// 会议成员属性变更
        /// </summary>
        public override void OnChangeMeetingMemberModeResult(string callId, string meetingId, DialContent dialContent, int attribute, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnChangeMeetingMemberModeResult. callId = {0},meetingId = {1},dialContent = {2} , attribute = {3} , flag = {4},errorCode = {5}", callId, meetingId, Helper.ToString(dialContent), attribute,flag, errorCode);
        }

        /// <summary>
        /// 与会者变更通知（主动返回）
        /// </summary>
        public override void OnMeetingMemberModeChange(string callId, string meetingId, DialContent dialContent, int attribute)
        {
            main.WriteLog("Device back: OnMeetingMemberModeChange, callId = {0}, meetingId = {1},dialContent = {2}, attribute = {3}", callId, meetingId, Helper.ToString(dialContent), attribute);
        }

        /// <summary>
        /// 查询当前座席所有呼叫信息
        /// </summary>
        public override void OnQueryCallInfoResult(string callId, List<AgentCallInfo> agentCallInfos, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryCallInfoResult. callId = {0},agentCallInfos = {1},flag = {2},errorCode = {3}", callId, Helper.ToString(agentCallInfos), flag, errorCode);
        }

        //查询休息原因返回事件
        public override void OnQueryRestReasonsResult(string callId, List<RestReason> listRestReason, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryRestReasonsResult, callId = {0},listRestReason = {1},flag = {2},errorCode = {3}", callId, Helper.ToString(listRestReason), flag, errorCode);
            main.GetRestReasons(listRestReason);
        }

        /// <summary>
        /// 邀请的会议成员振铃
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="dialContent"></param>
        public override void OnMeetingMemberAlerting(string callId, string meetingId, DialContent dialContent)
        {
            main.WriteLog("Device back: OnMeetingMemberAlerting. callId = {0},meetingId = {1},dialContent={2}", callId, meetingId, Helper.ToString(dialContent));
        }

        /// <summary>
        /// 呼出状态返回【主动返回】
        /// </summary>
        /// <param name="dialContent"></param>
        /// <param name="status"></param>
        public override void OnCallOutStatusChange(DialContent dialContent, OpStatus status)
        {
            main.WriteLog("Device back: OnCallOutStatusChange. dialContent = {0},status = {1}", Helper.ToString(dialContent), status);
        }

        //停止指定文字交谈呼叫
        public override void OnReleaseCallExWithCCBIdxResult(string callId, int mediaType, int CCBIdx, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnReleaseCallExWithCCBIdxResult. callId = {0},mediaType = {1},CCBIdx = {2}, flag = {3}, errorCode = {4}", callId, mediaType, CCBIdx, flag, errorCode);
            if (flag)
            {
                //关闭相应短信窗口
                main.OnCloseSMS(mediaType, CCBIdx);
            }
        }

        //坐席主动发送短信后，侦听到用户短信接收确认事件
        public override void OnClientDataWithoutCallConfirm(string callId, int confirmerType, string confirmer, int ulDataSeqNo)
        {
            main.WriteLog("Device back: OnClientDataWithoutCallConfirm.callId={0}, confirmerType = {1},confirmer = {2},ulDataSeqNo = {3}", callId, confirmerType, confirmer, ulDataSeqNo);
        }

        //坐席主动发送短信后，侦听到用户短信接收失败事件
        public override void OnClientDataWithoutCallFail(string callId, int confirmerType, string confirmer, int ulDataSeqNo)
        {
            main.WriteLog("Device back: OnClientDataWithoutCallFail.callId={0}, confirmerType = {1},confirmer = {2},ulDataSeqNo = {3}", callId, confirmerType, confirmer, ulDataSeqNo);
        }

        //ad by m00371151 for V8
        public override void OnCallInPrivateQueue(string callId, bool isInternalCall, string callerNumber, string calleeNumber, string customLevel)
        {
            main.LastCallInPrivateQueue = callId;
            main.WriteLog("Device back: OnCallInPrivateQueue callId={0},isInternalCall={1},callerNumber={2},calleeNumber={3}", callId, isInternalCall, callerNumber, calleeNumber);
        }

        public override void OnCallOutPrivateQueue(string callId, string callerNumber, string calleeNumber, string reason, string causeId)
        {
            main.WriteLog("Device back: OnCallOutPrivateQueue callId={0},callerNumber={1},calleeNumber={2},reason={3}, causeId={4}", callId, callerNumber, calleeNumber, reason, causeId);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="lockTime"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnAddToBlackListResult(string callId, string phoneNumber, int lockTime, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnAddToBlackListResult, callId = {0}, phoneNumber = {1}, lockTime = {2}, flag = {3}, errorCode = {4}", callId, phoneNumber, lockTime, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="agentInfo"></param>
        public override void OnAgentStatusChange(string callId, AgentInfo agentInfo)
        {
            main.WriteLog("Device back: OnAgentStatusChange, callId = {0}, agentInfo = {1}", callId, Helper.ToString(agentInfo));

            main.UpdateAgentStatus(agentInfo.AgentStatus);
            //会议时主动退出或者被主席移除时，关闭会议界面
            if ("Busy".Equals(agentInfo.AgentStatus.ToString()) || "Idle".Equals(agentInfo.AgentStatus.ToString()))
            {
                main.OnEndMeeting();//关闭会议窗口
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="dialContent"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnAnswerCallResult(string callId, DialContent dialContent, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnAnswerCallResult, callId = {0}, dialContent = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(dialContent), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="dialContent"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnSnatchPickUpAnswer(string callId, DialContent dialContent)
        {
            main.WriteLog("Device back: OnSnatchPickUpAnswer, callId = {0}, dialContent = {1}", callId, Helper.ToString(dialContent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="agentInfo"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnBargeResult(string callId, AgentInfo agentInfo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnBargeResult, callId = {0}, agentInfo = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(agentInfo), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="agentInfo"></param>
        /// <param name="fromAgentInfo"></param>
        public override void OnBeBarged(string callId, AgentInfo agentInfo, AgentInfo fromAgentInfo)
        {
            main.WriteLog("Device back: OnBeBarged, callId = {0}, agentInfo = {1}, fromAgentInfo = {2}", callId, Helper.ToString(agentInfo), Helper.ToString(fromAgentInfo));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="strToAgentId"></param>
        /// <param name="fromAgentInfo"></param>
        public override void OnBeForceReleased(string callId, AgentInfo agentInfo, AgentInfo fromAgentInfo)
        {
            main.WriteLog("Device back: OnBeForceReleased, callId = {0}, agentInfo = {1}, fromAgentInfo = {2}", callId, Helper.ToString(agentInfo), Helper.ToString(fromAgentInfo));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="agentInfo"></param>
        /// <param name="fromAgentInfo"></param>
        public override void OnBeSnatchedPickup(string callId, AgentInfo agentInfo, AgentInfo fromAgentInfo)
        {
            main.WriteLog("Device back: OnBeSnatchedPickup, callId = {0}, agentInfo = {1}, fromAgentInfo = {2}", callId, Helper.ToString(agentInfo), Helper.ToString(fromAgentInfo));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="oldMaster"></param>
        /// <param name="newMaster"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnBeTransferMaster(string callId, string meetingId, DialContent oldMaster, DialContent newMaster, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnBeTransferMaster, callId = {0}, meetingId = {1}, oldMaster = {2}, newMaster = {3}, flag = {4}, errorCode = {5}", callId, meetingId, Helper.ToString(oldMaster), Helper.ToString(newMaster), flag, errorCode);

            if (flag && Helper.NewMasterPhoneNumber(newMaster, main._agentInfo))
            {
                main.OnStartMeeting(meetingId);
                //会议主席把会议权限转移给当前柜员后，当前柜员更新会议成员列表
                main.QueryMeetingMembers(meetingId);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="sourceAgent"></param>
        /// <param name="targetAgent"></param>
        public override void OnBeTransfer(string callId, AgentInfo sourceAgent, AgentInfo targetAgent)
        {
            main.WriteLog("Device back: OnBeTransfer, callId = {0}, sourceAgent = {1}, targetAgent = {2}", callId, Helper.ToString(sourceAgent), Helper.ToString(targetAgent));
        }

        public EventHandler<CallListDetailsChanged> CallListChanged = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callList"></param>
        public override void OnCallListChange(string callId, CallListDetailsChanged callList)
        {
            main.WriteLog("Device back: OnCallListChange, callId = {0}, callList = {1}", callId, Helper.ToString(callList));
            if (CallListChanged != null)
            {
                CallListChanged(callId, callList);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="mode"></param>
        public override void OnConnection(string callId, DeviceModule mode)
        {
            main.WriteLog("Device back: OnConnection, callId = {0}, mode = {1}", callId, mode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="dialContent"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnConsultCallResult(string callId, DialContent dialContent, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnConsultCallResult, callId = {0}, dialContent = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(dialContent), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnCreateMeetingResult(string callId, string meetingId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnCreateMeetingResult, callId = {0}, meetingId = {1}, flag = {2}, errorCode = {3}", callId, meetingId, flag, errorCode);

            if (flag)
            {
                main.OnStartMeeting(meetingId);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="dialContent"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnDialResult(string callId, DialContent dialContent, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnDialResult, callId = {0}, dialContent = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(dialContent), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="mode"></param>
        public override void OnDisConnection(string callId, DeviceModule mode)
        {
            main.WriteLog("Device back: OnDisConnection, callId = {0}, mode = {1}", callId, mode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnEndConsultCallResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnEndConsultCallResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnEndMeetingResult(string callId, string meetingId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnEndMeetingResult, callId = {0}, meetingId = {1}, flag = {2}, errorCode = {3}", callId, meetingId, flag, errorCode);

            if (flag)
            {
                main.OnEndMeeting();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="errorCode"></param>
        public override void OnError(string callId, int errorCode)
        {
            main.WriteLog("Device back: OnError, callId = {0}, errorCode = {1}", callId, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnExitMeetingResult(string callId, string meetingId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnExitMeetingResult, callId = {0}, meetingId = {1}, flag = {2}, errorCode = {3}", callId, meetingId, flag, errorCode);
            if (flag)
            {
                main.OnEndMeeting();//关闭会议窗口
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="agentInfo"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnForceLogoutResult(string callId, AgentInfo agentInfo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnForceLogoutResult, callId = {0}, agentInfo = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(agentInfo), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="agentInfo"></param>
        public override void OnBeForceLogout(string callId, AgentInfo agentInfo)
        {
            main.WriteLog("Device back: OnBeForceLogout, callId = {0}, agentInfo = {1}", callId, Helper.ToString(agentInfo));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="agentInfo"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnForceReleaseResult(string callId, AgentInfo agentInfo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnForceReleaseResult, callId = {0}, agentInfo = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(agentInfo), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="length"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnGetRecordLengthResult(string callId, int length, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnGetRecordLengthResult, callId = {0}, length = {1}, flag = {2}, errorCode = {3}", callId, length, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnHangUpResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnHangUpResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
            if (flag)
            {
                main.OnEndMeeting();//如果是会议主席挂断，关闭会议关系窗口
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="holdMode"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnHoldResult(string callId, HoldMode holdMode, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnHoldResult, callId = {0}, holdMode = {1}, flag = {2}, errorCode = {3}", callId, holdMode, flag, errorCode);
        }

        public override void OnCallHold(string callId, HoldMode holdMode, HoldReason holdReason)
        {
            main.WriteLog("Device back: OnCallHold, callId = {0}, holdMode = {1}, holdReason = {2}", callId, holdMode, holdReason);
        }

        public override void OnHoldByCallIdResult(string callId, HoldMode holdMode, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnHoldByCallIdResult, callId = {0}, holdMode = {1}, flag = {2}, errorCode = {3}", callId, holdMode, flag, errorCode);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="agentInfo"></param>
        /// <param name="settings"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnInitializeResult(string callId, AgentInfo agentInfo, Dictionary<string, string> settings, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnInitializeResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
            if (errorCode == ICD_548)
            {
                main.btnChangeAgentPwd.PerformClick();
            }
        }

        /// <summary>
        /// add by xiezhengquan for AR. eSDK.001.001.001
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="agentInfo"></param>
        /// <param name="settings"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnSetCustomizedRecordInfoResult(string callId, int num, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSetCustomizedRecordInfoResult, callId = {0}, num = {1}, flag = {2}, errorCode = {3}", callId, num, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="dialContent"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnInvitedMeeting(string callId, string meetingId, DialContent dialContent, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnInvitedMeeting, callId = {0}, meetingId = {1}, dialContent = {2}, flag = {3}, errorCode = {4}", callId, meetingId, Helper.ToString(dialContent), flag, errorCode);
            if (flag)
            {
                //普通会议成员也有会议主席管理界面
                main.OnStartMeeting(meetingId);
                //更新会议成员列表
                main.QueryMeetingMembers(meetingId);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="dialContent"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnInviteMeetingMemberResult(string callId, string meetingId, DialContent dialContent, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnInviteMeetingMemberResult, callId = {0}, meetingId = {1}, dialContent = {2}, flag = {3}, errorCode = {4}", callId, meetingId, Helper.ToString(dialContent), flag, errorCode);

            if (!flag)
            {
                dialContent.Status = MeetingStatus.Faulted;
            }
            main.OnAddMeetingDialContent(dialContent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="dialContent"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnLeaveMeeting(string callId, string meetingId, DialContent dialContent)
        {
            main.WriteLog("Device back: OnLeaveMeeting, callId = {0}, meetingId = {1}, dialContent = {2}", callId, meetingId, Helper.ToString(dialContent));
            main.OnEndMeeting();//关闭会议窗口
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnMakeMeetingResult(string callId, string meetingId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnMakeMeetingResult, callId = {0}, meetingId = {1}, flag = {2}, errorCode = {3}", callId, meetingId, flag, errorCode);

            if (flag)
            {
                main.OnStartMeeting(meetingId);
                //更新会议成员列表
                main.QueryMeetingMembers(meetingId);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="dialContent"></param>
        public override void OnMeetingMemberExit(string callId, string meetingId, DialContent dialContent)
        {
            main.WriteLog("Device back: OnMeetingMemberExit, callId = {0}, meetingId = {1}, dialContent = {2}", callId, meetingId, Helper.ToString(dialContent));
            main.OnRemoveMeetingMember(dialContent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="agentInfo"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnMonitorResult(string callId, AgentInfo agentInfo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnMonitorResult, callId = {0}, agentInfo = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(agentInfo), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="agentInfo"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnMonitorToBargeResult(string callId, AgentInfo agentInfo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnMonitorToBargeResult, callId = {0}, agentInfo = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(agentInfo), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="agentInfo"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnMonitorToForceReleaseResult(string callId, AgentInfo agentInfo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnMonitorToForceReleaseResult, callId = {0}, agentInfo = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(agentInfo), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callerType"></param>
        /// <param name="callerNumber"></param>
        /// <param name="calleeType"></param>
        /// <param name="calleeNumber"></param>
        public override void OnNewCall(string callId, DeviceType callerType, string callerNumber, DeviceType calleeType, string calleeNumber)
        {
            main.WriteLog("Device back: OnNewCall, callId = {0}, callerType = {1}, callerNumber = {2}, calleeType = {3}, calleeNumber = {4}", callId, callerType, callerNumber, calleeType, calleeNumber);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="agentCallInfo "></param>
        public override void OnNewCallWithCallInfo(string callId, DeviceType callerType, DeviceType calleeType, AgentCallInfo agentCallInfo)
        {
            main.WriteLog("Device back: OnNewCallWithCallInfo, callId = {0}, callerType = {1}, calleeType = {2}, agentCallInfo = {3}", callId, callerType, calleeType, Helper.ToString(agentCallInfo));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="otherAgentInfo"></param>
        /// <param name="sponsorAgentInfo"></param>
        public override void OnOtherBeForceRelease(string callId, AgentInfo otherAgentInfo, AgentInfo sponsorAgentInfo)
        {
            main.WriteLog("Device back: OnOtherBeForceRelease, callId = {0}, otherAgentInfo = {1}, sponsorAgentInfo = {2}", callId, Helper.ToString(otherAgentInfo), Helper.ToString(sponsorAgentInfo));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="dialContent"></param>
        public override void OnOtherHangup(string callId, DialContent dialContent)
        {
            main.WriteLog("Device back: OnOtherHangup, callId = {0}, dialContent = {1}", callId, Helper.ToString(dialContent));

            if (main._agentStatus == OpStatus.MultiTalking)
            {
                main.OnRemoveMeetingMember(dialContent);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPlayRecordPauseResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPlayRecordPauseResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="recordId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPlayRecordResult(string callId, string recordId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPlayRecordResult, callId = {0}, recordId = {1}, flag = {2}, errorCode = {3}", callId, recordId, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPlayRecordResumeResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPlayRecordResumeResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPlayRecordSeekToResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPlayRecordSeekToResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPlayRecordStopResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPlayRecordStopResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="nTotalLength"></param>
        /// <param name="nPlayLength"></param>
        /// <param name="status"></param>
        public override void OnPlayStatus(string callId, int nTotalLength, int nPlayLength, bool status)
        {
            main.WriteLog("Device back: OnPlayStatus, callId = {0}, nTotalLength = {1}, nPlayLength = {2}, status = {3}", callId, nTotalLength, nPlayLength, status);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="pttOperate"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPTTResult(string callId, PTTOperate pttOperate, string pttLevel, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPTTResult, callId = {0}, pttOperate = {1}, pttLevel = {2}, flag = {3}, errorCode = {4}", callId, pttOperate, pttLevel, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="number"></param>
        /// <param name="agentId"></param>
        /// <param name="pttOperate"></param>
        public override void OnMeetingPTTStatusChange(string callId, string number, string agentId, PTTOperate pttOperate)
        {
            main.WriteLog("Device back: OnMeetingPTTStatusChange, callId = {0}, number = {1}, agentId = {2}, pttOperate = {3}", callId, number, agentId, pttOperate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="agentInfo"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnQueryAgentStatusResult(string callId, AgentInfo agentInfo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryAgentStatusResult, callId = {0}, agentInfo = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(agentInfo), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="groupId"></param>
        /// <param name="agentInfos"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnQueryAllAgentStatusResult(string callId, List<AgentInfo> agentInfos, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryAllAgentStatusResult, callId = {0}, agentInfos = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(agentInfos), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="wirelessDeviceInfos"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnQueryAllWirelessDeviceResult(string callId, List<WirelessDeviceInfo> wirelessDeviceInfos, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryAllWirelessDeviceResult, callId = {0}, wirelessDeviceInfos = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(wirelessDeviceInfos), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callListDetails"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnQueryCallListByGroupIdResult(string callId, List<CallListDetails> callListDetails, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryCallListByGroupIdResult, callId = {0}, callListDetails = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(callListDetails), flag, errorCode);
            if (CallListChanged != null)
            {
                foreach (CallListDetails call in callListDetails)
                {
                    CallListDetailsChanged detail = new CallListDetailsChanged();
                    detail.BIsAddCall = true;
                    detail.CallerNumber = call.CallerNumber;
                    detail.CallId = call.CallId;
                    detail.GroupId = call.GroupId;
                    detail.CustomerLevel = call.CustomerLevel;  //优先级
                    CallListChanged(callId, detail);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnStopQueryCallListByGroupIdResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnStopQueryCallListByGroupIdResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="phoneScope"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnQueryCurrentCallingScopeResult(string callId, CallingPhoneScope phoneScope, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryCurrentCallingScopeResult, callId = {0}, phoneScope = {1}, flag = {2}, errorCode = {3}", callId, phoneScope, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="wirelessDeviceInfo"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnQueryUsingWirelessDeviceResult(string callId, WirelessDeviceInfo wirelessDeviceInfo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryUsingWirelessDeviceResult, callId = {0}, wirelessDeviceInfo = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(wirelessDeviceInfo), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="wirelessDeviceInfo"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnQueryWirelessInfoResult(string callId, WirelessDeviceInfo wirelessDeviceInfo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryWirelessInfoResult, callId = {0}, wirelessDeviceInfo = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(wirelessDeviceInfo), flag, errorCode);
        }

        /// <summary>
        /// 新短信消息【主动返回】
        /// </summary>
        public override void OnReceiveSMS(string callId, int mediaType, int CCBIdx, string callNumber, string receiveTime, string note)
        {
            main.WriteLog("Device back: OnReceiveSMS, callId = {0},mediaType={1}, CCBIdx={2},callNumber = {3}, receiveTime = {4}, note = {5}", callId, mediaType, CCBIdx, callNumber, receiveTime, note);
            string reTime = receiveTime;
            var dt = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)).AddSeconds(int.Parse(receiveTime)); ;
            if (null != dt)
            {
                reTime = dt.ToString("yyyy-MM-dd HH:mm:ss");
            }
            //收到消息后，更新或者弹出消息框
            main.OnAddSMS(mediaType, CCBIdx, callNumber, reTime, note);
        }

        /// <summary>
        ///多媒体呼叫（短信）释放通知
        /// </summary>
        public override void OnReceiveReleaseSMS(string callId, int MediaType, int CCBIdx)
        {
            main.WriteLog("Device back: OnReceiveReleaseSMS, callId = {0},  MediaType = {1}, CCBIdx = {2}", callId, MediaType, CCBIdx);
            //关闭相应短信窗口
            main.OnCloseSMS(MediaType, CCBIdx);
        }

        /// <summary>
        /// 短信回复结果事件
        /// </summary> 
        public override void OnReplySMSResult(string callId, string phoneNumber, string note, int ulSeqNo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnReplySMSResult, callId = {0}, phoneNumber = {1}, note = {2}, ulSeqNo = {3}, flag = {4}, errorCode = {5}", callId, phoneNumber, note, ulSeqNo, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnRemoveAllBlackListResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnRemoveAllBlackListResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnRemoveFromBlackListResult(string callId, string phoneNumber, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnRemoveFromBlackListResult, callId = {0}, phoneNumber = {1}, flag = {2}, errorCode = {3}", callId, phoneNumber, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="dialContent"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnRemoveMeetingMemberResult(string callId, string meetingId, DialContent dialContent, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnRemoveMeetingMemberResult, callId = {0}, meetingId = {1}, dialContent = {2}, flag = {3}, errorCode = {4}", callId, meetingId, Helper.ToString(dialContent), flag, errorCode);
            int meetNoMember = 60100;   //成员不存在
            if (flag || errorCode == meetNoMember)
            {
                main.OnRemoveMeetingMember(dialContent);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="dialContent"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnSelectPickupResult(string callId, DialContent dialContent, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSelectPickupResult, callId = {0}, dialContent = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(dialContent), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="deviceId"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="note"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnSendSMSResult(string callId, string phoneNumber, string note, int ulSeqNo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSendSMSResult, callId = {0},phoneNumber = {1}, note = {2},ulSeqNo={3}, flag = {4}, errorCode = {5}", callId, phoneNumber, note, ulSeqNo, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="status"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnSetBusyResult(string callId, OpStatus status, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSetBusyResult, callId = {0}, status = {1}, flag = {2}, errorCode = {3}", callId, status, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="status"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnSetIdleResult(string callId, OpStatus status, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSetIdleResult, callId = {0}, status = {1}, flag = {2}, errorCode = {3}", callId, status, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="sourceAgent"></param>
        /// <param name="targetNumber"></param>
        /// <param name="flag"></param>
        /// <param name="iErrorCode"></param>
        public override void OnSingleStepTransferResult(string callId, string sourceAgent, string targetNumber, bool flag, int iErrorCode)
        {
            main.WriteLog("Device back: OnSingleStepTransferResult, callId = {0}, sourceAgent = {1}, targetNumber = {2}, flag = {3}, errorCode = {4}", callId, sourceAgent, targetNumber, flag, iErrorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="agentInfo"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnSnatchPickupResult(string callId, AgentInfo agentInfo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSnatchPickupResult, callId = {0}, agentInfo = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(agentInfo), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="fileName"></param>
        /// <param name="numbers"></param>
        public override void OnStartRecord(string callId, string recordId, string fileName, List<string> numbers)
        {
            main.WriteLog("Device back: OnStartRecord, callId = {0}, recordId = {1}, fileName = {2}, numbers = {3}", callId, recordId, fileName, Helper.ToString(numbers));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="fileName"></param>
        /// <param name="numbers"></param>
        /// <param name="callSessionId"></param>
        /// <param name="mediaAbility"></param>
        public override void OnStartRecordEx(string callId, string recordId, string fileName, List<string> numbers, string callSessionId, MediaAbility mediaAbility)
        {
            main.WriteLog("Device back: OnStartRecordEx, callId = {0}, recordId = {1}, fileName = {2}, numbers = {3}, callSessionId = {4}, mediaAbility = {5}", callId, recordId, fileName, Helper.ToString(numbers), callSessionId, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="dAgentId"></param>
        /// <param name="sAgentId"></param>
        /// <param name="nCallId"></param>
        /// <param name="oCallId"></param>
        /// <param name="callType"></param>
        /// <param name="callNumber"></param>
        /// <param name="isOutPhone"></param>
        public override void OnTransferInform(string callId, string dAgentId, string sAgentId, string nCallId, string oCallId, DeviceType callType, string callNumber, bool isOutPhone)
        {
            main.WriteLog("Device back: OnTransferInform, callId = {0}, dAgentId = {1}, sAgentId = {2}, nCallId = {3}, oCallId = {4}, callType = {5}, callNumber = {6}, isOutPhone = {7}", callId, dAgentId, sAgentId, nCallId, oCallId, callType, callNumber, isOutPhone);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="oldMasterNumber"></param>
        /// <param name="newMasterNumber"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnTransferMeetingMasterResult(string callId, string meetingId, string oldMasterNumber, string newMasterNumber, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnTransferMeetingMasterResult, callId = {0}, meetingId = {1}, oldMasterNumber = {2}, newMasterNumber = {3}, flag = {4}, errorCode = {5}", callId, meetingId, oldMasterNumber, newMasterNumber, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnTransferToAgentResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnTransferToAgentResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnUnInitializeResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnUnInitializeResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnUnInitializeAllResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnUnInitializeAllResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="wirelessDeviceInfo"></param>
        /// <param name="strAgentId"></param>
        public override void OnWirelessUseStatus(string callId, WirelessDeviceInfo wirelessDeviceInfo, string strAgentId)
        {
            main.WriteLog("Device back: OnWirelessUseStatus, callId = {0}, wirelessDeviceInfo = {1}, strAgentId = {2}", callId, Helper.ToString(wirelessDeviceInfo), strAgentId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="dialContent"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnYieldAnswerCall(string callId, string meetingId, DialContent dialContent, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnYieldAnswerCall, callId = {0}, meetingId = {1}, dialContent = {2}, flag = {3}, errorCode = {4}", callId, meetingId, Helper.ToString(dialContent), flag, errorCode);
            //如果是会议主席，就在界面上新增了，在OnQueryMeetingMembersResult事件中已增加，避免界面重复显示主席工号和电话两个，2016-07-12
            if (!main._agentInfo.PhoneNumber.Equals(dialContent.PhoneNumber))
            {
                main.OnAddMeetingDialContent(dialContent);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="dialContent"></param>
        public override void OnMeetingMemberStateChange(string callId, string meetingId, DialContent dialContent)
        {
            main.WriteLog("Device back: OnMeetingMemberStateChange, callId = {0}, meetingId = {1}, meetingId = {2}, dialContent = {3}", callId, meetingId, Helper.ToString(dialContent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="phoneStatus"></param>
        /// <param name="dialContent"></param>
        public override void OnAdvancedOtherHangUp(string callId, OpStatus phoneStatus, DialContent dialContent)
        {
            main.WriteLog("Device back: OnAdvancedOtherHangUp, callId = {0}, phoneStatus = {1}, dialContent = {2}", callId, phoneStatus, Helper.ToString(dialContent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        public override void OnReportPTTOff(string callId, string number, PTTOperate pttOperate, string reason)
        {
            main.WriteLog("Device back: OnReportPTTOff, callId = {0}, number = {1}, pttOperate = {2}, reason = {3}", callId, number, pttOperate, reason);
        }

        /// <summary>
        /// 请求休息结果返回
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="status"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnRestResult(string callId, OpStatus status, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnRestResult, callId = {0}, status = {1}, flag = {2}, errorCode = {3}", callId, status, flag, errorCode);
        }

        /// <summary>
        /// 取消休息结果返回
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="status"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnCancelRestResult(string callId, OpStatus status, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnCancelRestResult, callId = {0}, status = {1}, flag = {2}, errorCode = {3}", callId, status, flag, errorCode);
        }

        /// <summary>
        /// 休息超时
        /// </summary>
        /// <param name="callId">休息超时标识</param>
        /// <param name="restTime">座席请求休息的时间</param>
        public override void OnRestTimeOut(string callId, int restTime)
        {
            main.WriteLog("Device back: OnRestTimeOut, callId = {0}, restTime = {1}", callId, restTime);
        }

        /// <summary>
        /// 单步会议
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnSingleStepMeetingResult(string callId, string meetingId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSingleStepMeetingResult, callId = {0}, meetingId = {1}, flag = {2}, errorCode = {3}", callId, meetingId, flag, errorCode);
            if (flag)
            {
                main.OnStartMeeting(meetingId);
            }
        }

        /// <summary>
        /// 轮询呼叫
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="dialContent"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPollingCallResult(string callId, DialContent dialContent, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPollingCallResult, callId = {0}, dialContent = {1},flag={2}, errorCode = {3}", callId, Helper.ToString(dialContent), flag, errorCode);
        }

        /// <summary>
        /// 查询黑名单
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="phoneNumberList"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnQueryBlackListResult(string callId, string phoneNumber, DateTime createTime, int Locktime, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryBlackListResult, callId = {0}, phoneNumber = {1},createTime = {2}, Locktime = {3}, flag = {4} errorCode = {5}", callId, phoneNumber, createTime.ToString(), Locktime, flag, errorCode);
        }

        /// <summary>
        /// 查询某个会议中所有会议成员结果返回
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="meetingId">会议编号</param>
        /// <param name="members">会议成员列表集</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnQueryMeetingMembersResult(string callId, string meetingId, string chairManPhone, List<DialContent> members, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryMeetingMembersResult, callId = {0},meetingId = {1},chairManPhone = {2} ,members = {3}, flag = {4}, errorCode = {5}", callId, meetingId, chairManPhone, Helper.ToString(members), flag, errorCode);
            if (flag && members != null && members.Count > 0)
            {
                //更新会议界面列表时先清空
                main.OnClearList();
                foreach (var dialContent in members)
                {
                    main.OnAddMeetingDialContent(dialContent);
                }
            }
        }

        /// <summary>
        /// 转移结果
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="sourceAgent">发起转移的坐席</param>
        /// <param name="targetNumber">转移的目标号码</param>
        /// <param name="flag">标志位。true 成功， false 失败</param>
        /// <param name="iErrorCode">错误码</param>
        public override void OnSingleStepSuccTransferResult(string callId, string sourceAgent, string targetNumber, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSingleStepSuccTransferResult, callId = {0},sourceAgent = {1} ,targetNumber = {2}, flag = {3}, errorCode = {4}", callId, sourceAgent, targetNumber, flag, errorCode);
        }

        /// <summary>
        ///  修改座席密码
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnChangeAgentPwdResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnChangeAgentPwdResult, callId = {0},flag = {1}, errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 取消优先级名单
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnRemoveFromRedListResult(string callId, string phoneNumber, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnRemoveFromRedListResult, callId = {0}, phoneNumber = {1}, flag = {2}, errorCode = {3}", callId, phoneNumber, flag, errorCode);
        }

        /// <summary>
        /// 移除全部优先级名单
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnRemoveAllRedListResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnRemoveAllRedListResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 查询是否是优先级名单
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnQueryRedListResult(string callId, string phoneNumber, int priority, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryRedListResult, callId = {0}, phoneNumber = {1}, priority = {2}, flag = {3}, errorCode = {4}", callId, phoneNumber, priority, flag, errorCode);
        }

        /// <summary>
        /// 设置优先级名单结果
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="phoneNumber">电话号码</param>
        /// <param name="priority">名单优先级</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnAddToRedListResult(string callId, string phoneNumber, int priority, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnAddToRedListResult, callId = {0},phoneNumber = {1},priority = {2},flag = {3}, errorCode = {4}", callId, phoneNumber, priority, flag, errorCode);
        }

        /// <summary>
        /// 座席主动发送邮件结果返回
        /// </summary>
        /// <param name="callId">呼叫标识</param>
        /// <param name="index">发送的邮件的索引号</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnSendEmailResult(string callId, string index, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSendEmailResult, callId = {0},index = {1},flag = {2},errorCode = {3}", callId, index, flag, errorCode);
        }

        /// <summary>
        /// 座席回复邮件结果返回
        /// </summary>
        /// <param name="callId">呼叫标识</param>
        /// <param name="flag">呼叫标识</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnReplyEmailResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnReplyEmailResult, callId = {0},flag = {1},errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 新邮件消息到达座席侧接收通知事件，由设备侧主动推送过来
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="emailCallId">邮件呼叫ID</param>
        /// <param name="receiveTime">邮件呼叫到送时间。注：不是指收到邮件内容的时间</param>
        public override void OnReceiveEmail(string bHandle, string emailCallId, string receiveTime)
        {
            main.WriteLog("Device back: OnReceiveEmail, callId = {0},emailCallId = {1},receiveTime = {2}", bHandle, emailCallId, receiveTime);
            main.ReceiveEmail(bHandle, emailCallId, receiveTime);
        }

        /// <summary>
        /// 获取发送的邮件索引号结果返回
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="emailIndex">发送的邮件索引号，必须是4个字节数字</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnGetSendEmailIndexResult(string callId, int emailIndex, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnGetSendEmailIndexResult, callId = {0},emailCallId = {1},flag = {2},errorCode = {3}", callId, emailIndex, flag, errorCode);
            main.GetSendEmailIndexResult(callId, emailIndex, flag, errorCode);
        }

        /// <summary>
        /// 查询指定座席邮件配置信息结果返回
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="pop3Svr">POP3服务器地址</param>
        /// <param name="smtpSvr">SMTP服务器地址</param>
        /// <param name="receiveEmailAddr">座席私有接收邮箱地址</param>
        /// <param name="sendEmailAddr">座席私有发送邮箱地址</param>
        /// <param name="emailUserName">邮箱用户名</param>
        /// <param name="emailPwd">邮箱密码</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnQueryAgentEmailCfgInfoResult(string callId, string pop3Svr, string smtpSvr, string receiveEmailAddr, string sendEmailAddr, string emailUserName, string emailPassword, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryAgentEmailCfgInfoResult, callId = {0},pop3Svr = {1},smtpSvr = {2},receiveEmailAddr = {3},sendEmailAddr = {4},emailUserName = {5},emailPassword = {6},flag = {7},errorCode = {8}",
                                                     callId, pop3Svr, smtpSvr, receiveEmailAddr, sendEmailAddr, emailUserName, "****", flag, errorCode);
        }

        /// <summary>
        /// 该事件催促座席尽快处理Email呼叫
        /// </summary>
        public override void OnAgentReceiveEmailRemind()
        {
            main.WriteLog("Device back: OnAgentReceiveEmailRemind");
        }

        /// <summary>
        /// 停止mail呼叫回调函数
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnReleaseMailCall(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnReleaseMailCall, callId = {0}, flag = {1},errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 坐席电话振铃信息通知。该事件由设备侧主动推送至上层应用
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="callerType">主叫设备类型</param>
        /// <param name="callerNumber">主叫号码</param>
        /// <param name="calleeType">被叫设备类型</param>
        /// <param name="calleeNumber">被叫号码</param>
        public override void OnPhoneAlerting(string callId, DeviceType callerType, string callerNumber, DeviceType calleeType, string calleeNumber)
        {
            main.WriteLog("Device back: OnPhoneAlerting, callId = {0}, callerType = {1}, callerNumber = {2}, calleeType = {3}, calleeNumber = {4}", callId, callerType, callerNumber, calleeType, calleeNumber);
        }

        /// <summary>
        /// 坐席电话振铃时，对方挂机事件
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="dialContent">对方呼叫信息</param>
        public override void OnPhoneAlertOtherHungup(string callId, DialContent dialContent)
        {
            main.WriteLog("Device back: OnPhoneAlertOtherHungup, callId = {0}, dialContent = {1}", callId, Helper.ToString(dialContent));
        }

        /// <summary>
        /// 座席电话摘机事件。该事件由设备侧主动推送至上层应用
        /// </summary>
        public override void OnPhoneOffhook()
        {
            main.WriteLog("Device back: OnPhoneOffhook");
        }

        /// <summary>
        /// 座席电话挂机事件。该事件由设备侧主动推送至上层应用
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="dialContent">对方呼叫信息</param>
        public override void OnPhoneHungup(string callId, DialContent dialContent)
        {
            if (null != main.localVideoForm && null != main.remoteVideoForm)
            {
                main.localVideoForm.Hide();
                main.remoteVideoForm.Hide();
            }

            main.WriteLog("Device back: OnPhoneHungup, callId = {0}, dialContent = {1}", callId, Helper.ToString(dialContent));
        }

        /// <summary>
        /// 设置呼叫后是否进入整理态返回
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnSetAutoEnterIdleResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSetAutoEnterIdleResult, callId = {0},flag = {1},errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 设置是否进入关班状态返回
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnSetWorkStopResult(string callId, bool bwork, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSetWorkStopResult, callId = {0},bwork = {1},flag = {2},errorCode = {3}", callId, bwork, flag, errorCode);
        }

        /// <summary>
        /// 查询系统的技能队列结果
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="SkillGroups">技能队列</param>
        /// <param name="flag">true：成功，false：失败</param>
        /// <param name="errorCode">错误码</param>
        public override void OnQuerySkillGroupsResult(string callId, List<SkillGroup> skillGroups, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQuerySkillGroupsResult, callId = {0},skillGroups = {1},flag = {2},errorCode = {3}", callId, Helper.ToString(skillGroups), flag, errorCode);
            if (flag)
            {
                main.GetAgentSkill(skillGroups);
            }
        }

        /// <summary>
        /// 转技能队列结果
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="flag">true：成功，false：失败</param>
        /// <param name="errorCode">错误码</param>
        public override void OnTransferToSkillGroupResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnTransferToSkillGroupResult, callId = {0},flag = {1},errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 查询骚扰记录返回
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="MaliciousCalls">查询结果集合</param>
        /// <param name="flag">true：成功，false：失败</param>
        /// <param name="errorCode">错误码</param>
        public override void OnQueryMaliciousCallsResult(string callId, List<MaliciousCall> maliciousCalls, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryMaliciousCallsResult, callId = {0} , maliciousCalls = {1} , flag = {2}, errorCode = {3}", callId, Helper.ToString(maliciousCalls), flag, errorCode);
        }

        /// <summary>
        /// 查询丢话记录返回
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="lostCalls">查询结果集合</param>
        /// <param name="flag">true：成功，false：失败</param>
        /// <param name="errorCode">错误码</param>
        public override void OnQueryLostCallsResult(string callId, List<LostCall> lostCalls, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryLostCallsResult, callId = {0} , lostCalls = {1} , flag = {2},errorCode = {3}", callId, Helper.ToString(lostCalls), flag, errorCode);
        }

        /// <summary>
        /// 查询丢话记录数量
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="lostCalls">查询数量</param>
        /// <param name="flag">true：成功，false：失败</param>
        /// <param name="errorCode">错误码</param>
        public override void OnQueryLostCallsCountResult(string callId, int callsCount, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryLostCallsCountResult, callId = {0} , callsCount = {1} , flag = {2},errorCode = {3}", callId, callsCount, flag, errorCode);
        }

        /// <summary>
        /// 查询所有红名单记录返回
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="lostCalls">查询结果集合</param>
        /// <param name="flag">true：成功，false：失败</param>
        /// <param name="errorCode">错误码</param>
        public override void OnQueryAllRedListResult(string callId, List<RedList> redList, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryAllRedListResult, callId = {0} , redList = {1} , flag = {2},errorCode = {3}", callId, Helper.ToString(redList), flag, errorCode);
        }

        /// <summary>
        /// 查询所有红黑单记录返回
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="lostCalls">查询结果集合</param>
        /// <param name="flag">true：成功，false：失败</param>
        /// <param name="errorCode">错误码</param>
        public override void OnQueryAllBlackListResult(string callId, List<BlackList> blackList, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryAllBlackListResult, callId = {0} , blackList = {1} , flag = {2},errorCode = {3}", callId, Helper.ToString(blackList), flag, errorCode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="url"></param>
        /// <param name="numbers"></param>
        public override void OnEndRecord(string callId, string recordId, List<string> numbers)
        {
            main.WriteLog("Device back: OnEndRecord, callId = {0}, recordId = {1}, numbers = {2}", callId, recordId, Helper.ToString(numbers));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="url"></param>
        public override void OnEndPlayRecord(string callId, string recordId)
        {
            main.WriteLog("Device back: OnEndPlayRecord, callId = {0}, recordId = {1}", callId, recordId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="url"></param>
        /// <param name="errorCode"></param>
        public override void OnRecordFailure(string callId, string recordId, string errorCode)
        {
            main.WriteLog("Device back: OnRecordFailure, callId = {0}, url = {1}, errorCode = {2}", callId, recordId, errorCode);
        }
        /// <summary>
        /// 根据CallId释放呼叫返回
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnDisconnectCallResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnDisconnectCallResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 查询所有系统接入码配置信息
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="systemInfos"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnQueryAccessCodeListResult(string callId, List<AccessCode> accessCodeList, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryAccessCodeListResult, callId = {0}, accessCodeList = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(accessCodeList), flag, errorCode);
        }

        /// <summary>
        /// 呼叫返回 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="dialContent"></param>
        /// <param name="accessCode"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnDialExResult(string callId, DialContent dialContent, string accessCode, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnDialExResult, callId = {0}, dialContent = {1},accessCode = {2} ,flag = {3}, errorCode = {4}", callId, Helper.ToString(dialContent), accessCode, flag, errorCode);
        }

        /// <summary>
        /// 创建会议扩展返回
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="accessCode"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnCreateMeetingExResult(string callId, string meetingId, string accessCode, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnCreateMeetingExResult, callId = {0}, meetingId = {1}, accessCode ={2},flag = {3}, errorCode = {4}", callId, meetingId, accessCode, flag, errorCode);

            if (flag)
            {
                main.OnStartMeeting(meetingId);
            }
        }

        /// <summary>
        /// ConsultCallEx
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="dialContent"></param>
        /// <param name="accessCode"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public void OnConsultCallExResult(string callId, DialContent dialContent, string accessCode, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnConsultCallExResult, callId = {0}, dialContent = {1},accessCode ={2}, flag = {3}, errorCode = {4}", callId, Helper.ToString(dialContent), accessCode, flag, errorCode);
        }

        /// <summary>
        /// 单步会议拓展
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="meetingId"></param>
        /// <param name="accessCode"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public void OnSingleStepMeetingExResult(string callId, string meetingId, string accessCode, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSingleStepMeetingExResult, callId = {0}, meetingId = {1},accessCode ={2}, flag = {3}, errorCode = {4}", callId, meetingId, accessCode, flag, errorCode);
            if (flag)
            {
                main.OnStartMeeting(meetingId);
                //更新会议成员列表
                main.QueryMeetingMembers(meetingId);
            }
        }
        
        /// <summary>
        /// 轮询呼叫
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="dialContent"></param>
        /// <param name="accessCode"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPollingCallExResult(string callId, DialContent dialContent, string accessCode, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPollingCallExResult, callId = {0}, dialContent = {1},accessCode = {2},flag={3}, errorCode = {4}", callId, Helper.ToString(dialContent), accessCode, flag, errorCode);
        }

        /// <summary>
        /// 二次拨号
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">错误码</param>
        public override void OnAgentSendDTMFResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnAgentSendDTMFResult, callId = {0},flag={1}, errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 二次拨号扩展事件
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="DTMFDigits">发送的DTMF字符串</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">错误码</param>
        public override void OnAgentSendDTMFResultEvent(string callId, string DTMFDigits, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnAgentSendDTMFResultEvent, callId={0}, dtmf={1}, flag={2}, errorCode={3}", 
                callId, DTMFDigits, flag, errorCode);
        }

        /// <summary>
        /// 查询IVR流程信息
        /// </summary>
        /// <param name="IvrInfos">IVR</param>
        /// <param name="callid">标识</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">错误码</param>
        public override void OnQueryIVRInfoResult(List<IvrInfo> IvrInfos, string callid, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryIVRInfoResult, IvrInfos = {0},callId = {1},  flag = {2}, errorCode = {3}", Helper.ToString(IvrInfos), callid, flag, errorCode);
        }

        /// <summary>
        /// 设置是否自动应答结果
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="isAutoAnswer">true 自动应答，false 不自动应答</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">错误码</param>
        public override void OnSetAutoAnswerResult(string callId, bool isAutoAnswer, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSetAutoAnswerResult, callId = {0}, isAutoAnswer = {1}, flag = {2}, errorCode = {3}", callId, isAutoAnswer, flag, errorCode);
        }

        /// <summary>
        /// 设置呼叫随路数据结果
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="callData">待设置的呼叫随路数据</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">错误码</param>
        public override void OnSetCallDataResult(string callId, string callData, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSetCallDataResult, callId = {0}, callData = {1}, flag = {2}, errorCode = {3}", callId, callData, flag, errorCode);
        }

        /// <summary>
        /// 获取呼叫随路数据结果
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="callData">待获取的呼叫随路数据</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">错误码</param>
        public override void OnQueryCallDataResult(string callId, string callData, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryCallDataResult, callId = {0}, callData = {1}, flag = {2}, errorCode = {3}", callId, callData, flag, errorCode);
        }

        /// <summary>
        /// 设置呼叫的客户级别结果
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="phoneNumber">当前语音通话的客户电话号码</param>
        /// <param name="level">客户级别</param>
        /// <param name="flag">true 成功，false 失败</param>
        /// <param name="errorCode">错误码</param>
        public override void OnSetCustomerLevelResult(string callId, string phoneNumber, int level, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSetCustomerLevelResult, callId = {0}, phoneNumber = {1}, level = {2}, flag = {3} , errorCode = {4}", callId, phoneNumber, level, flag, errorCode);
        }

        /// <summary>
        /// 呼叫转IVR
        /// </summary>
        /// <param name="callid"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnTransferToIVRResult(string callid, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnTransferToIVRResult, callid = {0}, flag = {1}, errorCode = {2}", callid, flag, errorCode);
        }

        /// <summary>
        /// 以挂起转方式转自动成功后，座席处于挂起状态，自动流程执行结束后呼叫会自动回到该座席，这时候接续控件触发OnReturnFromIvr 事件
        /// </summary>
        public override void OnReturnFromIvr()
        {
            main.WriteLog("Device back: OnReturnFromIvr.");
        }

        /// <summary>
        /// 获取该坐席的IP地址
        /// </summary>
        /// <param name="agentId">座席工号</param>
        /// <param name="ip">ip</param>
        /// <param name="flag">标识 true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnQueryAgentIPResult(string agentId, string ip, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryAgentIPResult, agentId = {0},ip = {1} ,flag = {2}, errorCode = {3}", agentId, ip, flag, errorCode);
        }

        /// <summary>
        /// 短信可以成功转转给其他座席
        /// </summary>
        /// <param name="callId">呼叫标识</param>
        /// <param name="flag">标识 true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnTransferSMSToAgentResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnTransferSMSToAgentResult, callid = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
            if (flag)
            {
                //关闭相应短信窗口
                main.OnCloseSMS(1, main.iCCBIdx);
            }
        }

        /// <summary>
        /// 久不应答通知
        /// </summary>
        /// <param name="callId">呼叫标识</param>
        /// <param name="dialContent">呼叫信息</param>
        public override void OnLongNoAnswer(string callId, DialContent dialContent)
        {
            main.WriteLog("Device back: OnLongNoAnswer, callId = {0}, dialContent = {1}", callId, Helper.ToString(dialContent));
        }

        /// <summary>
        /// 座席话机无法应答通知
        /// </summary>
        /// <param name="callId">呼叫标识</param>
        /// <param name="dialContent">呼叫信息</param>
        public override void OnPhoneBusy(string callId, DialContent dialContent)
        {
            main.WriteLog("Device back: OnPhoneBusy, callId = {0}, dialContent = {1}", callId, Helper.ToString(dialContent));
        }     

        /// <summary>
        /// 查询座席callId结果返回
        /// </summary>
        /// <param name="callId">呼叫标识</param>
        /// <param name="agentId">座席工号</param>
        /// <param name="callIDs">查询到的座席CallId集合</param>
        /// <param name="flag">标识 true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnQueryCallIDOnAgentResult(string callId, string agentId, string callIDs, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryCallIDOnAgentResult, callId = {0}, agentId = {1}, callIDs = {2}, flag = {3}, errorCode = {4}", callId, agentId, callIDs, flag, errorCode);
        }

        /// <summary>
        /// 查询呼叫队列状态结果返回
        /// </summary>
        /// <param name="callId">呼叫标识</param>
        /// <param name="groupId">技能队列</param>
        /// <param name="skillGroupStatus">查询到队列状态信息</param>
        /// <param name="flag">标识 true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnQuerySkillGroupStatusResult(string callId, string groupId, SkillGroupStatus skillGroupStatus, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQuerySkillGroupStatusResult, callId = {0}, groupId = {1},  skillGroupStatus = {2} , flag = {3},  errorCode = {4}", callId, groupId, Helper.ToString(skillGroupStatus), flag, errorCode);
        }

        /// <summary>
        /// 查询座席配置的技能队列信息结果返回
        /// </summary>
        /// <param name="callId">呼叫标识</param>
        /// <param name="AgentSkillGroups">座席配置的技能队列信息</param>
        /// <param name="flag">标识 true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnQueryAgentSkillGroupsResult(string callId, List<AgentSkillGroup> AgentSkillGroups, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryAgentSkillGroupsResult, callId = {0}, AgentSkillGroups = {1} , flag = {2},  errorCode = {3}", callId, Helper.ToString(AgentSkillGroups), flag, errorCode);          
        }

        /// <summary>
        /// 主动发送便签结果返回
        /// </summary>
        /// <param name="callId">呼叫标识</param>
        /// <param name="agentID">目标座席工号</param>
        /// <param name="msgContent">便签消息</param>
        /// <param name="flag">标识 true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnSendMessageResult(string callId, string agentID, string msgContent, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSendMessageResult, callId = {0},agentID = {1}， msgContent = {2} , flag = {3},  errorCode = {4}", callId, agentID, msgContent, flag, errorCode);           
        }

        /// <summary>
        /// 接收便签主动返回
        /// </summary>
        /// <param name="agentId">发送方座席工号</param>
        /// <param name="msgContent">便签消息</param>
        public override void OnReceiveMessage(string agentId, string msgContent)
        {
            main.WriteLog("Device back: OnReceiveMessage, agentId = {0}, msgContent = {1}", agentId, msgContent);
        }

        /// <summary>
        /// 退出整理态结果返回
        /// </summary>
        /// <param name="callId">呼叫标识</param>
        /// <param name="flag">标识 true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnExitACWResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnExitACWResult, callId = {0}, flag = {1},  errorCode = {2}", callId, flag, errorCode);
        }

        /// <summary>
        /// 订阅座席事件返回
        /// </summary>
        /// <param name="callId">呼叫标识</param>
        /// <param name="flag">标识 true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnSubscribeAgentEventResult(string callId, string agentid, string eventType, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSubscribeAgentEventResult, callId = {0}, agentid={1}, eventType={2}, flag = {3},  errorCode = {4}", callId, agentid, eventType, flag, errorCode);
        }

        /// <summary>
        /// 取消订阅座席事件返回
        /// </summary>
        /// <param name="callId">呼叫标识</param>
        /// <param name="flag">标识 true 成功，false 失败</param>
        /// <param name="errorCode">失败原因</param>
        public override void OnStopSubscribeAgentEventResult(string callId, string agentid, string eventType, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnStopSubscribeAgentEventResult, callId = {0}, agentid={1}, eventType={2}, flag = {3},  errorCode = {4}", callId, agentid, eventType, flag, errorCode);
        }

        /// <summary>
        /// 取消订阅座席事件返回
        /// </summary>
        /// <param name="agentid">座席工号</param>
        /// <param name="eventType">事件类型</param>
        /// <param name="eventInfo">事件信息</param>
        public override void OnAgentEventNotify(string agentid, string eventType, string eventInfo)
        {
            main.WriteLog("Device back: OnAgentEventNotify, agentid = {0}, eventType = {1},  eventInfo = {2}", agentid, eventType, eventInfo);
        }
        //VC call realted

        public override void OnEndRecordVCCall(string callId, string conferenceId, string recordId, string fileName, List<string> numbers)
        {
            main.WriteLog("Device back: OnEndRecordVCCall, callId = {0}, conferenceId = {1},  recordId = {2} , fileName = {3} , numbers={4}", callId, conferenceId, recordId, fileName,string.Concat("(",string.Join(",",numbers.ToArray()),")"));
        }

        public override void OnHangupVCCallResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnHangupVCCallResult, callId = {0}, flag = {1},  errorCode = {2}", callId, flag, errorCode);
        }

        public override void OnNewVCCall(string callid, DeviceType callerType, string callNumber, DeviceType calleeType, string calleeNumber)
        {
            main.WriteLog("Device back: OnNewVCCall, callId = {0}, callerType = {1},  callNumber = {2},  calleeType = {3},  calleeNumber = {4}", callid, callerType, callNumber, callerType, calleeNumber);
        }

        public override void OnOtherVCCallHangup(string callId, DialContent dialContent)
        {
            main.WriteLog("Device back: OnOtherVCCallHangup, callId = {0}, dialContent = {1}", callId, Helper.ToString(dialContent));
        }

        public override void OnPickupVCCallResult(string callId, DialContent dialContent, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPickupVCCallResult, callId = {0}, dialContent = {1}, flag = {2}, errorCode = {3}", callId, Helper.ToString(dialContent),flag,errorCode);
        }

        public override void OnStartRecordVCCall(string callId, string conferenceId, string recordId, string fileName, List<string> numbers)
        {
            main.WriteLog("Device back: OnStartRecordVCCall, callId = {0}, conferenceId = {1},  recordId = {2} , fileName = {3} , numbers={4}", callId, conferenceId, recordId, fileName, string.Concat("(", string.Join(",", numbers.ToArray()), ")"));
        }

        public override void OnVCCallLongNoAnswer()
        {
            main.WriteLog("Device back: OnVCCallLongNoAnswer");
        }

        public override void OnVCPhoneStatusNotify(string callId, DialContent dialContent, string status)
        {
            main.WriteLog("Device back: OnVCPhoneStatusNotify, callId = {0}, dialContent = {1}, status = {2}", callId, Helper.ToString(dialContent), status);
        }

        public override void OnVCPhoneStatusNotify(string status)
        {
            main.WriteLog("Device back: OnVCPhoneStatusNotify, status = {0}", status);
        }

        public override void OnDummyCallArrive(string callId, string callNo, string callData)
        {
            main.WriteLog("Device back: OnDummyCallArrive, callId = {0},callNo={1},callData={2}",callId,callNo,callData);
            main.Dial(callNo);
        }

        public override void OnVCCallRecordFail(string errorCode)
        {
            main.WriteLog("Device back: OnVCCallRecordFail, errorCode = {0}", errorCode);
        }

		/// <summary>
        /// 新增黑名单扩展
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="lockTime"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnAddToBlackListExResult(string callId, string phoneNumber, int lockTime, short filterMode, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnAddToBlackListExResult, callId = {0}, phoneNumber = {1}, lockTime = {2}, filterMode = {3}, flag = {4}, errorCode = {5}", callId, phoneNumber, lockTime, filterMode, flag, errorCode);
        }

        /// <summary>
        /// 查询黑名单
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="phoneNumberList"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnQueryBlackListExResult(string callId, string phoneNumber, DateTime createTime, int Locktime, short filterMode, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryBlackListExResult, callId = {0}, phoneNumber = {1},createTime = {2}, Locktime = {3}, filterMode = {4}, flag = {5} errorCode = {6}", callId, phoneNumber, createTime.ToString(), Locktime, filterMode, flag, errorCode);
        }

        /// <summary>
        /// 查询所有红黑单记录返回
        /// </summary>
        /// <param name="callId">标识</param>
        /// <param name="lostCalls">查询结果集合</param>
        /// <param name="flag">true：成功，false：失败</param>
        /// <param name="errorCode">错误码</param>
        public override void OnQueryAllBlackListExResult(string callId, List<BlackListEx> blackList, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryAllBlackListExResult, callId = {0} , blackList = {1} , flag = {2},errorCode = {3}", callId, Helper.ToString(blackList), flag, errorCode);
        }
        
        public override void OnLinkageCalloutNotify(int ulTime, int usDsn, int ucHandle, int ucServer, int iCallerType, int iCalleeType, string Caller, string Called)
        {
            main.WriteLog("Device back: OnLinkageCalloutNotify Caller={0} Called={1}", Caller, Called);
        }

        public override void OnLinkagePhoneStatus(int status)
        {
            main.WriteLog("Device back: OnLinkagePhoneStatus status={0}", status);
        }
          
		public override void OnReceiveP2PSMS(string callNumber, string receiveTime, string note)
        {
            main.WriteLog("Device back: OnReceiveP2PSMS, callNumber = {0}, receiveTime={1}, note={2}", callNumber, receiveTime, note);
        }

        public override void OnDownloadRecordFileResult(string callId, string localFileName, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnDownloadRecordFileResult, callId = {0}, localFileName={1}, flag={2}, errorCode={3}", callId, localFileName, flag, errorCode);
        }

        public override void OnSubscriberCallListChangeResult(string callId, Dictionary<String, List<CallListDetails>> callListDetailMap, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSubscriberCallListChangeResult callId={0},callListDetailMap={1}, flag={2}, errorCode = {3}", callId, Helper.ToString(callListDetailMap), flag, errorCode);
        }
        public override void OnStopSubscriberCallListChangeResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnStopSubscriberCallListChangeResult callId={0}, flag={1}, errorCode = {2}", callId, flag, errorCode);
        }

        public override void OnPhoneJointLoginResult(string callId, bool flag, int errorCode)
        {
            if (flag)
            {
                main.HasSelectedGroupTalking = false;
            }

            main.WriteLog("Device back: OnPhoneJointLoginResult, flag = {0}, errorCode = {1}\r\n", flag, errorCode);
        }

        /// <summary>
        /// 话机同步登出结果事件
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneJointLogoutResult(string callId, bool flag, int errorCode)
        {
            if (flag)
            {
                main.HasSelectedGroupTalking = false;
            }
            
            main.WriteLog("Device back: OnPhoneJointLogoutResult, flag = {0}, errorCode = {1}\r\n", flag, errorCode);
        }

        /// <summary>
        /// 话机初始化结果上报事件
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="phoneMode"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneInitializeResult(string callId, PhoneUsedMode phoneMode, bool flag, int errorCode)
        {
            main.CallSessionIDOnAidDevice = string.Empty;
            main.IsTalkingOnAidDevice = false;

            if (flag)
            {
                //main.m_ToBeSwitchedCallInfo.DeleteToBeSwitchedCallInfo();
            }

            main.WriteLog("Device back: OnPhoneInitializeResult, flag = {0}, errorCode = {1}, phoneMode = {2}\r\n", flag, errorCode, phoneMode);
        }

        /// <summary>
        /// 请求应答话机呼叫，支持联动场景和内置软电话非联动场景
        /// </summary>
        /// <param name="callSessionId"></param>
        /// <param name="callerNumber"></param>
        /// <param name="calleeNumber"></param>
        /// <param name="isEmergencyCall"></param>
        /// <param name="callType"></param>
        public override void OnPhoneAnswerRequestEx(string callSessionId, string callerNumber, string calleeNumber, bool isEmergencyCall, int callType)
        {
            main.callSessionID = callSessionId;
            
            main.WriteLog("Device back: OnPhoneAnswerRequestEx callSessionId = {0}, callerNumber = {1}, calleeNumber = {2}, isEmergencyCall = {3}, callType= {4}\r\n", callSessionId, callerNumber, calleeNumber, isEmergencyCall, callType);
        }

        public override void OnPhoneAnswerRequest(string callSessionId, string callerNumber, string calleeNumber, bool isEmergencyCall)
        {
            main.callSessionID = callSessionId;

            main.WriteLog("Device back: OnPhoneAnswerRequest callSessionId = {0}, callerNumber = {1}, calleeNumber = {2}, isEmergencyCall = {3}\r\n", callSessionId, callerNumber, calleeNumber, isEmergencyCall);
        }

        public override void OnPhoneAnswerRequestEx2(PhoneCallInfo callinfo)
        {
            main.callSessionID = callinfo.callSessionId;

            main.WriteLog("Device back: OnPhoneAnswerRequestEx2 callSessionId = {0}, callerNumber = {1}, calleeNumber = {2}, isEmergencyCall = {3}, callType= {4}, mediaAbility= {5}\r\n", 
                callinfo.callSessionId, callinfo.callerNumber, callinfo.calleeNumber, callinfo.isEmergencyCall, callinfo.callType, callinfo.mediaAbility);

            if (MediaAbility.Audio == callinfo.mediaAbility)
            {
                main.IsAudioCallout = true;
            }
            else
            {
                main.IsAudioCallout = false;
            }
        }

        /// <summary>
        /// 应答话机呼叫请求结果事件
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callSessionId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneAnswerResult(string callId, string callSessionId, bool flag, int errorCode)
        {
            if (true == flag)
            {
                main.callSessionID = callSessionId;
            }
                        
            main.WriteLog("Device back: OnPhoneAnswerResult callID = {0}, callSessionId = {1}, flag = {2}, errorCode = {3}\r\n", callId, callSessionId, flag, errorCode);
        }

        /// <summary>
        /// 应答话机视频呼叫请求结果事件
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callSessionId"></param>
        /// <param name="isVideo"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneAnswerExResult(string callId, string info, bool flag, int errorCode)
        {
            if (null != info)
            {
                PhoneAnswerParam AnswerParam = SerializeHelper.DeSerialize<PhoneAnswerParam>(info);

                if (true == flag)
                {
                    main.callSessionID = AnswerParam.callSessionId;
                }

                //视频应答成功则显示视频窗口
                if (AnswerParam.isVideo == true && flag == true)
                {
                    main.localVideoForm.StartPosition = FormStartPosition.CenterParent;
                    main.localVideoForm.Text = ConfigHelper.GetString("LocalVideoFrm");
                    main.localVideoForm.Show();
                    main.remoteVideoForm.StartPosition = FormStartPosition.CenterParent;
                    main.remoteVideoForm.Text = ConfigHelper.GetString("RemoteVideoFrm");
                    main.remoteVideoForm.Show();
                }
            }
            
            main.WriteLog("Device back: OnPhoneAnswerExResult callID = {0}, info = {1}, flag = {2}, errorCode = {3}\r\n", callId, info, flag, errorCode);
        }

        /// <summary>
        /// 释放话机呼叫请求结果事件
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callSessionId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneReleaseResult(string callId, string callSessionId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPhoneReleaseResult callSessionId = {0}, flag = {1}, errorCode = {2}\r\n", callSessionId, flag, errorCode);

            if (errorCode == 0)
            {
                if (main.CallSessionIDOnAidDevice == callSessionId)
                {
                    main.IsTalkingOnAidDevice = false;
                    main.CallSessionIDOnAidDevice = string.Empty;
                }  

                main.callSessionID = null;
                if (!string.IsNullOrEmpty(main.holdedCallSessionID))
                {
                    if (callSessionId == main.holdedCallSessionID)
                    {
                        main.holdedCallSessionID = string.Empty;
                    }
                    main.callSessionID = main.holdedCallSessionID;
                    //main.holdedCallSessionID = string.Empty;
                }
                //main.WriteLog("callSessionID={0}, holdedCallSessionID={1}", main.callSessionID, main.holdedCallSessionID);
                main.demoRelease = false;
                main.otherCall = string.Empty;
               // main.m_ToBeSwitchedCallInfo.DeleteToBeSwitchedCallInfo();
            }
        }

        public override void OnPhoneReleaseEvent(string callSessionId, string caller, string callee, int reason)
        {
            main.WriteLog("Device back: OnPhoneReleaseEvent callSessionId = {0}, caller = {1}, callee = {2}, reason = {3}\r\n", callSessionId, caller, callee, reason);

            if(null != main.localVideoForm && null != main.remoteVideoForm)
            {
                main.localVideoForm.Hide();
                main.remoteVideoForm.Hide();
            }

            if (main.CallSessionIDOnAidDevice == callSessionId)
            {
                main.IsTalkingOnAidDevice = false;
                main.CallSessionIDOnAidDevice = string.Empty;
            }
            
            if (callSessionId == main.callSessionID && !main.demoRelease && (!string.IsNullOrEmpty(caller) || !string.IsNullOrEmpty(callee)))
            {
                main.callSessionID = null;
                if (!string.IsNullOrEmpty(main.holdedCallSessionID))
                {
                    if (callSessionId == main.holdedCallSessionID)
                    {
                        main.holdedCallSessionID = string.Empty;
                    }
                    main.callSessionID = main.holdedCallSessionID;
                    //main.holdedCallSessionID = string.Empty;
                    //main.WriteLog("callSessionID={0}, holdedCallSessionID={1}", main.callSessionID, main.holdedCallSessionID);
                }
            }

            if (callSessionId == main.otherCall)
            {
                main.otherCall = string.Empty;
            }
        }

        /// <summary>
        /// 指示联动话机静音或取消静音结果事件
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callSessionId"></param>
        /// <param name="isMute"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneMuteResult(string callId, string callSessionId, bool isMute, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPhoneMuteResult callSessionId = {0}, flag = {1}, errorCode = {2}, isMute = {3}\r\n", callSessionId, flag, errorCode, isMute);
        }

        /// <summary>
        /// 获取音频设备信息结果，不支持联动场景
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="isInput"></param>
        /// <param name="deviceNum"></param>
        /// <param name="deviceList"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneGetSoundDeviceResult(string callId, bool isInput, int deviceNum, List<SoundDeviceInfo> deviceList, bool flag, int errorCode)
        {
            string deviceListData = Serialize(deviceList);
            main.WriteLog("Device back: OnPhoneGetSoundDeviceResult flag = {0}, errorCode = {1}, isInput = {2}, deviceNum = {3}, deviceList = {4}\r\n", flag, errorCode, isInput, deviceNum, deviceListData);
            if (isInput)
            {
                main.SetInputDeviceInfo(deviceList);
            }
            else
            {
                main.SetOutputDeviceInfo(deviceList);
            }
        }

        /// <summary>
        /// 获取视频设备信息结果
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="deviceNum"></param>
        /// <param name="deviceList"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneGetVideoDeviceResult(string callId, int deviceNum, List<SoundDeviceInfo> deviceList, bool flag, int errorCode)
        {
            string deviceListData = Serialize(deviceList);
            main.WriteLog("Device back: OnPhoneGetVideoDeviceResult flag = {0}, errorCode = {1}, deviceNum = {2}, deviceList = {3}\r\n", flag, errorCode, deviceNum, deviceListData);
            main.SetVideoDeviceInfo(deviceList);
        }

        /// <summary>
        /// 设置话机音量大小结果事件
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="isInput"></param>
        /// <param name="volumeValue"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneSetVolumeResult(string callId, bool isInput, int volumeValue, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPhoneSetVolumeResult flag = {0}, errorCode = {1}, isInput = {2}, volumeValue = {3}\r\n", flag, errorCode, isInput, volumeValue);
        }

        /// <summary>
        /// 获取话机音量大小结果事件
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="isInput"></param>
        /// <param name="volumeValue"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneGetVolumeResult(string callId, bool isInput, int volumeValue, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPhoneGetVolumeResult flag = {0}, errorCode = {1}, isInput = {2}, volumeValue = {3}\r\n", flag, errorCode, isInput, volumeValue);
        }

        public override void OnPhoneGetDeviceVolumeResult(string callId, bool isInput, int volumeValue, AudioDeviceType deviceType, bool flag, int errorCode)
        {
            main.WriteLog("Device back:OnPhoneGetDeviceVolumeResult flag = {0}, errorCode = {1}, isInput = {2}, volumeValue = {3}, deviceType={4}\r\n", flag, errorCode, isInput, volumeValue, deviceType);
        }

        public override void OnPhoneSetDeviceVolumeResult(string callId, bool isInput, int volumeValue, AudioDeviceType deviceType, bool flag, int errorCode)
        {
            main.WriteLog("Device back:OnPhoneSetDeviceVolumeResult flag = {0}, errorCode = {1}, isInput = {2}, volumeValue = {3}, deviceType={4}\r\n", flag, errorCode, isInput, volumeValue, deviceType);
        }

        /// <summary>
        /// 设置音频设备信息结果，不支持联动场景
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="isInput"></param>
        /// <param name="deviceIndex"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneSetSoundDeviceResult(string callId, bool isInput, string deviceIndex, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPhoneSetSoundDeviceResult flag = {0}, errorCode= {1}, isInput = {2}, deviceIndex = {3}\r\n", flag, errorCode, isInput, deviceIndex);
        }

        /// <summary>
        /// 设置视频窗口
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="localHandle"></param>
        /// <param name="remoteHandle"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneSetVideoWindowResult(string callId, string windowInfo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPhoneSetVideoWindowResult flag = {0}, errorCode= {1}, windowInfo = {2}\r\n", flag, errorCode, windowInfo);
        }

        /// <summary>
        /// 话机去初始化事件
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneUnInitializeResult(string callId, bool flag, int errorCode)
        {
            if (flag)
            {
                main.IsTalkingOnAidDevice = false;
                main.CallSessionIDOnAidDevice = string.Empty;
            }

            main.WriteLog("Device back: OnPhoneUnInitializeResult flag = {0}, errorCode = {1}\r\n", flag, errorCode);
        }

        //新增接口
        /// <summary>
        /// 话机联动功能状态上报事件
        /// </summary>
        /// <param name="isEnabled"></param>
        public override void OnPhoneLinkageStatusNotify(bool isEnabled, int reason)
        {
            main.WriteLog("Device back: OnPhoneLinkageStatusNotify isEnabled = {0}, reason = {1}\r\n", isEnabled, reason);
        }


        //新增接口
        /// <summary>
        /// 话机状态上报事件，暂不支持IPCC线路状态上报
        /// </summary>
        /// <param name="callSessionId"></param>
        /// <param name="status"></param>
        /// <param name="number"></param>
        /// <param name="callType"></param>
        public override void OnPhoneStatusChangeEvent(string callSessionId, PhoneStatus status, string number, string callType)
        {
            main.WriteLog("Device back: OnPhoneStatusChangeEvent callSessionId = {0}, status = {1}, number = {2}, callType = {3}\r\n", callSessionId, status, number, callType);
            if (callSessionId != "0" && status != PhoneStatus.OnHook && status != PhoneStatus.OffHook)
            {
                main.callSessionID = callSessionId;
            }
            if (status == PhoneStatus.Hold && string.IsNullOrEmpty(main.holdedCallSessionID) && !main.demoHold)
            {
                //main.isInHold = true;
                main.holdedCallSessionID = callSessionId;
            }
            if (status == PhoneStatus.UnHold && callSessionId == main.holdedCallSessionID && !main.demoHold)
            {
                //main.isInHold = false;
                main.holdedCallSessionID = string.Empty;
            }
        }

        //新增接口
        /// <summary>
        /// 收到新的呼叫请求，且进行了自动应答处理
        /// </summary>
        /// <param name="callSessionId"></param>
        /// <param name="callerNumber"></param>
        /// <param name="calleeNumber"></param>
        /// <param name="isEmergencyCall"></param>
        /// <param name="callType"></param>
        public override void OnPhoneAutoAnswerEvent(string callSessionId, string callerNumber, string calleeNumber, bool isEmergencyCall, int callType)
        {
            main.callSessionID = callSessionId;
            main.WriteLog("Device back: OnPhoneAutoAnswerEvent callSessionId = {0}, callerNumber = {1}, calleeNumber = {2}, isEmergencyCall = {3}, callType = {4}\r\n", callSessionId, callerNumber, calleeNumber, isEmergencyCall, callType);
        }

        public override void OnPhoneAutoAnswerEventEx(PhoneCallInfo callinfo)
        {
            main.callSessionID = callinfo.callSessionId;

            //视频自动应答则显示视频窗口    
            //Mod for DTS2018021204992 视频坐席缺省单呼用户，未跳视频弹框 
            if (callinfo.mediaAbility == MediaAbility.Video || (callinfo.mediaAbility == MediaAbility.Default && main._agentInfo.AgentType == AgentType.Video) )
            {
                main.localVideoForm.StartPosition = FormStartPosition.CenterParent;
                main.localVideoForm.Text = ConfigHelper.GetString("LocalVideoFrm");
                main.localVideoForm.Show();
                main.remoteVideoForm.StartPosition = FormStartPosition.CenterParent;
                main.remoteVideoForm.Text = ConfigHelper.GetString("RemoteVideoFrm");
                main.remoteVideoForm.Show();
            }

            main.WriteLog("Device back: OnPhoneAutoAnswerEventEx callSessionId = {0}, callerNumber = {1}, calleeNumber = {2}, isEmergencyCall = {3}, callType= {4}, mediaAbility= {5}\r\n",
                callinfo.callSessionId, callinfo.callerNumber, callinfo.calleeNumber, callinfo.isEmergencyCall, callinfo.callType, callinfo.mediaAbility);
        }

        //新增接口
        /// <summary>
        /// 指定呼叫辅助音频设备与主设备切换结果事件
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callSessionId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneSwitchSoundDeviceResult(string callId, string callSessionId, bool isToAidDevice, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPhoneSwitchSoundDeviceResult callSessionId = {0}, flag = {1}, errorCode = {2}, isToAidDevice = {3}\r\n", callSessionId, flag, errorCode, isToAidDevice);
        }

        //新增接口
        /// <summary>
        /// 设置话机音量，不支持联动场景
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callSessionId"></param>
        /// <param name="isInput"></param>
        /// <param name="volumeValue"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneSetVolumeGainByCallResult(string callId, string callSessionId, bool isInput, int volumeValue, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPhoneSetVolumeGainByCallResult callSessionId = {0}, flag = {1}, errorCode = {2}, isInput = {3}, volumeValue = {4}\r\n", callSessionId, flag, errorCode, isInput, volumeValue);
        }

        //新增接口
        /// <summary>
        /// 获取话机音量大小结果事件
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callSessionId"></param>
        /// <param name="isInput"></param>
        /// <param name="volumeValue"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnPhoneGetVolumeGainByCallResult(string callId, string callSessionId, bool isInput, int volumeValue, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnPhoneGetVolumeGainByCallResult callSessionId = {0}, flag = {1}, errorCode = {2}, isInput = {3}, volumeValue = {4}\r\n", callSessionId, flag, errorCode, isInput, volumeValue);
        }

        //新增接口
        /// <summary>
        /// 咨询转结果事件
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnTransferConsultingResult(string callId, bool flag, int errorCode, string callIds)
        {
            main.WriteLog("Device back: OnTransferConsultingResult callId = {0}, flag = {1}, errorCode = {2}, callIds={3}\r\n", callId, flag, errorCode, callIds);
        }
        /// <summary>
        /// 初始化集群群组配置结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        public override void OnLoginToUPortalResult(string callId, bool flag, int errorCode)
        {
            if (flag)
            {
                main.HasSelectedGroupTalking = false;
                main.GoingToGroupTalkingSelectId = string.Empty;
            }

            main.WriteLog("Device back: OnLoginToUPortalResult callId = {0}, flag = {1}, errorCode = {2}\r\n", callId, flag, errorCode);
        }

        /// <summary>
        /// 去初始化集群调度功能结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        public override void OnLogoutFromUPortalResult(string callId, bool flag, int errorCode)
        {
            if (flag)
            {
                main.GoingToGroupTalkingSelectId = string.Empty;
                main.HasSelectedGroupTalking = false;
            }

            main.WriteLog("Device back: OnLogoutFromUPortalResult callId = {0}, flag = {1}, errorCode = {2}\r\n", callId, flag, errorCode);
        }

        /// <summary>
        /// 查询集群群组信息结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        /// <param name="queryType">查询类型</param>
        /// <param name="groupList">集群群组信息列表</param>
        /// <param name="pageInfo">分页信息</param>
        public override void OnTalkingGroupQueryResult(string callId, int queryType, List<TalkingGroup> groupList, PageInfo pageInfo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnTalkingGroupQueryResult flag = {0}, errorCode = {1}, queryType = {2}, groupList = {3}, pageInfo = {4},callId={5}\r\n"
                , flag, errorCode, queryType, Serialize(groupList), Serialize(pageInfo), callId);
        }

        /// <summary>
        /// 查询集群群组状态结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        /// <param name="groupState">集群群组状态信息</param>
        public override void OnTalkingGroupQueryStateResult(string callId, TalkingGroupState groupState, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnTalkingGroupQueryStateResult flag = {0}, errorCode = {1}, groupState = {2},callId={3}\r\n"
                , flag, errorCode, Serialize(groupState), callId);
        }

        /// <summary>
        /// 新增指定集群群组结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        public override void OnTalkingGroupAddResult(string callId, TalkingGroup groupInfo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnTalkingGroupAddResult flag = {0}, errorCode = {1}, groupInfo = {2},callId={3}\r\n"
                , flag, errorCode, Serialize(groupInfo), callId);
        }

        /// <summary>
        /// 修改指定集群群组结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        public override void OnTalkingGroupModifyResult(string callId, TalkingGroup groupInfo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnTalkingGroupModifyResult flag = {0}, errorCode = {1}, groupInfo = {2},callId={3}\r\n"
                , flag, errorCode, Serialize(groupInfo), callId);
        }

        /// <summary>
        /// 删除指定集群群组结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        public override void OnTalkingGroupDeleteResult(string callId, string groupNum, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnTalkingGroupDeleteResult flag = {0}, errorCode = {1}, groupNum = {2},callId={3}\r\n"
                , flag, errorCode, groupNum, callId);
        }

        /// <summary>
        /// 订阅集群群组结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        /// <param name="expire">订阅时间</param>
        /// <param name="groupNum">集群群组号码</param>
        public override void OnTalkingGroupSubscribeResult(string callId, int expire, string groupNum, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnTalkingGroupSubscribeResult flag = {0}, errorCode = {1}, expire = {2}, groupNum = {3},callId={4}\r\n"
                , flag, errorCode, expire, groupNum, callId);
        }

        /// <summary>
        /// 查询无线集群群组结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        /// <param name="queryType">查询类型</param>
        /// <param name="groupList">集群群组信息列表</param>
        /// <param name="pageInfo">分页信息</param>
        public override void OnRadioGroupQueryResult(string callId, int queryType, List<RadioGroup> groupList, PageInfo pageInfo, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnRadioGroupQueryResult flag = {0}, errorCode = {1}, queryType = {2}, groupList = {3}, pageInfo = {4},callId={5}\r\n"
                , flag, errorCode, queryType, Serialize(groupList), Serialize(pageInfo), callId);
        }

        /// <summary>
        /// 集群群组用户状态变更通知事件
        /// </summary>
        /// <param name="groupUserState">集群群组用户状态信息</param>
        public override void OnTalkingGroupUserStateChange(GroupUserState groupUserState)
        {
            main.WriteLog("Device back: OnTalkingGroupUserStateChange groupUserState = {0}\r\n", Serialize(groupUserState));
        }

        /// <summary>
        /// 监听集群群组结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        /// <param name="groupNum">集群群组号码</param>
        /// <param name="isMonitor">开始/停止监听</param>
        public override void OnTalkingGroupMonitorResult(string callId, string groupNum, bool isMonitor, bool isRecvOnly, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnTalkingGroupMonitorResult flag = {0}, errorCode = {1}, groupNum = {2}, isMonitor = {3}, isRecvOnly = {4},callId={5}\r\n"
                , flag, errorCode, groupNum, isMonitor, isRecvOnly, callId);
            if (!flag)
            {
                main.callSessionID = main.otherCall;
                main.otherCall = string.Empty;
            }

            if (flag)
            {
                if (!isMonitor)
                {
                    main.MonitorTalkingGroupId = string.Empty;
                }
            }
        }

        /// <summary>
        /// Monitor/Select切换结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        /// <param name="groupNum">集群群组号码</param>
        /// <param name="isSelect">开始/停止Select</param>
        public override void OnTalkingGroupSelectResult(string callId, string groupNum, bool isSelect, bool flag, int errorCode)
        {
            if (flag && isSelect)
            {
                main.HasSelectedGroupTalking = true;
            }
            else if (flag && (!isSelect))
            {
                main.HasSelectedGroupTalking = false;   
            }

            main.WriteLog("Device back: OnTalkingGroupSelectResult, flag = {0}, errorCode = {1}, groupNum = {2}, isSelect = {3},callId = {4}\r\n"
                , flag, errorCode, groupNum, isSelect, callId);
        }

        /// <summary>
        /// 抢权或放权结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        /// <param name="groupNum">集群群组号码</param>
        /// <param name="isPTT">开始/停止PTT</param>
        public override void OnTalkingGroupPTTResult(string callId, string groupNum, bool isPTT, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnTalkingGroupPTTResult flag = {0}, errorCode = {1}, groupNum = {2}, isPTT = {3},callId={4}\r\n"
                , flag, errorCode, groupNum, isPTT, callId);
        }

        /// <summary>
        /// 查询集群群组呼叫信息结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        /// <param name="groupNum">集群群组号码</param>
        /// <param name="callSessionId">集群群组呼叫的会话唯一标识</param>
        public override void OnTalkingGroupGetCallInfoResult(string callId, string groupNum, string callSessionId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnTalkingGroupGetCallInfoResult flag = {0}, errorCode = {1}, groupNum = {2}, callSessionId = {3},callId={4}\r\n"
                , flag, errorCode, groupNum, callSessionId, callId);
        }


        /// <summary>
        /// 发起混编集群群组呼叫结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        /// <param name="groupNum">集群群组号码</param>
        public override void OnMixedGroupCallStartResult(string callId, string groupNum, bool flag, int errorCode)
        {
            main.WriteLog("Device back:OnMixedGroupCallStartResult flag = {0}, errorCode = {1}, groupNum = {2},callId={3}\r\n"
                , flag, errorCode, groupNum, callId);
            if (!flag)
            {
                main.callSessionID = main.otherCall;
                main.otherCall = string.Empty;
            }
        }

        /// <summary>
        /// 发起混编集群群组呼叫结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        /// <param name="groupNum">集群群组号码</param>
        public override void OnMixedAndTempGroupCallStartResult(string callId, string groupNum, bool flag, int errorCode)
        {
            main.WriteLog("Device back:OnMixedAndTempGroupCallStartResult flag = {0}, errorCode = {1}, groupNum = {2},callId={3}\r\n"
                , flag, errorCode, groupNum, callId);
            if (!flag)
            {
                main.callSessionID = main.otherCall;
                main.otherCall = string.Empty;
            }
        }

        /// <summary>
        /// 结束混编集群群组呼叫结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        /// <param name="groupNum">集群群组号码</param>
        public override void OnMixedGroupCallEndResult(string callId, string groupNum, bool flag, int errorCode)
        {
            main.WriteLog("Device back:OnMixedGroupCallEndResult flag = {0}, errorCode = {1}, groupNum = {2},callId={3}\r\n"
                , flag, errorCode, groupNum, callId);
        }

        /// <summary>
        /// 修改混编集群群组用户状态结果事件
        /// </summary>
        /// <param name="callId">请求唯一标识</param>
        /// <param name="flag">请求结果</param>
        /// <param name="errorCode">错误码</param>
        /// <param name="userStateList">集群群组用户状态列表</param>
        public override void OnMixedGroupChangeUserStateResult(string callId, string groupNum, List<MixedGroupUserState> userStateList, bool flag, int errorCode)
        {
            main.WriteLog("Device back:OnMixedGroupChangeUserStateResult flag = {0}, errorCode = {1}, groupNum = {2}, userStateList = {3},callId={4}\r\n"
                , flag, errorCode, groupNum, Serialize(userStateList), callId);
        }

        //设置配置项结果事件
        public override void OnSetConfigResult(string callId, string cfgKey, string cfgValue, bool flag, int errorCode)
        {
            main.WriteLog("Device back:OnSetConfigResult callId = {0}, flag = {1}, errorCode = {2}, cfgKey = {3}, cfgValue = {4}\r\n", callId, flag, errorCode, cfgKey, cfgValue);
        }

        //获取配置项结果事件
        public override void OnGetConfigResult(string callId, string cfgKey, string cfgValue, bool flag, int errorCode)
        {
            main.WriteLog("Device back:OnGetConfigResult callId = {0}, flag = {1}, errorCode = {2}, cfgKey = {3}, cfgValue = {4}\r\n", callId, flag, errorCode, cfgKey, cfgValue);
        }


        /// <summary>
        /// 混编集群群组呼叫状态变更事件
        /// </summary>
        /// <param name="groupNum">集群群组唯一标识</param>
        /// <param name="userNum">发起该变更操作的用户标识</param>
        /// <param name="callState">呼叫状态信息</param>
        /// <param name="reason">状态变更原因</param>
        public override void OnMixedGroupCallStateChange(string groupNum, string userNum, int callState, int reason)
        {
            
        }

        /// <summary>
        /// 混编集群群组用户状态变更事件
        /// </summary>
        /// <param name="groupNum">集群群组唯一标识</param>
        /// <param name="userNum">发起该变更操作的用户标识</param>
        /// <param name="userState">用户状态信息</param>
        /// <param name="reason">状态变更原因</param>
        public override void OnMixedGroupUserStateChange(string groupNum, string userNum, MixedGroupUserState userState, int reason)
        {
            
        }

        /// <summary>
        /// 根据callId判断当前坐席是否有释放该呼叫的权限
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callSessionId"></param>
        /// <param name="isAgentReleaseAllowed"></param>
        /// <param name="flag"></param>
        /// <param name="errorCode"></param>
        public override void OnQueryReleaseAuthorityByCallIdResult(string callId, string callSessionId, bool isAgentReleaseAllowed, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryReleaseAuthorityByCallIdResult callId = {0}, callSessionId = {1}, isAgentReleaseAllowed = {2}, flag = {3}, errorCode = {4}",
                         callId, callSessionId, isAgentReleaseAllowed, flag, errorCode);
        }

        /// <summary>
        /// 座席来电呼叫信息通知事件
        /// </summary>
        /// <param name="incomingCallInfoTmp">呼叫通知信息</param>
        public override void OnIncomingCallInfoNotify(IncomingCallInfo incomingCallInfoTmp)
        {
            main.WriteLog("Device back: OnIncomingCallInfoNotify, callSessionId={0}, callerNumber={1}, CalleeNumber={2}, GroupId={3}, GroupName={4}, IsReleaseAndReQueueCall={5}, ReleaseAndReQueueCount={6}, LastReleaseAgentId={7}",
                                incomingCallInfoTmp.CallSessionId,
                                incomingCallInfoTmp.CallerNumber,
                                incomingCallInfoTmp.CalleeNumber,
                                incomingCallInfoTmp.GroupId,
                                incomingCallInfoTmp.GroupName,
                                incomingCallInfoTmp.IsReleaseAndReQueueCall,
                                incomingCallInfoTmp.ReleaseAndReQueueCount,
                                incomingCallInfoTmp.LastReleaseAgentId);
        }
        
        public override void OnGetRecordListResult(string callId, QueryRecordData data, TalkingGroupQueryRecordResult result, bool flag, int errorCode) {
            main.WriteLog("Device back:OnGetRecordListResult callId = {0}, flag = {1}, errorCode = {2}, RecordList = {3}\r\n", callId, flag, errorCode, Serialize(result));
        }

        public override void OnGetNonceResult(string callId, string nonce, bool flag, int errorCode)
        {
            main.WriteLog("Device back:OnGetNonceResult callId = {0}, flag = {1}, errorCode = {2}, Nonce = {3}\r\n", callId, flag, errorCode, nonce);
        }

        public override void OnStopPlayEmergencyNoteResult(string callId, string fileInfo, bool flag, int errorCode, short stopEmergencyNoteResult)
        {
            main.WriteLog("Device back:OnStopPlayEmergencyNoteResult callId = {0}, flag = {1}, errorCode = {2}, fileInfo = {3}, stopEmergencyNoteResult={4}\r\n",
                callId, flag, errorCode, fileInfo, stopEmergencyNoteResult);
        }

        public override void OnQueryServiceParametersResult(string callId, ServiceParameters data, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnQueryServiceParametersResult callId = {0}, flag = {1}, errorCode = {2}, data = {3}\r\n", callId, flag, errorCode, Serialize(data));
        }

        public override void OnAnswerEmergencyCallResult(string callId, string groupNum, bool isRecvOnly, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnAnswerEmergencyCallResult callId = {0}, groupNum = {1}, isRecvOnly = {2}, flag = {3}, errorCode = {4}\r\n", callId, groupNum, isRecvOnly, flag, errorCode);
        }

        public override void OnEmergencyExitResult(string callId, string groupNum, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnEmergencyExitResult callId = {0}, groupNum = {1}, flag = {2}, errorCode = {3}\r\n", callId, groupNum, flag, errorCode);
        }

        public override void OnTalkingGroupReleaseAllResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back:OnTalkingGroupReleaseAllResult callId = {0}, flag = {1}, errorCode = {2} \r\n", callId, flag, errorCode);
        }

        public override void OnUnifiedLoginResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnUnifiedLoginResult callId = {0}, flag = {1}, errorCode = {2}\r\n", callId, flag, errorCode);
        }

        public override void OnUnifiedLogoutResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnUnifiedLogoutResult callId = {0}, flag = {1}, errorCode = {2}\r\n", callId, flag, errorCode);
        }

        public override void OnStartRecordScreenResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnStartRecordScreenResult callId = {0}, flag = {1}, errorCode = {2}\r\n", callId, flag, errorCode);
        }

        public override void OnStopRecordScreenResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnStopRecordScreenResult callId = {0}, flag = {1}, errorCode = {2}\r\n", callId, flag, errorCode);
        }

        public override void OnRecordScreenSuccess(string serialNum, string recordId, string errorCode)
        {
            main.WriteLog("Device back: OnRecordScreenSuccess callId = {0}, recordId = {1}, errorCode = {2} \r\n", serialNum, recordId, errorCode);
        }

        public override void OnRecordScreenFailure(string serialNum, string recordId)
        {
            main.WriteLog("Device back: OnRecordScreenFailure callId = {0}, recordId = {1} \r\n", serialNum, recordId);
        }

        public override void OnStopRecordScreenSuccess(string serialNum, string recordId)
        {
            main.WriteLog("Device back: OnStopRecordScreenSuccess callId = {0}, recordId = {1} \r\n", serialNum, recordId);
        }

        public override void OnStopRecordScreenFailure(string serialNum, string recordId)
        {
            main.WriteLog("Device back: OnStopRecordScreenFailure callId = {0}, recordId = {1} \r\n", serialNum, recordId);
        }
		
        // begin: add by lujiale 00284681, for AR.WeChat.004.002, 2017-12-26
        /// <summary>
        /// 多媒体呼叫到达事件
        /// </summary>
        public override void OnReceiveMediaCallConnectEvent(int subMediaType, int uvid, bool isInnerCall, string callId, string caller,
                                                            string called, string realCaller, string displayName, string userInfo, string attachData)
        {
            main.WriteLog("Device back: OnReceiveMediaCallConnectEvent, subMediaType = {0}, uvid = {1}, "
                                                                        + "isInnerCall = {2}, callId = {3}, "
                                                                        + "caller = {4}, called = {5}, "
                                                                        + "realCaller = {6}, displayName = {7}, "
                                                                        + "userInfo = {8}, attachData = {9}",
                                                                           subMediaType, uvid,
                                                                           isInnerCall, callId,
                                                                           caller, called,
                                                                           realCaller, displayName,
                                                                           userInfo, attachData);

            main.OnReceiveMediaCallConnectEvent(subMediaType, uvid, isInnerCall, callId, caller, called, realCaller, displayName, userInfo, attachData);
        }

        /// <summary>
        /// 接收到多媒体呼叫内容事件
        /// </summary>
        public override void OnReceiveMediaCallContent(int subMediaType, string callId, int chatId, int chatContentType, string content)
        {
            main.WriteLog("Device back: OnReceiveMediaCallContent, subMediaType = {0}, callId = {1}, chatId = {2}, chatContentType = {3}",
                                                                        subMediaType, callId, chatId, chatContentType);
            main.OnReceiveMediaCallContent(subMediaType, callId, chatId, chatContentType, content);
        }

        /// <summary>
        /// 多媒体呼叫释放通知
        /// </summary>
        public override void OnReceiveMediaCallReleaseEvent(string callId)
        {
            main.WriteLog("Device back: OnReceiveMediaCallReleaseEvent, callId = {0}", callId);
            main.OnReceiveMediaCallReleaseEvent(callId);
        }

        /// <summary>
        /// 多媒体文本内容发送结果
        /// </summary>
        public override void OnSendMediaContentResult(string callId, int chatId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSendMediaContentResult, callId = {0}, chatId = {1}, flag = {2}, errorCode = {3}", callId, chatId, flag, errorCode);
            main.OnSendMediaContentResult(callId, chatId, flag, errorCode);
        }

        /// <summary>
        /// 多媒体文件内容发送结果
        /// </summary>
        public override void OnSendMediaFileResult(string callId, int chatId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnSendMediaFileResult, callId = {0}, chatId = {1}, flag = {2}, errorCode = {3}", callId, chatId, flag, errorCode);
            main.OnSendMediaFileResult(callId, chatId, flag, errorCode);
        }

        /// <summary>
        /// 多媒体文件接收结果
        /// </summary>
        public override void OnReceiveMediaFileResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnReceiveMediaFileResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
            main.OnReceiveMediaFileResult(callId, flag, errorCode);
        }

        /// <summary>
        /// 多媒体呼叫转移结果事件
        /// </summary>
        public override void OnTransferMediaCallToAgentResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnTransferMediaCallToAgentResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
            main.OnTransferMediaCallToAgentResult(callId, flag, errorCode);
        }

        /// <summary>
        /// 多媒体释放接口调用结果事件
        /// </summary>
        public override void OnReleaseMediaCallResult(string callId, bool flag, int errorCode)
        {
            main.WriteLog("Device back: OnReleaseMediaCallResult, callId = {0}, flag = {1}, errorCode = {2}", callId, flag, errorCode);
        }
        // end: add by lujiale 00284681, for AR.WeChat.004.002, 2017-12-26

        /// <summary>
        /// 实时语音转文字通知
        /// </summary>
        public override void OnASRNotify(string callId, string initialAgentId, string ccId, string vdnId, string curUserDn, 
                                        string talkerType, string talkerAgentId, string talkerPhoneDn, string asrUserCase, List<AgentAsrResult> lstAgentAsrResult)
        {
            main.WriteLog("Device back: OnASRNotify, callId = {0}, initialAgentId = {1}, "
                                                        + "ccId = {2}, vdnId = {3}, "
                                                        + "curUserDn = {4}, talkerType = {5}, "
                                                        + "talkerAgentId = {6}, talkerPhoneDn = {7}, "
                                                        + "asrUserCase = {8}, ", 
                                                        callId, initialAgentId,
                                                        ccId, vdnId,
                                                        curUserDn, talkerType,
                                                        talkerAgentId, talkerPhoneDn,
                                                        asrUserCase);
            for (int i = 0; i < lstAgentAsrResult.Count; i++ )
            {
                main.WriteLog("Device back: OnASRNotify, agentAsrResult[{0}], confidence = {1}, encUserData = {2}, asrEncodeType = {3}, asrContent = {4}", 
                    i, lstAgentAsrResult[i].confidence , lstAgentAsrResult[i].encUserData, lstAgentAsrResult[i].asrEncodeType, lstAgentAsrResult[i].asrContent);
            }
        }
    }
}