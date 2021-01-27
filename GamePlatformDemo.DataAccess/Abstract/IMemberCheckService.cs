using System;
using System.Collections.Generic;
using System.Text;
using GamePlatformDemo.Entities.Concrete;

namespace GamePlatformDemo.DataAccess.Abstract
{
    public interface IMemberCheckService
    {
        bool CheckIsRealPerson(Member member);
    }
}
