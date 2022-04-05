using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Country
    {
        String countryCode;
        String countryName;
        //инициализация
        public void set(
            String countryName,
        String countryCode)
        { this.countryCode = countryCode;
          this.countryName = countryName;
        }
    }
}
