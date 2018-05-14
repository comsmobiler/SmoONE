using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.Domain.IRepository
{
     public interface IContactRepository :IRepository<Contact>
    {

        /// <summary>
        /// 根据成本中心ID返回成本中心对象
        /// </summary>
        /// <param name="ID">成本中心ID</param>
        IQueryable<Contact> GetByID(int ID);

        /// <summary>
        /// 根据成本中心名称和负责人来查询成本中心
        /// </summary>
        /// <param name="UserID">成本中心名称</param>
        IQueryable<Contact> GetByCreateUsers(string UserID);
    }
}
