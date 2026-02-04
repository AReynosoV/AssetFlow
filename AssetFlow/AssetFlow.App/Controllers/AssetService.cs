using AssetFlow.App.Data;
using AssetFlow.App.Models;
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
            return _context.Assets
                .Where (a => !a.IsDeleted)
                .ToList();
        }

        public void SoftDeleteAsset(Models.Asset asset) 
        {
            // En lugar de _context.Assets.Remove(asset), hacemos magia:
            asset.IsDeleted = true;
            _context.Update(asset);
            _context.SaveChanges();
        }

        public List<AssetFlow.App.Models.Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public List<Status> GetStatuses()
        {
            return _context.Statuses.ToList();
        }
    }
}
