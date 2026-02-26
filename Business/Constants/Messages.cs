using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun Eklendi";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string MaintenanceTime = "sistem bakimda";
        public static string ProductsListed = "Urunler listelendi";
        public static string ProductCountOfCategoryError= "Bi kategoride en fazla 10 urun olabilir.";
        public static string ProductNameAllReadyExists="Bu isimde zaten baska bir urun var.";
        public static string CategoryLimitExceded= "Category limitiniz dolmustur.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserNotFound = "Kullanici Bulunamadi.";
        public static string UserRegistered = "Kullanici Kayitli.";
        public static string PasswordError = "Sifre hatali.";
        public static string SuccessfulLogin = "Kayıt basarili.";
        internal static string UserAlreadyExists = "Kullanici zaten kayitli.";
        internal static string AccessTokenCreated = "Access Token olusturuldu.";
    }
}
