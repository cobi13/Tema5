﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema5
{
    public class Mill
    {
        private int weight;
        private RawMaterials rawMaterial;
        private ProductTypes productType;
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

        public enum RawMaterials
        {
            normalGrain,
            mediumGrain,
            superiorGrain
        }
        public enum ProductTypes
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

        public abstract class Milling : Mill, IMilling
        {
            public void PreparingRawMaterialForMilling()
            {
                Console.WriteLine("Preparing raw material for milling process!");
            }

            public void PreparingRawMaterialForMilling(int weight)
            {
                Console.WriteLine("Preparing an exact weight of raw material for milling process!");
            }
            public virtual void MillingProcess()
            {
                Console.WriteLine("Milling process");
            }
            public void SetExpirationDate(ProductTypes productType)
            {
                Console.WriteLine(DateTime.Now);
            }
        }

        public interface IMilling
        {
            void PreparingRawMaterialForMilling();
        }
        public class Flour : Milling
        {
            public enum FlourType
            {
                F480,
                F550,
                F650,
                F1350
            }
            public override void MillingProcess()
            {
                Console.WriteLine("Milling process for flour");
            }
        }

        public class Bran : Milling
        {
            public override void MillingProcess()
            {
                Console.WriteLine("Milling process for bran");
            }
        }

        public class BagFlour : Flour
        {
            public void Bagging()
            {
                Console.WriteLine("Bagging flour!");
            }
        }

        public class BulkFlour : Flour
        {
            public void LoadingBulk()
            {
                Console.WriteLine("Loading bulk flour!");
            }
        }

        public class BagBran : Bran
        {
            public void Bagging()
            {
                Console.WriteLine("Bagging bran!");
            }
        }

        public class BulkBran : Bran
        {
            public void LoadingBulk()
            {
                Console.WriteLine("Loading bulk bran!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
