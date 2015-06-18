﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using MebelkiModel;

namespace MebelkiLogic
{
    public class ReportDocument : PrintDocument
    {
        private OrderSingleton _order;

        private Dictionary<Board, int> _boardsCount;

        public ReportDocument(OrderSingleton order)
        {
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
            var font = new Font(FontFamily.GenericSerif, 12, FontStyle.Bold, GraphicsUnit.Point);
            e.Graphics.DrawString(_order.Client, font, Brushes.Black, 20, 20);
            /*
            Rectangle[] rects = new Rectangle[]
            {
                new Rectangle(20,40,20,20),
                new Rectangle(40,40,20,20),
                new Rectangle(60,40,20,20),
                new Rectangle(80,40,20,20)
            };
            
            e.Graphics.DrawRectangles(Pens.Black, rects);*/
        }
    }
}