using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using MebelkiModel;
using System.Threading;
using System.Resources;

namespace MebelkiLogic
{
    public class ReportDocument : PrintDocument
    {
        private OrderSingleton _order;

        private Dictionary<Board, int> _boardsCount;

        private ResourceManager _resMen;

        private ReportDocumentGrid _grid;


        public ReportDocument(OrderSingleton order, ResourceManager resMen)
        {
            DefaultPageSettings.Landscape = true;
            _resMen = resMen;
            _order = order;

            CountBoards();

            this.PrintPage += ReportDocument_PrintPage;
        }

        private void CountBoards()
        {
            var boards = _order.FurnitureList.SelectMany(f => f.Boards).ToList();
            _boardsCount = boards.Distinct(new Board.BoardEqualityComparer()).ToDictionary(k => k,e => boards.Count(b => b.Equals(e)));
            
        }

        private void ReportDocument_PrintPage(object sender, PrintPageEventArgs e) 
        {
            PrintHeader(e);
            var font = new Font(FontFamily.GenericSerif, 9, FontStyle.Regular, GraphicsUnit.Point);
            Single y = 40;
            foreach (KeyValuePair<Board, int> pair in _boardsCount)
            {
                var printString = pair.Key + " x " + pair.Value;
                e.Graphics.DrawString(printString,
                    font, Brushes.Black, 20, y);
                y += e.Graphics.MeasureString(printString, font).Height;
            }
        }

        private void PrintHeader(PrintPageEventArgs e)
        {
            var ci = Thread.CurrentThread.CurrentCulture;

            var font = new Font(FontFamily.GenericSerif, 12, FontStyle.Bold, GraphicsUnit.Point);
            e.Graphics.DrawString(_order.Client, font, Brushes.Black, 20, 20);

            string thickness = _resMen.GetString("thickness", ci);
            string color = _resMen.GetString("color", ci);
            string height = _resMen.GetString("high", ci);
            string width = _resMen.GetString("width", ci);
            string boardSize = _resMen.GetString("boardSize", ci);
            string pricesm = _resMen.GetString("pricesm", ci);
            string price = _resMen.GetString("price", ci);
            string width1 = _resMen.GetString("vaneer", ci) + _resMen.GetString("width", ci) + " 1";
            string width2 = _resMen.GetString("vaneer", ci) + _resMen.GetString("width", ci) + " 2";
            string height1 = _resMen.GetString("vaneer", ci) + _resMen.GetString("high", ci) + " 1";
            string height2 = _resMen.GetString("vaneer", ci) + _resMen.GetString("high", ci) + " 2";
            string totalVaneer = _resMen.GetString("totalVaneer", ci);
            string vaneerPriceLm = _resMen.GetString("vaneer", ci) + " " + _resMen.GetString("pricelm", ci);
            string vaneerPrice = _resMen.GetString("vaneer", ci) + " " + _resMen.GetString("price", ci);
            string quantity = _resMen.GetString("quantity", ci); //add to res
            string boardPrice = _resMen.GetString("boardPrice", ci); //add to res

            font = new Font(FontFamily.GenericSerif, 10, FontStyle.Regular, GraphicsUnit.Point);

            //test
            //e.Graphics.DrawString(string.Join(" ", new string[]
            //{
            //    thickness, color, height, width, boardSize, pricesm, price, width1, width2, height1, height2,
            //    totalVaneer, vaneerPriceLm, vaneerPrice, quantity, boardPrice
            //}), font, Brushes.Black, 20, 60);

            _grid = new ReportDocumentGrid(
                e.Graphics, font,
                thickness,
                color,
                height,
                width,
                boardSize,
                pricesm,
                price,
                width1,
                width2,
                height1,
                height2,
                totalVaneer,
                vaneerPriceLm,
                vaneerPrice,
                quantity,
                boardPrice
                );

            _grid.PrintCells(e.Graphics, 20, 60);

            int x = 22;
            e.Graphics.DrawString(thickness, font, Brushes.Black, x, 62);
            x += e.Graphics.MeasureString(thickness, font).ToSize().Width + 5;
            e.Graphics.DrawString(color, font, Brushes.Black, x, 62);
            x += e.Graphics.MeasureString(color, font).ToSize().Width + 5;
            e.Graphics.DrawString(height, font, Brushes.Black, x, 62);
            x += e.Graphics.MeasureString(height, font).ToSize().Width + 5;
            e.Graphics.DrawString(width, font, Brushes.Black, x, 62);
            x += e.Graphics.MeasureString(width, font).ToSize().Width + 5;
            e.Graphics.DrawString(boardSize, font, Brushes.Black, x, 62);
            x += e.Graphics.MeasureString(boardSize, font).ToSize().Width + 5;
            e.Graphics.DrawString(pricesm, font, Brushes.Black, x, 62);
            x += e.Graphics.MeasureString(pricesm, font).ToSize().Width + 5;
            e.Graphics.DrawString(price, font, Brushes.Black, x, 62);
            x += e.Graphics.MeasureString(price, font).ToSize().Width + 5;
            e.Graphics.DrawString(width1, font, Brushes.Black, x, 62);
            x += e.Graphics.MeasureString(width1, font).ToSize().Width + 5;
            e.Graphics.DrawString(width2, font, Brushes.Black, x, 62);
            x += e.Graphics.MeasureString(width2, font).ToSize().Width + 5;
            e.Graphics.DrawString(height1, font, Brushes.Black, x, 62);
            x += e.Graphics.MeasureString(height1, font).ToSize().Width + 5;
            e.Graphics.DrawString(height2, font, Brushes.Black, x, 62);
            x += e.Graphics.MeasureString(height2, font).ToSize().Width + 5;
            e.Graphics.DrawString(totalVaneer, font, Brushes.Black, x, 62);
            x += e.Graphics.MeasureString(totalVaneer, font).ToSize().Width + 5;
            e.Graphics.DrawString(vaneerPriceLm, font, Brushes.Black, x, 62);
            x += e.Graphics.MeasureString(vaneerPriceLm, font).ToSize().Width + 5;
            e.Graphics.DrawString(vaneerPrice, font, Brushes.Black, x, 62);
            x += e.Graphics.MeasureString(vaneerPrice, font).ToSize().Width + 5;
            e.Graphics.DrawString(quantity, font, Brushes.Black, x, 62);
            x += e.Graphics.MeasureString(quantity, font).ToSize().Width + 5;
            e.Graphics.DrawString(boardPrice, font, Brushes.Black, x, 62);
          //  x += e.Graphics.MeasureString(boardPrice, font).ToSize().Width + 5;


            Rectangle[] rects = new Rectangle[]
            {
                new Rectangle(20,40,20,20),
                new Rectangle(40,40,20,20),
                new Rectangle(60,40,20,20),
                new Rectangle(80,40,20,20)
            };
            
            e.Graphics.DrawRectangles(Pens.Black, rects);
        }
    }
}