using Plochki.Models;
using Plochki.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plochki.Controllers
{
    public class PlochkiController
    {
        PlochkiDisplay myDisp = new PlochkiDisplay();
        PlochkiModel myModel;

        public void Start()
        {
            myDisp.Input();
            myModel = new PlochkiModel(myDisp.N, myDisp.W, myDisp.L, myDisp.M, myDisp.O);
            myDisp.tilesNeeded = myModel.CalculateTiles();
            myDisp.timeNeeded = myModel.CalculateTime();
            myDisp.Output();
        }
    }
}
