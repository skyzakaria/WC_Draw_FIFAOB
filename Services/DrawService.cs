using System;
using System.Collections.Generic;
using System.Text;
using WC_Draw_FIFAOB.Models;

namespace WC_Draw_FIFAOB.Services
{
    public class DrawService
    {
        // Function to verify if we can add a nation to the group
        public bool CanAddTeamToGroup(Team team, Group group)
        {
            // Max number of teams allowed in a group is 4
            if (group.Teams.Count >= 4)
            {
                return false;
            }

            // No more than 2 UEFA teams are allowed per group
            // for the other confederations, no more than 1 team per group
            int countConf = group.Teams.Count(t => t.Confederation == team.Confederation);
            
            if (team.Confederation == Confederation.UEFA && countConf >= 2)
            {
                return false;
            } 

            if (team.Confederation != Confederation.UEFA && countConf >=1)
            {
                return false;
            }

            return true;           
        }

        // Function 
    }
}
