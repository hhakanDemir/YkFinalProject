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
    }
}
