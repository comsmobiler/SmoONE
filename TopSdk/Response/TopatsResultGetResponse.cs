using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TopatsResultGetResponse.
    /// </summary>
    public class TopatsResultGetResponse : TopResponse
    {
        /// <summary>
        /// 任务结果信息
        /// </summary>
        [XmlElement("task")]
        public Top.Api.Domain.Task Task { get; set; }

    }
}
