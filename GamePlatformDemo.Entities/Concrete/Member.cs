using System;
using System.Collections.Generic;
using System.Text;
using GamePlatformDemo.Entities.Abstract;

namespace GamePlatformDemo.Entities.Concrete
{
    // Bu dosya müşteriye ait bilgileri tutmaktadır.
    public class Member:IEntity
    {
        public int Id { get; set; }                 // Customer Id                 : Müşteri için oyun firması tarafından verilen müşteri numarası
        public string Name { get; set; }            // First name of Customer      : Müşteri adı        

        
        public string Lastname { get; set; }        // Last name of Customer       : Müşteri soyadı


        public long TC { get; set; }                // ID number of Customer       : Müşteri TC Kimlik numarası
        public DateTime DateOfBirth { get; set; }   // Birth Date of Customer      : Müşteri doğum tarihi
    }
}
