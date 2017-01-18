using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Review
{

    public interface IHasOil
    {
        void ChangeOil();
    }

    public interface IFillUpAble
    {
        void FillUp();
    }

    public interface IHasTires
    {
        void ChangeTires();
    }


    // a garage for my all my cars
    public class Shop
    {
        private ILogger logger { get; set; }
        public Shop( ILogger l)
        {
            this.logger = l;
        }

        public void ChangeCarsOil(IHasOil machine)
        {
            logger.WriteLog("Shop is changing oil - Changing Oil");
            machine.ChangeOil();
        }
        public void FillUp() { }
        public void ChangeTire(IHasTires vechile)
        {
            vechile.ChangeTires();
        }
    }
}
