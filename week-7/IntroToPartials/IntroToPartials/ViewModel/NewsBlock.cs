using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroToPartials.ViewModel
{
    public class NewsBlock
    {
        public string Header { get; set; }
        public IEnumerable<string> Ptags { get; set; }
    }
}