using System;
using System.Collections.Generic;
using System.Text;
using GamePlatformDemo.Business.Abstract;
using GamePlatformDemo.DataAccess.Concrete;
using GamePlatformDemo.Entities.Concrete;

namespace GamePlatformDemo.Business.Concrete
{
    public class AccountManager:IAccountManagement
    {
        private MemberDal _memberDal;

        public AccountManager(MemberDal memberDal)
        {
            _memberDal = memberDal;
        }
        public void SignUp(Member member)
        {
            _memberDal.Add(member); 
        }

        public void UpdateAccount(int id,Member member)
        {
            _memberDal.Update(id, member);
        }

        public void ListAccounts()
        {
            _memberDal.GetAll();
        }

        public void DeleteAccount(int id)
        {
            _memberDal.Delete(id);
        }
    }
}
