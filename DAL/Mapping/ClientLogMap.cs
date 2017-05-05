using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogServer.Model.Entity;

namespace LogServer.DAL.Mapping
{
    public class ClientLogMap: EntityTypeConfiguration<ClientLog>
    {
        public ClientLogMap()
        {
            HasKey(x => x.Id).Property(x => x.Id);
            
            Property(x => x.AppKeyId).HasColumnName("AppKeyId").HasMaxLength(100).IsRequired();
            Property(x => x.IsDebug).HasColumnName("IsDebug");
            Property(x => x.LogTag).HasColumnName("LogTag").HasMaxLength(100);
            Property(x => x.LogInfo).HasColumnName("LogInfo").HasMaxLength(int.MaxValue).IsRequired();
            Property(x => x.LogSrcInfo).HasColumnName("LogSrcInfo").HasMaxLength(400);
            Property(x => x.ClientInfo).HasColumnName("ClientInfo").HasMaxLength(400);
            Property(x => x.State).HasColumnName("State");
            Property(x => x.Remark).HasColumnName("Remark").HasMaxLength(400);
            Property(x => x.AddTime).HasColumnName("AddTime");
            ToTable("tb_ClientException");
        }
    }
}
