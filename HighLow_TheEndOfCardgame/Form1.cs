using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighLow_TheEndOfCardgame
{
    public partial class Form1 : Form
    {

        deck p1_deck = new deck(0);
        deck p2_deck = new deck(0);
        deck main_deck = new deck(52);
        bool checkend = false;
        public Form1()
        {
            InitializeComponent();


            main_deck.shuffle();

            for (int i = 0; i < 26; i++)
            {
                
                p1_deck.pushcard(main_deck.drawcard());
                p2_deck.pushcard(main_deck.drawcard());
            }

            P1_num.Text = p1_deck.getnumcard()+" card";
            P2_num.Text = p2_deck.getnumcard() + " card";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!checkend)
            {
            card p1_drawcard,p2_drawcard;

            p1_drawcard = p1_deck.drawcard();
            p2_drawcard = p2_deck.drawcard();

            P1_txt.Text = p1_drawcard.getname();
            P2_txt.Text = p2_drawcard.getname();

            if (p1_drawcard.getval() != p2_drawcard.getval())
            {
                p1_drawagain.Text = "";
                p2_drawagain.Text = "";

                if (p1_drawcard.getval() > p2_drawcard.getval())
                {
                    p1_deck.pushcard(p1_drawcard);
                    p1_deck.pushcard(p2_drawcard);
                    maintxt.Text = "P1 Win this Match";

                }
                else
                {
                    p2_deck.pushcard(p1_drawcard);
                    p2_deck.pushcard(p2_drawcard);
                    maintxt.Text = "P2 Win this Match";

                }
            }
            else
            {
                int sameval = p1_drawcard.getval();
                if(sameval == 14)
                { sameval = 1; }

                p1_drawagain.Text = "P1 Draw Again";
                p2_drawagain.Text = "P2 Draw Again";

                Stack<card> p1_card_again = new Stack<card>(0);
                Stack<card> p2_card_again = new Stack<card>(0);

                if(p1_deck.getnumcard()<sameval)
                {
                    for (int i = 0; i < p1_deck.getnumcard(); i++)
                    {
                        p1_card_again.Push(p1_deck.drawcard());
                        p1_drawagain.Text += " "+p1_card_again.ElementAt(0).getname();
                    }
                }
                else
                {
                    for (int i = 0; i < sameval; i++)
                    {
                        p1_card_again.Push(p1_deck.drawcard());
                        p1_drawagain.Text += " " + p1_card_again.ElementAt(0).getname();
                    }
                }

                if (p2_deck.getnumcard() < sameval)
                {
                    for (int i = 0; i < p2_deck.getnumcard(); i++)
                    {
                        p2_card_again.Push(p2_deck.drawcard());
                        p2_drawagain.Text += " " + p2_card_again.ElementAt(0).getname();
                    }
                }
                else
                {
                    for (int i = 0; i < sameval; i++)
                    {
                        p2_card_again.Push(p2_deck.drawcard());
                        p2_drawagain.Text += " " + p2_card_again.ElementAt(0).getname();
                    }
                }


                if (p1_card_again.ElementAt(p1_card_again.Count-1).getval() > p2_card_again.ElementAt(p2_card_again.Count - 1).getval())
                {
                    int p1_again_size = p1_card_again.Count;
                    int p2_again_size = p2_card_again.Count;

                    for (int i = 0; i < p1_again_size; i++)
                    {
                        p1_deck.pushcard(p1_card_again.Pop());
                    }

                    for (int i = 0; i < p2_again_size; i++)
                    {
                        p1_deck.pushcard(p2_card_again.Pop());
                    }

                    p1_deck.pushcard(p1_drawcard);
                    p1_deck.pushcard(p2_drawcard);
                    maintxt.Text = "P1 Win this Match";

                }
                else if (p1_card_again.ElementAt(p1_card_again.Count - 1).getval() < p2_card_again.ElementAt(p2_card_again.Count - 1).getval())
                {
                    int p1_again_size = p1_card_again.Count;
                    int p2_again_size = p2_card_again.Count;

                    for (int i = 0; i < p1_again_size; i++)
                    {
                        p2_deck.pushcard(p1_card_again.Pop());
                    }

                    for (int i = 0; i < p2_again_size; i++)
                    {
                        p2_deck.pushcard(p2_card_again.Pop());
                    }


                    p2_deck.pushcard(p1_drawcard);
                    p2_deck.pushcard(p2_drawcard);
                    maintxt.Text = "P2 Win this Match";

                }
                else
                {

                    int p1_again_size = p1_card_again.Count;
                    int p2_again_size = p2_card_again.Count;

                    for (int i = 0; i < p1_again_size; i++)
                    {
                        p1_deck.pushcard(p1_card_again.Pop());
                    }

                    for (int i = 0; i < p2_again_size; i++)
                    {
                        p2_deck.pushcard(p2_card_again.Pop());
                    }


                    p1_deck.pushcard(p1_drawcard);
                    p2_deck.pushcard(p2_drawcard);
                }

            }


            P1_num.Text = p1_deck.getnumcard() + " card";
            P2_num.Text = p2_deck.getnumcard() + " card";

                if(p1_deck.getnumcard() == 0||p2_deck.getnumcard()==0)
                { checkend = true; }
            }
        }
    }
}
