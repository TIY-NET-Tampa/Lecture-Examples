using Homework_Review__Bootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_Review__Bootstrap.ViewModels
{
    public class IndexViewModel
    {
        public int PageNumber { get; set; }
        public IEnumerable<Game> Games { get; set; }
    }
}