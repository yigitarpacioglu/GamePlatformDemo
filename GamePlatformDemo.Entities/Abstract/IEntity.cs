using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatformDemo.Entities.Abstract
{
    // Bu dosya interface yapısı yardımıyla varlıklar arası bir arayüz oluşturmaktadır ve ortak özelliklerin implemente edilmesini sağlamaktadır.
    public interface IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
