using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P5DepricationCalc.Data.Models;
using P5DepricationCalc.Data;

namespace P5DepricationCalc.Data
{
    public class DeprecationCalc
    {
       
        public DeprecationCalc()
        {
            
        }


        public List<AssetDataClass> AgregateInventoryValue(List<AssetDataClass> myAssets)
        {
            int startYear = 3000;
            int endYear = 0;
            List<AssetDataClass> agregateData = new List<AssetDataClass>();
            var map = new Dictionary<int, int>();
            foreach (var assetData in myAssets)
            {
                if(assetData.year < startYear)
                {
                    startYear = assetData.year;
                }
                if(assetData.year > endYear)
                {
                    endYear = assetData.year;
                }
            }

            for(int i = startYear; i <= endYear; i++)
            {
                AssetDataClass item = new AssetDataClass();
                item.year = i;
                item.assetValue = 0;
                agregateData.Add(item);
            }

            for(int i = 0; i <= endYear - startYear; i++)
            {
                map.Add(startYear + i, i);
            }

            foreach(var assetData in myAssets)
            {
                agregateData[map[assetData.year]].assetValue += assetData.assetValue;
            }

            return agregateData;
        }


        public double CalcYearlyDepreciation(MyAsset asset)
        {
            double depAssetCost = asset.InitValue - asset.SalvageValue;
            float depRate = 1 / (float)asset.UsefullLife;
            double dep = depAssetCost * depRate;
            return Math.Round(dep, 0);
        }

        public List<AssetDataClass> GenerateValueByYear(MyAsset asset)
        {
            double assetValue = asset.InitValue;
            int YearsInInventory = asset.DateOut.Year - asset.DateIn.Year;
            List<AssetDataClass> assetDataClasses = new List<AssetDataClass>();
            
            for(int i = 0; i < YearsInInventory; i++)
            {
                AssetDataClass assetData = new AssetDataClass();
                assetData.assetValue = assetValue - asset.YearlyDeprecation;
                assetValue -= asset.YearlyDeprecation;
                assetData.year = asset.DateIn.Year + i;
                assetDataClasses.Add(assetData);
            }
            return assetDataClasses;
        }

        //public DeprecationCalc(MyAsset)

    }
}
