using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.aliqin.fc.flow.grade
    /// </summary>
    public class AlibabaAliqinFcFlowGradeRequest : BaseTopRequest<Top.Api.Response.AlibabaAliqinFcFlowGradeResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "alibaba.aliqin.fc.flow.grade";
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
