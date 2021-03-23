using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string BrandAdded = "Araba markası eklendi.";
        public static string BrandsListed = "Araba markaları listelendi.";
        public static string BrandDeleted = "Araba markası silindi.";
        public static string ColorAdded = "Araba renk bilgisi eklendi.";
        public static string RentalAdded = "Araba kiralama bilgisi eklendi.";
        public static string RentalDeleted = "Araba kiralama bilgisi silindi.";
        public static string RentalListed = "Araba kiralama bilgileri listelendi.";
        public static string DailyPriceInvalid = "Günlük kiralama bedeli sıfırdan farklı olmalıdır.";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string AuthorizationDenied = "Giriş başarısız";
        public static string UserRegistered ="Kullanıcı girişi başarılı.";
        public static string UserNotFound ="Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten var";
        public static string AccessTokenCreated = "Access token oluşturuldu.";
    }
}
