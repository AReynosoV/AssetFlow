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
        public List<Models.Asset> GetMockAssets()
        {
            return new List<Models.Asset>
            {
                new Models.Asset { Id = 1, Name = "Laptop Dell XPS", CategoryId = 1, PurchaseDate = DateTime.Now.AddYears(-1), Status = "Activo", Cost = 1500 },
                new Models.Asset { Id = 2, Name = "Monitor LG 27\"", CategoryId = 1, PurchaseDate = DateTime.Now.AddMonths(-6), Status = "Activo", Cost = 300 },
                new Models.Asset { Id = 3, Name = "Licencia Visual Studio", CategoryId = 2, PurchaseDate = DateTime.Now, Status = "Asignado", Cost = 450 }
            };
        }
    }
}
