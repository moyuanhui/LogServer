using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogServer.Common;
using LogServer.Common.Validator;
using LogServer.Model;
using LogServer.Model.Entity;

namespace LogServer.BLL
{
    public class MemberService : BasicService<Member>
    {
        /// <summary>
        /// 会员注册
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="memberName"></param>
        /// <param name="password"></param>
        public void SubmitMember(string Id,string memberName,string password)
        {
            var model = new Member()
            {
                MemberID = Guid.NewGuid().ToString().Replace("-",""),
                MemberName=memberName,
                MemberPassword = password

            };
            var validator = EntityValidatorFactory.CreateValidator();
            if (!validator.IsValid(model))
                throw new NeedToShowFrontException("输入不合法");
            Add(model);
        }
        public IPagedList<Member> GetAlLogs(int pageIndex, int pageSize, string appKeyId)
        {
            var query = GetList(pageIndex, pageSize, x => "1" == appKeyId, x => x.AddTime, true);
            var list = query.Select(x => new Member()).ToList();
            return query.ConvertData(list);
        }
    }
}
