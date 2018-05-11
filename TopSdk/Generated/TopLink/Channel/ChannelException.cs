using System;
using System.Collections.Generic;
using System.Text;

namespace Taobao.Top.Link.Channel
{
    public class ChannelException : LinkException
    {
        public ChannelException(string message) : base(message) { }
        public ChannelException(string message, Exception innerException) : base(message, innerException) { }
    }
}
