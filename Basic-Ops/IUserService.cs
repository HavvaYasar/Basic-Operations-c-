using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Ops
{
    interface IUserService
    {
        void Save(User user);

        void Update(User user);

        void Delete(User user);

    }
}
