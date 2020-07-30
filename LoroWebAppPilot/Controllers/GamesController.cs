using System;
using System.Collections.Generic;
using System.Web.Mvc;
using LoroWebAppPilot.Models;


namespace LoroWebAppPilot.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Games()
        {
            GamesModel games = new GamesModel(1, Convert.ToDateTime("08/18/2020"), 1 );
            games.GameCards = GenerateGames(games.QuantityOfCards);



            return View();
        }

        private List<GameCardModel> GenerateGames(int qtyofCards)
        {
            var games = new List<GameCardModel>();
            // Create card with the numbers to sort
            int[] numbersToSord = addNumbers(49);

            for (int i = 0; i < qtyofCards; i++)
            {
                var gameCard = new GameCardModel();
                gameCard.CardNumbers = buildCard(numbersToSord);
                games.Add(gameCard);
            }
            //throw new NotImplementedException();
            return games;
        }

        private List<int> buildCard(int[] numbersToSord)
        {
            int[] newCard = new int[6];

            for (int i = 0; i < newCard.Length; i++)
            {

            }
            // Validation Rules to add a card:
            // Impar vs Par
            // Sequence limited
            // Card groups analises
            // Numbers in the last 10 draws selection
            //
            throw new NotImplementedException();
        }

        private int[] addNumbers(int cardLimit)
        {
            int[] numbersToSord = new int[cardLimit];
            for (int i = 0; i < cardLimit; i++)
            {
                numbersToSord[i] = i+1;
            }
            return numbersToSord;
        }
    }
}