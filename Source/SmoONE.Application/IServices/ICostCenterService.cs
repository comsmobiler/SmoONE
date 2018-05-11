using SmoONE.CommLib;
using SmoONE.Domain;
using SmoONE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.Application
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  成本中心的服务接口
    // ******************************************************************
    /// <summary>
    /// 成本中心的服务接口
    /// </summary>
    public interface ICostCenterService
    {
        #region 查询
        /// <summary>
        /// 根据成本中心ID返回成本中心对象
        /// </summary>
        /// <param name="ID">成本中心ID</param>
        CCDetailDto GetCCByID(string ID);

        /// <summary>
        /// 根据成本中心类型模板ID返回成本中心类型模板对象
        /// </summary>
        /// <param name="ID">成本中心类型模板ID</param>
        CC_Type_TemplateDto GetTemplateByID(string ID);

        /// <summary>
        /// 根据成本中心类型ID返回成本中心类型模板对象
        /// </summary>
        /// <param name="TypeID">成本中心类型ID</param>
        List<CC_Type_TemplateDto> GetTemplateByTypeID(string TypeID);

        /// <summary>
        /// 根据成本中心类型ID返回成本中心类型对象
        /// </summary>
        /// <param name="ID">成本中心类型ID</param>
        CostCenter_Type GetTypeByID(string ID);

        /// <summary>
        /// 得到所有成本中心类型对象
        /// </summary>
        List<CostCenter_Type> GetAllCCType();

        /// <summary>
        /// 得到所有的成本中心
        /// </summary>
        List<CCDto> GetAllCC();

        /// <summary>
        /// 得到所有的成本中心类型模板
        /// </summary>
        List<CC_Type_TemplateDto> GetAllCCTTemplate();

        /// <summary>
        /// 根据成本中心名称和负责人来查询成本中心
        /// </summary>
        /// <param name="Name">成本中心名称</param>
        /// <param name="LiableMan">负责人</param>
        List<CCDto> QueryCC(string Name, string LiableMan);
        #endregion

        #region 操作
        /// <summary>
        /// 添加成本中心
        /// </summary>
        /// <param name="entity">成本中心对象</param>
        ReturnInfo AddCostCenter(CCInputDto entity);
        

        /// <summary>
        /// 添加成本中心类型的模板
        /// </summary>
        /// <param name="entity">成本中心类型的模板对象</param>
        ReturnInfo AddCC_Type_Template(CCTTInputDto entity);

        /// <summary>
        /// 更新成本中心
        /// </summary>
        /// <param name="entity">成本中心对象</param>
        ReturnInfo UpdateCostCenter(CCInputDto entity);

        /// <summary>
        /// 更新成本中心类型的模板
        /// </summary>
        /// <param name="entity">成本中心类型的模板对象</param>
        ReturnInfo UpdateCC_Type_Template(CCTTInputDto entity);

        /// <summary>
        /// 更新成本中心状态
        /// </summary>
        /// <param name="CC_ID">成本中心ID</param>
        /// <param name="IsActive">是否激活</param>
        ReturnInfo UpdateCostCenterStatus(string CC_ID,IsActive IsActive,string UserID);

        /// <summary>
        /// 更新成本中心类型的状态
        /// </summary>
        /// <param name="TypeID">成本中心类型的ID</param>
        /// <param name="IsActive">是否激活</param>
        ReturnInfo UpdateCC_TypeStatus(string TypeID, IsActive IsActive);
        #endregion
    }
}
