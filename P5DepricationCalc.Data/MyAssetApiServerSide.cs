using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P5DepricationCalc.Data.Interfaces;
using P5DepricationCalc.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace P5DepricationCalc.Data
{
    public class MyAssetApiServerSide : MyAssetApi
    {
        IDbContextFactory<AssetDbContext> factory;

        public MyAssetApiServerSide (IDbContextFactory<AssetDbContext> factory)
        {
            this.factory = factory;
        }

        public async Task<MyAsset> GetAssetAsync(int id)
        {
            using var context = factory.CreateDbContext();
            return await context.MyAssets.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task DeleteAssetAsync(MyAsset item)
        {
            using var context = factory.CreateDbContext();
            context.Remove(item);
            await context.SaveChangesAsync();
        }

        public async Task<MyAsset> SaveAssetAsync(MyAsset item)
        {
            using var context = factory.CreateDbContext();
            if(item.Id == 0)
            {
                context.Add(item);
            }
            else
            {
                var asset = item as MyAsset;
                var currentAsset = await context.MyAssets.FirstOrDefaultAsync(p => p.Id == asset.Id);
                currentAsset.InitValue = asset.InitValue;
                currentAsset.SalvageValue = asset.SalvageValue;
                currentAsset.UsefullLife = asset.UsefullLife;
                currentAsset.GraphVis = asset.GraphVis;
                currentAsset.DateOut = asset.DateOut;
                currentAsset.DateIn = asset.DateIn;
                await context.SaveChangesAsync();
            }
            await context.SaveChangesAsync();
            return item;
        }

        public async Task<List<MyAsset>> GetMyAssetsAsync(int numberofposts, int startindex)
        {
            using var context = factory.CreateDbContext();

            return await context.MyAssets.OrderByDescending(p => p.DateIn).Skip(startindex).Take(numberofposts).ToListAsync();
        }

    }
}
