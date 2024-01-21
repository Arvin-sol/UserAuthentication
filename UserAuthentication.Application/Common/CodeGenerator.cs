using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthentication.Application.Common;

public static class CodeGenerator
{
    public static string GenerateUniqCode()
    {
        return Guid.NewGuid().ToString("N");
    }
}


