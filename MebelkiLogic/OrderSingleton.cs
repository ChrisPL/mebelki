using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MebelkiModel;

namespace MebelkiLogic
{
    [Serializable]
    public class OrderSingleton
    {
        public OrderSingleton()
        {
            Client = String.Empty;
            FurnitureList = new List<Furniture>();
            MaterialList = new List<Material>();
        }

        public OrderSingleton(string client, List<Furniture> furnitureList, List<Material> materialList)
        {
            Client = client;
            FurnitureList = new List<Furniture>(furnitureList);
            MaterialList = new List<Material>(materialList);
        }

        public string Client { get; set; }

        public List<Furniture> FurnitureList { get; set; }

        public List<Material> MaterialList { get; set; }

        
    }
}
