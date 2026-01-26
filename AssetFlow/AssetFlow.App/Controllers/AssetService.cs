using AssetFlow.App.Data;
using DevExpress.XtraLayout.Customization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssetFlow.App.Controllers
{
    public class AssetService
    {
        private readonly AssetDbContext _context;
        public AssetService(AssetDbContext context)
        {
            _context = context;
        }
        //public List<Models.Asset> GetMockAssets()
        //{
        //    return _context.Assets.ToList();
        //}

        public void AddAsset(Models.Asset asset)
        {
            _context.Assets.Add(asset);
            _context.SaveChanges();
        }

        public void UpdateAsset(Models.Asset asset)
        {
            _context.Assets.Update(asset);
            _context.SaveChanges();
        }

        public List<Models.Asset> GetAllAssets()
        {
            return _context.Assets.ToList();
        }
    }
}
