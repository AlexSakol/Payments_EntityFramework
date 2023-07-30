//КЛАСС DATABASEINITIALIZER
using System;
using System.Data.Entity;

namespace LAB_8.Models
{
    internal class DataBaseInitializer : DropCreateDatabaseIfModelChanges<EntityContext>
    {
        protected override void Seed(EntityContext context)
        {
            context.payments.AddRange(new Payment[]
            {
                new Payment{PaymentName = "Продукты", PaymentDate = new DateTime(2023, 7, 9), Price = 34.56m, PayerId=1},
                new Payment{PaymentName = "Одежда", PaymentDate = new DateTime(2023, 7, 5), Price = 54.60m, PayerId=1},
                new Payment{PaymentName = "Авто", PaymentDate = new DateTime(2023, 6, 19), Price = 103.80m, PayerId=1},
                new Payment{PaymentName = "Обувь", PaymentDate = new DateTime(2023, 6, 27), Price = 52.43m, PayerId=2},
                new Payment{PaymentName = "Авто", PaymentDate = new DateTime(2023, 7, 8), Price = 54.30m, PayerId=2},
                new Payment{PaymentName = "Транспорт", PaymentDate = new DateTime(2023, 6, 17), Price = 20.5m,PayerId=2},
                new Payment{PaymentName = "Продукты", PaymentDate = new DateTime(2023, 7, 2), Price = 50.89m,PayerId=3},
                new Payment{PaymentName = "Коммуналка", PaymentDate = new DateTime(2023, 6 , 22), Price = 90.70m,PayerId=3 },
                new Payment{PaymentName = "Обувь", PaymentDate = new DateTime(2023, 6, 29), Price = 70.65m,PayerId=3 }
            });
        }
    }
}
