﻿using LC.Date.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC.Data.HR.Entities
{
    /// <summary>
    /// 员工信息
    /// </summary>
    /// <remarks>
    /// 员工用户信息
    /// </remarks>
    public partial class EmployeeInfo : EntityBase<Guid>
    {

        #region Properties

        /// <summary>
        /// 个人信息
        /// </summary>
        /// <remarks>
        /// 职员可能存在的个人信息Id
        /// </remarks>
        public virtual Guid? PersonalId
        {
            get;
            set;
        }

        /// <summary>
        /// 创建者Id
        /// </summary>
        /// <remarks>
        /// 数据创建者Id。
        /// </remarks>
        public virtual Guid? CreatedById
        {
            get;
            set;
        }


        /// <summary>
        /// 入职日期
        /// </summary>
        /// <remarks>
        /// 员工首次入职日期
        /// </remarks>
        public virtual DateTime JoinDate
        {
            get;
            set;
        }

        /// <summary>
        /// 离职日期
        /// </summary>
        /// <remarks>
        /// 记录最后离职日期，员工再入职后，该字段清空
        /// </remarks>
        public virtual DateTime? AwayDate
        {
            get;
            set;
        }

        /// <summary>
        /// 最近入职日期
        /// </summary>
        /// <remarks>
        /// 对再入职员工有效，其它员工默认置值新入职日期
        /// </remarks>
        public virtual DateTime LatestJoinDate
        {
            get;
            set;
        }

        /// <summary>
        /// 生日
        /// </summary>
        /// <remarks>
        /// 员工出生日期
        /// </remarks>
        public virtual DateTime Birthday
        {
            get;
            set;
        }

        /// <summary>
        /// 员工编号
        /// </summary>
        /// <remarks>
        /// 唯一全局编号
        /// </remarks>
        //bak[MaxLength(20)]
        public virtual string EmployeeNo
        {
            get;
            set;
        }

        /// <summary>
        /// 试用结束日期
        /// </summary>
        /// <remarks>
        /// 员工试用结束日期
        /// </remarks>
        public virtual DateTime ProbationEndDate
        {
            get;
            set;
        }

        /// <summary>
        /// 最近薪资
        /// </summary>
        /// <remarks>
        /// 记录员工的最后薪资
        /// </remarks>
        public virtual int? Salary
        {
            get;
            set;
        }

        #endregion


    }
}
