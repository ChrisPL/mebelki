using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using MebelkiModel;
using MebelkiModel.Basic;
using MebelkiModel.Basic.Enums;

namespace MebelkiLogic
{
    [Serializable]
    public class Order
    {
        public static string Client { get; set; }
        
        public static List<Furniture> FurnitureList { get; set; }
            = new List<Furniture>();

        public static List<Material> MaterialList { get; set; }
            = new List<Material>();

        public static void LoadFurniture(int index, out string name, out List<string> boardList)
        {
            name = FurnitureList[index].Name;
            boardList = FurnitureList[index].Boards.Select(b => b.ToString()).ToList();
        }

        public static void LoadBoard(
            int fIndex
            , int bIndex
            , out string name
            , out string position
            , out object[] units
            , out object wUnit
            , out object hUnit
            , out decimal wValue
            , out decimal hValue
            , out object material
            , out string color
            , out List<string> vList
            , out double price)
        {
            var board = FurnitureList[fIndex].Boards[bIndex];
            name = board.ToString();
            position = board.Position;
            units = new object[] {LengthUnit.km, LengthUnit.dm, LengthUnit.m, LengthUnit.cm, LengthUnit.mm};
            wUnit = board.Width.Unit;
            hUnit = board.High.Unit;
            wValue = (decimal) board.Width.Value;
            hValue = (decimal) board.High.Value;
            material = board.Material;
            color = board.FrontColor;
            vList = board.GetVaneers().Select(v => v.ToString()).ToList();
            price = board.GetPrice();
        }


        public static OrderSingleton GetSingleton()
        {
            return new OrderSingleton(Client, FurnitureList, MaterialList);
        }

        public static void ReadSingleton(OrderSingleton os)
        {
            Client = os.Client;
            FurnitureList = new List<Furniture>(os.FurnitureList);
            MaterialList = new List<Material>(os.MaterialList);
        }

        public static void OrderReset()
        {
            Client = MebelkiModel.ModelResourceManager.GetString("NewClient");
            MaterialList = new List<Material>();
            FurnitureList = new List<Furniture>
            {
                new Furniture(MebelkiModel.ModelResourceManager.GetString("NewFurniture"))
            };
        }

        public static void FurnitureAddNew()
        {
            FurnitureList.Add(new Furniture(MebelkiModel.ModelResourceManager.GetString("NewFurniture")));
        }

        public static void BoardAddNew(int furnitureIndex)
        {
            FurnitureList[furnitureIndex].Boards.Add(new Board(
                string.Empty
                , string.Empty
                , new LengthMeasure(0)
                , new LengthMeasure(0)
                , null
                , new List<Vaneer>()
            ));
        }


        //TODO: This is test 
        #region TEST
        public static void Test()
        {
            Client = "Paulina Jaskulska";

            if (FurnitureList.Count > 0) return;
            for (int i = 0; i < 10; i++)
            {
                var f = new Furniture("Test " + i);
                for (int j = 0; j < 5; j++)
                {
                    var b = new Board("front", "Zielony mech", new LengthMeasure(i), new LengthMeasure(j), new Material("wood", new LengthMeasure(1), 10.5));
                    f.Boards.Add(b);
                }
                FurnitureList.Add(f);
            }

            if (MaterialList.Count > 0) return;
            MaterialList.AddRange(new[] { new Material("wood", new LengthMeasure(1), 10.5) });
        }
        #endregion
    }
}
