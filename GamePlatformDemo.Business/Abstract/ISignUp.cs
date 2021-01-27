using System;
using System.Collections.Generic;
using System.Text;
using GamePlatformDemo.Entities.Concrete;

namespace GamePlatformDemo.Business.Abstract
{
    public interface IAccountManagement
    {
        // AccountManager'da gerçekleşecek olan hesap işlemleri burada tanımlanmıştır.
        void SignUp(Member member);
        void DeleteAccount(int id);
        void UpdateAccount(int id,Member member);
        void ListAccounts();
    }
}
