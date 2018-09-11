using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalman.Studio
{
    /// <summary>
    /// 基础实体
    /// </summary>
    [Serializable]
    public class BaseEntity
    {
        /// <summary>
        /// 创建人
        /// </summary>
        [DisplayName("创建人")]
        public string CreateUser { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime AddedDate { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        [DisplayName("修改人")]
        public string ModifiedUser { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        [DisplayName("修改时间")]
        public DateTime ModifiedDate { get; set; }
    }
}
