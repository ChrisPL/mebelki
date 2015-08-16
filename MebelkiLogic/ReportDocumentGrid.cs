using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MebelkiModel;
using MebelkiModel.Basic.Enums;

namespace MebelkiLogic
{
    public class ReportDocumentGrid
    {
        private Size _thicknessCell;
        private Size _colorCell;
        private Size _heightCell;
        private Size _widthCell;
        private Size _boardSizeCell;
        private Size _pricesmCell;
        private Size _priceCell;
        private Size _width1Cell;
        private Size _width2Cell;
        private Size _height1Cell;
        private Size _height2Cell;
        private Size _totalVaneerCell;
        private Size _vaneerPriceLmCell;
        private Size _vaneerPriceCell;
        private Size _quantityCell;
        private Size _boardPriceCell;

        public ReportDocumentGrid(
            Graphics g,
            Font f,
            string thickness,
            string color,
            string height,
            string width,
            string boardSize,
            string pricesm,
            string price,
            string width1,
            string width2,
            string height1,
            string height2,
            string totalVaneer,
            string vaneerPriceLm,
            string vaneerPrice,
            string quantity,
            string boardPrice
            )
        {
            _thicknessCell = g.MeasureString(thickness, f).ToSize() + new Size(5, 5);
            _colorCell = g.MeasureString(color, f).ToSize() + new Size(5, 5);
            _heightCell = g.MeasureString(height, f).ToSize() + new Size(5, 5);
            _widthCell = g.MeasureString(width, f).ToSize() + new Size(5, 5);
            _boardSizeCell = g.MeasureString(boardSize, f).ToSize() + new Size(5, 5);
            _pricesmCell = g.MeasureString(pricesm, f).ToSize() + new Size(5, 5);
            _priceCell = g.MeasureString(price, f).ToSize() + new Size(5, 5);
            _width1Cell = g.MeasureString(width1, f).ToSize() + new Size(5, 5);
            _width2Cell = g.MeasureString(width2, f).ToSize() + new Size(5, 5);
            _height1Cell = g.MeasureString(height1, f).ToSize() + new Size(5, 5);
            _height2Cell = g.MeasureString(height2, f).ToSize() + new Size(5, 5);
            _totalVaneerCell = g.MeasureString(totalVaneer, f).ToSize() + new Size(5, 5);
            _vaneerPriceLmCell = g.MeasureString(vaneerPriceLm, f).ToSize() + new Size(5, 5);
            _vaneerPriceCell = g.MeasureString(vaneerPrice, f).ToSize() + new Size(5, 5);
            _quantityCell = g.MeasureString(quantity, f).ToSize() + new Size(5, 5);
            _boardPriceCell = g.MeasureString(boardPrice, f).ToSize() + new Size(5, 5);
        }

        public Point PrintCells(Graphics g, int X, int Y)
        {
            return PrintCells(g, new Point(X, Y));
        }

        public Point PrintCells(Graphics g, Point startPoint)
        {
            List<Rectangle> cells = new List<Rectangle>();
            
            cells.Add(new Rectangle(startPoint, _thicknessCell));
            startPoint.X += _thicknessCell.Width;
            cells.Add(new Rectangle(startPoint, _colorCell));
			startPoint.X += _colorCell.Width;
            cells.Add(new Rectangle(startPoint, _heightCell));
			startPoint.X += _heightCell.Width;
            cells.Add(new Rectangle(startPoint, _widthCell));
			startPoint.X += _widthCell.Width;
            cells.Add(new Rectangle(startPoint, _boardSizeCell));
			startPoint.X += _boardSizeCell.Width;
            cells.Add(new Rectangle(startPoint, _pricesmCell));
			startPoint.X += _pricesmCell.Width;
            cells.Add(new Rectangle(startPoint, _priceCell));
			startPoint.X += _priceCell.Width;
            cells.Add(new Rectangle(startPoint, _width1Cell));
			startPoint.X += _width1Cell.Width;
            cells.Add(new Rectangle(startPoint, _width2Cell));
			startPoint.X += _width2Cell.Width;
            cells.Add(new Rectangle(startPoint, _height1Cell));
			startPoint.X += _height1Cell.Width;
            cells.Add(new Rectangle(startPoint, _height2Cell));
			startPoint.X += _height2Cell.Width;
            cells.Add(new Rectangle(startPoint, _totalVaneerCell));
			startPoint.X += _totalVaneerCell.Width;
            cells.Add(new Rectangle(startPoint, _vaneerPriceLmCell));
			startPoint.X += _vaneerPriceLmCell.Width;
            cells.Add(new Rectangle(startPoint, _vaneerPriceCell));
			startPoint.X += _vaneerPriceCell.Width;
            cells.Add(new Rectangle(startPoint, _quantityCell));
			startPoint.X += _quantityCell.Width;
            cells.Add(new Rectangle(startPoint, _boardPriceCell));
			startPoint.X += _boardPriceCell.Width;

            g.DrawRectangles(Pens.Black, cells.ToArray());

            return startPoint;
        }

        public Point PrintRow(Graphics g, Point startPoint, KeyValuePair<Board, int> rowData)
        {
            var endPoint = PrintCells(g, startPoint);
            FillCells(g, startPoint, rowData);
            return endPoint;
        }

        public void FillCells(Graphics g, Point startPoint, KeyValuePair<Board, int> rowData)
        {
            var ci = Thread.CurrentThread.CurrentCulture;
            Font f = new Font(FontFamily.GenericSerif, 9, FontStyle.Regular, GraphicsUnit.Point);
            var xy = startPoint;
            xy.Offset(new Point(2, 2));
            g.DrawString(rowData.Key.Material.Thick.ToString(), f, Brushes.Black, xy);
            xy.X += _thicknessCell.Width;

            g.DrawString(rowData.Key.FrontColor, f, Brushes.Black, xy);
            xy.X += _colorCell.Width;

            g.DrawString(rowData.Key.High.ToString(), f, Brushes.Black, xy);
            xy.X += _heightCell.Width;

            g.DrawString(rowData.Key.Width.ToString(), f, Brushes.Black, xy);
            xy.X += _widthCell.Width;

            g.DrawString(rowData.Key.Size, f, Brushes.Black, xy);
            xy.X += _boardSizeCell.Width;

            g.DrawString(rowData.Key.Material.PriceSm.ToString(ci), f, Brushes.Black, xy);
            xy.X += _pricesmCell.Width;

            g.DrawString(rowData.Key.GetPrice().ToString(ci), f, Brushes.Black, xy);
            xy.X += _priceCell.Width;

            g.DrawString(rowData.Key.GetVaneers().Any(v => v.Side == Side.Width1) ? "X" : "", f, Brushes.Black, xy);
            xy.X += _width1Cell.Width;

            g.DrawString(rowData.Key.GetVaneers().Any(v => v.Side == Side.Width2) ? "X" : "", f, Brushes.Black, xy);
            xy.X += _width2Cell.Width;

            g.DrawString(rowData.Key.GetVaneers().Any(v => v.Side == Side.Height1) ? "X" : "", f, Brushes.Black, xy);
            xy.X += _height1Cell.Width;

            g.DrawString(rowData.Key.GetVaneers().Any(v => v.Side == Side.Height2) ? "X" : "", f, Brushes.Black, xy);
            xy.X += _height2Cell.Width;

            g.DrawString(rowData.Key.GetVaneers().Sum(v => v.Length).ToString(ci), f, Brushes.Black, xy);
            xy.X += _totalVaneerCell.Width;

            g.DrawString(rowData.Key.GetVaneers().Count > 0 ? rowData.Key.GetVaneers().Max(v => v.PriceLm).ToString(ci) : "", f, Brushes.Black, xy);
            xy.X += _vaneerPriceLmCell.Width;

            g.DrawString(rowData.Key.GetVaneers().Sum(v => v.GetTotalPrice()).ToString(ci), f, Brushes.Black, xy);
            xy.X += _vaneerPriceCell.Width;

            g.DrawString(rowData.Value.ToString(), f, Brushes.Black, xy);
            xy.X += _quantityCell.Width;

            g.DrawString((rowData.Value * rowData.Key.GetPrice()).ToString(ci), f, Brushes.Black, xy);
            xy.X += _boardPriceCell.Width;
        }
    }
}
