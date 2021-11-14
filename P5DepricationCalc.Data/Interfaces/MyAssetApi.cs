using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P5DepricationCalc.Data.Models;
using P5DepricationCalc.Data.Interfaces;


namespace P5DepricationCalc.Data.Interfaces
{
    public interface MyAssetApi
    {
        Task<MyAsset> GetAssetAsync(int id);
        Task<MyAsset> SaveAssetAsync(MyAsset item);
        Task DeleteAssetAsync(MyAsset item);

        Task<List<MyAsset>> GetMyAssetsAsync(int numberofposts, int startindex);
    }     
}
