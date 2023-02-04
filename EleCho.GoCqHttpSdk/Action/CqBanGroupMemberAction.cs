﻿using EleCho.GoCqHttpSdk.Action.Model.Params;

using System;

namespace EleCho.GoCqHttpSdk.Action
{
    /// <summary>
    /// 禁言群成员
    /// </summary>
    public class CqBanGroupMemberAction : CqAction
    {
        public override CqActionType ActionType => CqActionType.BanGroupMember;

        public CqBanGroupMemberAction(long groupId, long userId, TimeSpan duration)
        {
            GroupId = groupId;
            UserId = userId;
            Duration = duration;
        }

        /// <summary>
        /// 群 ID
        /// </summary>
        public long GroupId { get; set; }
        /// <summary>
        /// 用户 ID
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// 时长
        /// </summary>
        public TimeSpan Duration { get; set; }

        internal override CqActionParamsModel GetParamsModel()
        {
            return new CqBanGroupMemberActionParamsModel(GroupId, UserId, Duration.Ticks / TimeSpan.TicksPerSecond);
        }
    }
}