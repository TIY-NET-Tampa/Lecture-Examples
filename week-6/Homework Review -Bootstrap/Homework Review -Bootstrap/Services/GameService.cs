using Homework_Review__Bootstrap.DataContext;
using Homework_Review__Bootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_Review__Bootstrap.Services
{
    public class GameService
    {
        public IEnumerable<Game> GetAllGames()
        {
            return new SportsContext().Games;
        }
    }
}