﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magma.ServiceContracts
{
    public interface IAuthor
    {
        bool IsAuthorById(int? Id);

        bool IsSubscribed(int? AuthorId, int? UserId);
    }
}
