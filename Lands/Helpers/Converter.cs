using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.Helpers
{
    using Models;
    using Domain;
    using System;
    public static class Converter
    {
        public static UserLocal ToUserLocal(User user)
        {
            return new UserLocal
            {
                Email = user.Email,
                FirstName = user.FirstName,
                ImagePath = user.ImagePath,
                LastName = user.LastName,
                Telephone = user.Telephone,
                UserId =user.UserId,
                UserTypeId = user.UserTypeId,
            };
        }
    }
}
