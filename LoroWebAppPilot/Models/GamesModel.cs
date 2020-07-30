using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoroWebAppPilot.Models
{
    /// <summary>
    /// This Model will hold all card games.
    /// </summary>
    public class GamesModel
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public int QuantityOfCards { get; set; }
        public List<GameCardModel> GameCards { get; set; }

        public GamesModel()
        {

        }
        public GamesModel(int id, DateTime date, int quantityOfCards, List<GameCardModel> gameCards)
        {
            Id = id;
            this.date = date;
            QuantityOfCards = quantityOfCards;
            GameCards = gameCards;
        }

        public GamesModel(int id, DateTime date, int quantityOfCards)
        {
            Id = id;
            this.date = date;
            QuantityOfCards = quantityOfCards;
        }
    }
}