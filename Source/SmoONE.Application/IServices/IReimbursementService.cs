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
    // 主要内容：  报销单的服务接口
    // ******************************************************************
    /// <summary>
    /// 报销单的服务接口
    /// </summary>
    public interface IReimbursementService
    {
        #region 查询
        /// <summary>
        /// 根据报销单ID返回报销单对象
        /// </summary>
        /// <param name="ID">报销单ID</param>
        RBDetailDto GetByID(string ID);

        /// <summary>
        /// 根据审批用户ID返回待审批报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        List<ReimbursementDto> GetNewByCheckUsers(string UserID);

        /// <summary>
        /// 根据审批用户ID和状态返回待审批报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Status">状态</param>
        List<ReimbursementDto> QueryNewByCheckUsers(string UserID, int Status);

        /// <summary>
        /// 根据审批用户ID返回已审批报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        List<ReimbursementDto> GetCheckedByCheckUsers(string UserID);

        /// <summary>
        /// 根据审批用户ID和状态返回已审批报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Status">状态</param>
        List<ReimbursementDto> QueryCheckedByCheckUsers(string UserID, int Status);

        /// <summary>
        /// 根据创建用户ID返回报销单传输对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        List<ReimbursementDto> GetByCreateUsers(string UserID);

        /// <summary>
        /// 根据明细金额计算总金额
        /// </summary>
        /// <param name="UserID">用户ID</param>
        decimal GetTotalAmount(List<decimal> amounts);

        /// <summary>
        /// 根据报销类型ID返回报销类型名称
        /// </summary>
        /// <param name="TypeID">报销类型ID</param>
        string GetTypeNameByID(string TypeID);

        /// <summary>
        /// 得到所有的报销类型
        /// </summary>
        List<RB_RType> GetAllType();

        /// <summary>
        /// 根据消费类型模板ID返回消费类型模板对象
        /// </summary>
        /// <param name="ID">消费类型模板ID</param>
        RB_RType_TemplateDto GetTemplateByTemplateID(string ID);

        /// <summary>
        /// 根据消费类型ID返回消费类型模板对象
        /// </summary>
        /// <param name="TypeID">消费类型ID</param>
        List<RB_RType_TemplateDto> GetByTypeID(string TypeID);

        /// <summary>
        /// 根据报销明细ID返回报销明细对象
        /// </summary>
        /// <param name="ID">报销明细ID</param>
        RB_RowsDto GetRowByRowID(int ID);

        /// <summary>
        /// 根据报销单ID返回报销明细对象
        /// </summary>
        /// <param name="ID">报销单ID</param>
        List<RB_RowsDto> GetRowByRBID(string RBID);

        /// <summary>
        /// 根据用户ID返回未报销的消费明细对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        List<RB_RowsDto> GetRowsByCreateUser(string UserID);

        /// <summary>
        /// 根据用户ID返回消费类型模板对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        List<RB_RType_TemplateDto> GetTemplateByCreateUser(string UserID);

        /// <summary>
        /// 根据成本中心返回报销单传输对象
        /// </summary>
        /// <param name="CCID">成本中心ID</param>
        List <ReimbursementDto> GetByCCID(string CCID);
        #endregion

        #region 操作
        /// <summary>
        /// 添加报销单
        /// </summary>
        /// <param name="entity">报销单对象</param>
        ReturnInfo CreateRB(RBInputDto entity);

        /// <summary>
        /// 更新报销单
        /// </summary>
        /// <param name="entity">报销单对象</param>
        ReturnInfo UpdateRB(RBInputDto entity);

        /// <summary>
        /// 更新报销单状态
        /// </summary>
        /// <param name="ID">报销单ID</param>
        /// <param name="Status">报销单状态</param>
        /// <param name="UserID">当前审批者的ID</param>
        ReturnInfo UpdateRBStatus(string ID, RB_Status Status, string UserID, string RejectionReason);

        /// <summary>
        /// 添加消费明细
        /// </summary>
        /// <param name="entity">消费明细对象</param>
        ReturnInfo CreateRB_Rows(RB_RowsInputDto entity);

        /// <summary>
        /// 更新消费明细
        /// </summary>
        /// <param name="entity">消费明细对象</param>
        ReturnInfo UpdateRB_Rows(RB_RowsInputDto entity);

        /// <summary>
        /// 删除消费明细
        /// </summary>
        /// <param name="RB_RID">消费明细对象ID</param>
        ReturnInfo DeleteRB_Rows(int RB_RID);

        /// <summary>
        /// 添加消费类型的模板
        /// </summary>
        /// <param name="entity">消费类型的模板对象</param>
        ReturnInfo CreateRB_Type_Template(RBRTTInputDto entity);

        /// <summary>
        /// 更新消费类型的模板
        /// </summary>
        /// <param name="entity">消费类型的模板对象</param>
        ReturnInfo UpdateRB_Type_Template(RBRTTInputDto entity);

        /// <summary>
        /// 删除消费明细类型的模板
        /// </summary>
        /// <param name="RB_RTT_TemplateID">消费明细类型的模板ID</param>
        ReturnInfo DeleteRB_Type_Template(string RB_RTT_TemplateID);


       


        #endregion

    }
}
