using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogServer.Model.Entity;

namespace LogServer.DAL.Mapping
{
    public class MemberMap : EntityTypeConfiguration<ClientLog>
    {

        public MemberMap()
        {
            HasKey(x => x.Id).Property(x => x.Id);

            Property(x => x.AppKeyId).HasColumnName("MemberID").HasMaxLength(32).IsRequired();
            Property(x => x.IsDebug).HasColumnName("MemberName").IsRequired();
            Property(x => x.LogTag).HasColumnName("MemberPassword").IsRequired();
            //Property(x => x.LogInfo).HasColumnName("LogInfo").HasMaxLength(int.MaxValue).IsRequired();
            //Property(x => x.LogSrcInfo).HasColumnName("LogSrcInfo").HasMaxLength(400);
            //Property(x => x.ClientInfo).HasColumnName("ClientInfo").HasMaxLength(400);
            //Property(x => x.State).HasColumnName("State");
            //Property(x => x.Remark).HasColumnName("Remark").HasMaxLength(400);
            //Property(x => x.AddTime).HasColumnName("AddTime");
            ToTable("tb_MemgerException");
        }
    }
}
