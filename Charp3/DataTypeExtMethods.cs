using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charp3
{
    public static class DataTypeExtMethods
    {
        public static string Base64EncodeBytes(this byte[] inputBytes) => (Convert.ToBase64String(inputBytes));
    }
}
