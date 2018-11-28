using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor.Equipment
{
    public class EquipmentPackage
    {
        public int Id { get; set; }
        public string EquipmentPackageName { get; set; }
        public List<EquipmentPackage> IncludedPackages { get; set; }
        public List<EquipmentItem> IncludedItems { get; set; }
        public EquipmentPackage()
        {
            IncludedPackages = new List<EquipmentPackage>();
            IncludedItems = new List<EquipmentItem>();
        }
        public decimal GetPackagePrice()
        {
            var result = 0M;
            foreach (var item in IncludedItems)
            {
                result += item.Price;
            }
            foreach (var package in IncludedPackages)
            {
                foreach (var item in package.IncludedItems)
                {
                    result += item.Price;
                }
                foreach (var packageInPackage in package.IncludedPackages)
                {
                    foreach (var item in packageInPackage.IncludedItems)
                    {
                        result += item.Price;
                    }
                }
            }
            return result;
        }

        public List<string> GetEquipmentList()
        {
            var result = new List<string>();
            foreach (var item in IncludedItems)
            {
                result.Add(item.Name);
            }
            foreach (var package in IncludedPackages)
            {
                foreach (var item in package.IncludedItems)
                {
                    result.Add(item.Name);
                }
                foreach(var packageInPackage in package.IncludedPackages)
                {
                    foreach(var item in packageInPackage.IncludedItems)
                    {
                        result.Add(item.Name);
                    }
                }
            }
            return result;
        }
    }
}
