using System;
using System.Collections.Generic;
using GamePlatformDemo.DataAccess.Abstract;
using GamePlatformDemo.Entities.Concrete;

namespace GamePlatformDemo.DataAccess.Concrete
{
    public class MemberDal:IEntityRepository<Member>
    {
        private List<Member> _members;          // Verilerin tutulması için bir liste oluşturulmuştur. Database ile olan
                                                // bağlantıyı DataAccess kısmında kurduğumuz için, ben de listeleri database
                                                // gibi burada kullandım.
        private IMemberCheckService _memberCheckService;
        public MemberDal(List<Member> members, IMemberCheckService memberCheckService)
        {
            _members = members; // Constructor yardımıyla main'de oluşturacağımız liste yardımıyla oyuncuları bir listede tutacağız.
                                // İleride bunu database yardımıyla sağlıyor olacağız.
            _memberCheckService = memberCheckService;

        }
        public Member GetById(int id)
        {
            return _members[id - 1]; // Verilen ID numarası ile arama yapılıyor.
        }

        public void GetAll()
        {
            Console.WriteLine("\nExisting members in database:\n");
            Console.WriteLine("\n----------------------------  \n");
            foreach (var player in _members)
            {
                Console.WriteLine(player.Id+". "+ player.Name+" "+player.Lastname+" Birth Year: "+player.DateOfBirth.Year);
                // Oyuncu listesini GetAll() metodu yardımıyla, "1. Yiğit Arpacıoğlu Birth Year: 1995" şeklinde print ediyor olacağız
            }
            Console.WriteLine("\n------------------------------\n");
        }

        public void Add(Member member)
        {
            if (_memberCheckService.CheckIsRealPerson(member) == true)
            {
                _members.Add(member);   // Ekleme işlemi
                Console.WriteLine("\nWelcome to our community " + member.Name + "\n");
            }
            else
            {
                throw new Exception("This person does NOT exist in MERNIS");
            }
        }

        public void Update(int id, Member member)
        {
            Console.WriteLine("\nYour account has been updated " + member.Name + "\n");
            _members[id - 1] = member;    // Listeden kullanıcı tarafından güncellenmesi istenen değerin id'sini kullanarak
                                          // mevcut değerin yerine yeni bir kullanıcı tanımlayıp, yeni özellikler girerek güncellenecektir.
        }

        public void Delete(int id)
        {
            Console.WriteLine("\nWe are upset to hear that you are leaving "+_members[id - 1].Name+"\n");
            _members.Remove(_members[id-1]); // Listeden kullanıcı tarafından silinmesi istenen değerin id'sini kullanarak
                                             // mevcut değerin yerine yeni bir kullanıcı tanımlayıp, yeni özellikler girerek silinecektir.
        }
    }
}
