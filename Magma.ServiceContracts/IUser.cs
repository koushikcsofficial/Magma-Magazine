using System;
using System.Collections.Generic;
using Magma.DomainModels;

namespace Magma.ServiceContracts
{
    public interface IUser
    {
        void insertUserAccount(UserAccount ua);
        void insertUserDetails(UserDetail ud);
        void insertUserAccountAsync(UserAccount ua);
        void insertUserDetailsAsync(UserDetail ud);

        void updateUserAccount(UserAccount ua);
        void updateUserDetails(UserDetail ud);
        void updateUserAccountAsync(UserAccount ua);
        void updateUserDetailsAsync(UserDetail ud);
    }
}
