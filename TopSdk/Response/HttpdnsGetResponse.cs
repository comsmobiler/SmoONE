using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// HttpdnsGetResponse.
    /// </summary>
    public class HttpdnsGetResponse : TopResponse
    {
        /// <summary>
        /// HTTP DNS配置信息
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
