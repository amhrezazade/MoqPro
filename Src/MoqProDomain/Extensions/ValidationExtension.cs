using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqProDomain.Extensions
{
    public static class ValidationExtension
    {
        const string enCHars = "_qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        const string nums = "0123456789";

        public static bool IsValidName(this string name)
        {
            return true;
        }


    }
}
