using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity
{
    /// <summary>
    /// 领域类型中的数据库实体基类
    /// </summary>
    public abstract class Entity
    {
        private int? _requestedHashCode;
        public virtual Guid Id { set; get; }

        /// <summary>
        /// Check if this entity is transient, ie, without identity at this moment
        /// 检查entity对象是不是临时的，临时的对象，id是一个空guid。
        /// </summary>
        /// <returns>True if entity is transient, else false</returns>
        public bool IsTransient()
        {
            return this.Id == Guid.Empty;
        }

        /// <summary>
        /// Generate identity for this entity
        /// 生成一个新的id到entity
        /// </summary>
        public void GenerateNewIdentity()
        {
            if (IsTransient())
                this.Id = NewId.NewSecuentialGuid();
        }

        /// <summary>
        /// Change current identity for a new non transient identity
        /// 改变当前entity id的值
        /// </summary>
        /// <param name="identity">the new identity</param>
        public void ChangeCurrentIdentity(Guid identity)
        {
            if (identity != Guid.Empty)
                this.Id = identity;
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                    _requestedHashCode = this.Id.GetHashCode() ^ 31; // XOR for random distribution (http://blogs.msdn.com/b/ericlippert/archive/2011/02/28/guidelines-and-rules-for-gethashcode.aspx)

                return _requestedHashCode.Value;
            }
            else
                return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity)) return false;
            if (Object.ReferenceEquals(this, obj)) return true;

            var item = obj as Entity;

            return (!this.IsTransient() && !item.IsTransient()) && this.Id == item.Id;
        }

        public static bool operator ==(Entity left, Entity right)
        {
            if (Object.Equals(left, null))
                return (Object.Equals(right, null)) ? true : false;
            else
                return left.Equals(right);
        }
        private DateTime _addTime;
        /// <summary>
        /// 注册时间
        /// </summary>
        public virtual DateTime AddTime
        {
            get
            {
                return _addTime.ToString() == "0001/1/1 0:00:00" ? DateTime.Now : _addTime;
            }
            set { _addTime = value; }
        }
        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }
    }
}
