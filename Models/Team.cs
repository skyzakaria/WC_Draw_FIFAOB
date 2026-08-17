using System;
using System.Collections.Generic;
using System.Text;

namespace WC_Draw_FIFAOB.Models
{
    internal class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Confederation Confederation { get; set; }
        public int PotNumber { get; set; }
    }
}
