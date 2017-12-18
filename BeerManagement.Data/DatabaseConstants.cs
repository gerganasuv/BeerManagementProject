using System;
using System.Collections.Generic;
using System.Text;

namespace BeerManagement.Data
{
    public static class DatabaseConstants
    {

        public const int NameCustomerMin = 10;
        public const int NameCustomerMax = 400;

        public const int BeerDescriptionMin = 10;
        public const int BeerDescriptionMax = 1000;

        public const int BeerNationalityMin = 3;
        public const int BeerNationalityMax = 100;

        public const int CompanyNameMin = 1;
        public const int CompanyNameMax = 300;
    }
}
