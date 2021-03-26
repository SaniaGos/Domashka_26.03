using System;
using System.Linq;
using System.Text;
using CommodityTurnover.Klass;

namespace CommodityTurnover
{
    class Turnover
    {
        public MovementOfGoods Incoming { get; private set; } // спочатку це були різні класи які наслідувалися від MovementOfGoods, але вони були пустими, то ж  видалив їх і створив 4 журнали від одного класу
        public MovementOfGoods Realize { get; private set; }
        public MovementOfGoods Transfer { get; private set; }
        public MovementOfGoods WriteOff { get; private set; }
        public Turnover()
        {
            Incoming = new MovementOfGoods();
            Realize = new MovementOfGoods();
            Transfer = new MovementOfGoods();
            WriteOff = new MovementOfGoods();
        }
        public void IncomingItem(Product product)
        {
            Incoming.InCome(product);
            View.ViewProduct(product, "Incoming");
        }
        public void IncomingItem(Product[] products)
        {
            foreach (Product item in products)
            {
                Incoming.InCome(item);
                View.ViewProduct(item, "Incoming");
            }
        }
        public void RealizeItem(int id)
        {
            try
            {
                int iter = Incoming.FindElement(id);
                Realize.InCome(Incoming[iter]);
                View.ViewProduct(Incoming[iter], "Realize ");
                Incoming.OutCome(iter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);               
            }
        }
        public void TransferItem(int id)
        {
            try
            {
                int iter = Incoming.FindElement(id);
                Transfer.InCome(Incoming[iter]);
                View.ViewProduct(Incoming[iter], "Transfer");
                Incoming.OutCome(iter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void WriteOffItem(int id)
        {
            try
            {
                int iter = Incoming.FindElement(id);
                WriteOff.InCome(Incoming[iter]);
                View.ViewProduct(Incoming[iter], "WriteOff");
                Incoming.OutCome(iter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Remainder()
        {
            foreach (Product item in Incoming)
            {
                View.ViewProduct(item, "Remainder");
            }
        }
    }
}
