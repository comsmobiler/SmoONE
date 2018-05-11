using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.time.get
    /// </summary>
    public class TimeGetRequest : BaseTopRequest<Top.Api.Response.TimeGetResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.time.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
