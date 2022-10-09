using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PokerFriends.Models;

namespace PokerFriends.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult PlayerList(int playerCount, int buyInAmount)
        {
            var model = new PlayerListModel
            {
                PlayerCount = playerCount,
                BuyInAmount = buyInAmount
            };
            return View("~/views/home/PlayerList.cshtml", model);
        }

        [HttpPost]
        public ActionResult Scoreboard(string players, int buyInAmount)
        {
            var playerList = players.Split(",").ToList();
            var scoreboardPlayers = new List<string>();
            playerList.ForEach(p => scoreboardPlayers.Add(p));
            var model = new ScoreboardModel
            {
                Players = scoreboardPlayers,
                BuyInAmount = buyInAmount
            };
            return View("~/views/home/Scoreboard.cshtml", model);
        }

        [HttpPost]
        public JsonResult SimplifyDebts(string[] players, decimal[] gains)
        {
            var playerBalances = new List<PlayerGainModel>();
            for (int i = 0; i < players.Length; i++)
            {
                var balance = new PlayerGainModel
                {
                    Player = players[i],
                    GainAmount = gains[i]
                };
                playerBalances.Add(balance);
            }
            var sDebtsList = SimplifiedDebts(playerBalances).ToList();

            return Json(sDebtsList);
        }

        private List<string> SimplifiedDebts(List<PlayerGainModel> playersGains)
        {
            var simplifiedDebts = new List<string>();
            var losers = playersGains.Where(pss => pss.GainAmount < 0).OrderBy(ps => ps.GainAmount);
            var gainers = playersGains.Where(pss => pss.GainAmount >= 0).OrderByDescending(ps => ps.GainAmount);
            foreach (var loser in losers)
            {
                if (loser.GainAmount == 0)
                {
                    continue;
                }
                foreach (var gainer in gainers)
                {
                    if (gainer.GainAmount == 0)
                    {
                        continue;
                    }
                    if (Math.Abs(loser.GainAmount) == gainer.GainAmount)
                    {
                        // give gainer the amount and move to next gainer
                        loser.GainAmount = gainer.GainAmount - Math.Abs(loser.GainAmount);
                        simplifiedDebts.Add($"{loser.Player} to {gainer.Player} - ${gainer.GainAmount}");
                        gainer.GainAmount = 0;
                        break;
                    }
                    else if (Math.Abs(loser.GainAmount) > gainer.GainAmount)
                    {
                        // give gainer the amount and move to next gainer
                        loser.GainAmount = gainer.GainAmount - Math.Abs(loser.GainAmount);
                        simplifiedDebts.Add($"{loser.Player} to {gainer.Player} - ${gainer.GainAmount}");
                        gainer.GainAmount = 0;
                    }
                    else
                    {
                        // looser does not have sufficient money to pay the gainer
                        // pay it and get the next loser to pay remaining
                        gainer.GainAmount = gainer.GainAmount - Math.Abs(loser.GainAmount);
                        simplifiedDebts.Add($"{loser.Player} to {gainer.Player} - ${Math.Abs(loser.GainAmount)}");
                        loser.GainAmount = 0;
                        break;
                    }
                }

            }
            return simplifiedDebts;
        }
    }
}
