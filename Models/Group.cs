using System;
using System.Collections.Generic;
using System.Text;
using WC_Draw_FIFAOB.Models;

namespace WC_Draw_FIFAOB.Models
{
    public class Group
    {
        public char name { get; set; } // A, B ... H

        public List<Team> Teams { get; set; } = new();

        public Group(char name)
        {
            this.name = name;
        }
    }
}
