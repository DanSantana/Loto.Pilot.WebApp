using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoroWebAppPilot.Models
{
    /// <summary>
    /// This model will hold a card with the numbers for 649
    /// </summary>
    public class GameCardModel
    {

        public List<int> CardNumbers { get; set; }

        public GameCardModel()
        {

        }

        public GameCardModel( List<int> cardNumbers)
        {
            CardNumbers = cardNumbers;
        }
    }
}