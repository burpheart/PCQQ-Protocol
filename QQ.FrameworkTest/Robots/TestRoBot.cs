﻿using System;
using QQ.Framework;
using QQ.Framework.Domains;

namespace QQ.FrameworkTest.Robots
{
    public class TestRoBot : CustomRoBot
    {
        public TestRoBot(SendMessageService service, ServerMessageSubject transponder, QQUser user) : base(service, transponder, user)
        {
        }

        public override void ReceiveFriendMessage(long friendNumber, string content)
        {
            Console.WriteLine($"机器人收到来自{friendNumber}的消息{content}");
        }

        public override void ReceiveGroupMessage(long groupNumber, long fromNumber, string content)
        {
        }
    }
}