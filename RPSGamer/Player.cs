using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGamer
{
    public class Player
    {
        private string name;
        private HandSign handSign;


        public Player(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public HandSign HandSign
        {
            get { return handSign; }
            set { handSign = value; }
        }

    }
}
