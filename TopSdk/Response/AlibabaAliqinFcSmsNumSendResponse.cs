using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaAliqinFcSmsNumSendResponse.
    /// </summary>
    public class AlibabaAliqinFcSmsNumSendResponse : TopResponse
    {
        /// <summary>
        /// 返回值
        /// </summary>
        [XmlElement("result")]
        public Top.Api.Domain.BizResult Result { get; set; }

    }
}
