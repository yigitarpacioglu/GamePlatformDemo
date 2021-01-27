using System;
using System.Collections.Generic;
using System.Text;
using GamePlatformDemo.DataAccess.Abstract;
using GamePlatformDemo.Entities.Concrete;
using MernisServiceReference;

namespace GamePlatformDemo.DataAccess.Concrete
{
    public class MemberCheckManager:IMemberCheckService
    {
        public bool CheckIsRealPerson(Member member)
        {
            return true;
        }
    }
}
