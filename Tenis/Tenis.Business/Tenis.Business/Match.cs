using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenis.Business
{
    public class Match
    {
        public Match()
        {
            this.initializeProperties();
        }
        //Properties

        public int pointsPlayer1 { get; set; }

        public int pointsPlayer2 { get; set; }

        public int deucePlayer1 { get; set; }

        public int deucePlayer2 { get; set; }

        public int[,] scoreboard { get; set; }

        //Methods

        public void addPoint(int player)
        {
            if(this.checkDeuce())
            {
                if (player == 1)
                    if (this.deucePlayer1 == 0)
                        if (this.deucePlayer2 == 0)
                            this.deucePlayer1++;
                        else
                            this.deucePlayer2 = 0;
                    else
                        this.addGame(1);
                else
                    if (this.deucePlayer2 == 0)
                    if (this.deucePlayer1 == 0)
                        this.deucePlayer2++;
                    else
                        this.deucePlayer1 = 0;
                else
                    this.addGame(2);

                            
            }
            if (player == 1)
            {
                switch (this.pointsPlayer1)
                {
                    case 0:
                        this.pointsPlayer1 = 15;
                        break;
                    case 15:
                        this.pointsPlayer1 = 30;
                        break;
                    case 30:
                        this.pointsPlayer1 = 40;
                        break;
                    case 40:
                        this.addGame(1);
                        break;
                }
            }
            else
            {
                switch (this.pointsPlayer2)
                {
                    case 0:
                        this.pointsPlayer2 = 15;
                        break;
                    case 15:
                        this.pointsPlayer2 = 30;
                        break;
                    case 30:
                        this.pointsPlayer2 = 40;
                        break;
                    case 40:
                        this.addGame(2);
                        break;
                }
            } 
        }

        public void initializeProperties()
        {
            this.pointsPlayer1 = 0;
            this.pointsPlayer2 = 0;
            this.deucePlayer1 = 0;
            this.deucePlayer2 = 0;

            this.scoreboard = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this.scoreboard[i, j] = 0;
                }
            }
        }

        private void addGame(int player)
        {
            bool deuce = this.checkDeuce();
            if (player == 1)
            {
                this.scoreboard[0, 0]++;
            }
            else
            {
                this.scoreboard[1, 0]++;
            }
            this.pointsPlayer1 = 0; 
            this.pointsPlayer2 = 0;
        }

        private bool checkDeuce()
        {
            if (this.pointsPlayer1 == 40 && this.pointsPlayer2 == 40)
            {
                return true;
            }
            return false;
        }
    }
}
