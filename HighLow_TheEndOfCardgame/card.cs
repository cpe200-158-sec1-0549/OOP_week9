using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow_TheEndOfCardgame
{
    class card
    {

        private int val;
        private string name;

        public card(int val = 14 ,string name = "Ace♠")
        {

            this.val = val;
            this.name = name;
        }

        public int getval()
        { return val; }

        public string getname()
        { return name; }

        public void switchcardval(card c)
        {
            name = c.getname();
            val = c.getval();
        }

    }
}
