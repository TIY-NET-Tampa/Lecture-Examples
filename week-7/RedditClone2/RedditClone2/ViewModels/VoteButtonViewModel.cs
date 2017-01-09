using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RedditClone2.Models;

namespace RedditClone2.ViewModels
{
    public class VoteButtonViewModel
    {
        public string IsDisabled { get; set; }
        public string UpVoteButtonClass { get; set; }
        public string DownVoteButtonClass { get; set; }

        public VoteButtonViewModel(Vote vote, string userId, bool isAuthenticated)
        {
            this.IsDisabled = "disabled='disabled'";

            if (!isAuthenticated)
            {
                if (vote == null)
                {
                    this.IsDisabled = "";
                }
                else
                {
                    if (vote.Weight > 0)
                    {
                        this.UpVoteButtonClass = "pushed";
                    }
                    else if (vote.Weight < 0)
                    {
                        this.DownVoteButtonClass = "pushed";
                    }
                }
            }
          
        }
    }
}