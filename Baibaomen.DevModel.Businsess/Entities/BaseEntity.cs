using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baibaomen.DevModel.Businsess
{
    /// <summary>
    /// Provide base class for database entities.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// 对象Id必须为不可遍历的随机串，例如Guid。因为大量业务代码会直接暴露实体的Id，采用int等自增型数据，没做很好的授权控制的话，容易被遍历获取。
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The time the record created. Should be maintained by related services.
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// The time the record updated. Should be maintained by related services.
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// The user id of entity creator.
        /// </summary>
        public string CreatorId { get; set; }

        /// <summary>
        /// The user id of last updator.
        /// </summary>
        public string UpdatorId { get; set; }

        /// <summary>
        /// Record version to do concurrency check.
        /// </summary>
        [Timestamp]
        public byte[] RecordVersion { get; set; }
    }
}
