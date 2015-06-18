using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using MebelkiModel.Basic;
using MebelkiModel.Basic.Enums;

namespace MebelkiModel
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Furniture
    {
        public string Name;
        public List<Board> Boards { get; set; }

        public Furniture(string name)
        {
            Name = name;
            Boards = new List<Board>();
        }

        public Furniture()
        {
            Name = String.Empty;
            Boards = new List<Board>();
        }

        public Furniture(string name, List<Board> boards)
        {
            Name = name;
            Boards = boards;
        }

        public Furniture(Furniture f)
        {
            Name = f.Name;
            Boards = new List<Board>(f.Boards);
        }

        ~Furniture()
        {
            Boards.Clear();
        }

        public override string ToString()
        {
            return Name;
        }
        
    }
}
