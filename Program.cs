using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema5
{
    class Program
    {
        class Mill
        {
            private DateTime productionDate;
            private DateTime expirationDate;
            public enum EmployeeType
            {
                Worker,
                Driver,
                Management,
                Salesman,
                PR
            }

            public enum ProductType
            {
                Flour,
                Bran
            }

            public DateTime ProductionDate
            {
                get
                {
                    return this.productionDate;
                }

            }
            public DateTime ExpirationDate
            {
                get
                {
                    return this.expirationDate;
                }
                set
                {
                    this.expirationDate = value;
                }

            }
            void SetExpirationDate(ProductType tipProdus)
            {

            }
            void Milling()
            {
                Console.WriteLine("Milling process");
            }
        }

        class Flour : Mill
        {
            public enum FlourType
            {
                F480,
                F550,
                F650,
                F1350
            }
        }

        class Bran : Mill
        {

        }

        class BagFlour : Flour
        {

        }

        class BulkFlour : Flour
        {

        }

        class BagBran : Bran
        {

        }

        class BulkBran : Bran
        {

        }
        static void Main(string[] args)
        {


        }
    }
}
