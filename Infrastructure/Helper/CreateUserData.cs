using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Message;
using FizzWare.NBuilder;
namespace Infrastructure.Helper
{
    public class CreateUserData
    {
        public static IEnumerable<GetUsersMsg> Create()
        {
            var users = Builder<GetUsersMsg>.CreateListOfSize(10).All()
                .With(u => u.Name = Faker.Name.FullName())
                .With(u => u.Id = Faker.RandomNumber.Next(999999))
                .With(u => u.Age = Faker.RandomNumber.Next(10, 80))
                .Build();
            return users;
        }
    }
}
