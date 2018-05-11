using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.top.ipout.get
    /// </summary>
    public class TopIpoutGetRequest : BaseTopRequest<Top.Api.Response.TopIpoutGetResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.top.ipout.get";
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
