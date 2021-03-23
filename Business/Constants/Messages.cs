using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";

        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductListed="Ürünler listelendi";
        public static string UnitPriceInvalid = "Geçersiz fiyat";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExist="Aynı isimde başka bir ürün var";
        public static string CategoryLimitExceeded="Kategori limiti aşıldı";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered="Kayıt başarılı";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı zaten mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
