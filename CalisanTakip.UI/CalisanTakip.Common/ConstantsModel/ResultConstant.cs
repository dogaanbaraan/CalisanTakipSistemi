﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanTakip.Common.ConstantsModel
{
    public static class ResultConstant
    {
        public const string RecordFound = "Kayıt bulundu";
        public const string RecordNotFound = "Kayıt bulunamadı";

        public const string AddedOk = "Ekleme işlemi başarılı";
        public static string AddedNotOk = "Ekleme işlemi başarısız";

        public const string UpdateOk = "Güncelleme işlemi başarılı";
        public const string UpdateNotOk =  "Güncelleme işlemi başarısız" ;

        public const string DeleteOk = "Silme İşlemi tamamlandı";
        public const string DeleteNotOk = "Silme işlemi başarısız";

        public const string Admin_Role = "Administrator";
        public const string Employee_Role = "Employee";

        public const string Admin_Email = "barno@gmail.com";
        public const string Admin_Password = "Barno.123";

        public const string LoginUserInfo = "Giriş yapan kullanıcı bilgisi";

        public const string MailTagHelperSuffeix = "@gmail.com";
    }
}
