using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MersTrenuri.Models
{
    public class RutaInfo
    {
        public string StatiePlecare { get; set; }
        public string StatieSosire { get; set; }
        public DateTime DataBilet { get; set; }

        public int Distanta { get; set; }

        public double Pret { get; set; }


        private ClasaOrase clasaOrase = new ClasaOrase();

        public RutaInfo ()
        {
            
        }

        public RutaInfo(string statiePlecare, string statieSosire)
        {
            StatiePlecare = statiePlecare;
            StatieSosire = statieSosire;
        }

        public void CalculareInfoRuta()
        {
            if ((StatiePlecare == clasaOrase.Orase[0] || StatieSosire == clasaOrase.Orase[0]))
            {
                if ((StatiePlecare == clasaOrase.Orase[0] && StatieSosire == clasaOrase.Orase[0]))
                {
                    Distanta = 0;
                }
                else if ((StatiePlecare == clasaOrase.Orase[0] && StatieSosire == clasaOrase.Orase[1]) || (StatiePlecare == clasaOrase.Orase[1] && StatieSosire == clasaOrase.Orase[0]))
                {
                    Distanta = 170;
                }
                else if ((StatiePlecare == clasaOrase.Orase[0] && StatieSosire == clasaOrase.Orase[2]) || (StatiePlecare == clasaOrase.Orase[2] && StatieSosire == clasaOrase.Orase[0]))
                {
                    Distanta = 320;
                }
                else if ((StatiePlecare == clasaOrase.Orase[0] && StatieSosire == clasaOrase.Orase[3]) || (StatiePlecare == clasaOrase.Orase[3] && StatieSosire == clasaOrase.Orase[0]))
                {
                    Distanta = 360;
                }
                else if ((StatiePlecare == clasaOrase.Orase[0] && StatieSosire == clasaOrase.Orase[4]) || (StatiePlecare == clasaOrase.Orase[4] && StatieSosire == clasaOrase.Orase[0]))
                {
                    Distanta = 120;
                }
                else if ((StatiePlecare == clasaOrase.Orase[0] && StatieSosire == clasaOrase.Orase[5]) || (StatiePlecare == clasaOrase.Orase[5] && StatieSosire == clasaOrase.Orase[0]))
                {
                    Distanta = 260;
                }
                else if ((StatiePlecare == clasaOrase.Orase[0] && StatieSosire == clasaOrase.Orase[6]) || (StatiePlecare == clasaOrase.Orase[6] && StatieSosire == clasaOrase.Orase[0]))
                {
                    Distanta = 60;
                }
                else if ((StatiePlecare == clasaOrase.Orase[0] && StatieSosire == clasaOrase.Orase[7]) || (StatiePlecare == clasaOrase.Orase[7] && StatieSosire == clasaOrase.Orase[0]))
                {
                    Distanta = 170;
                }

            }
            else if ((StatiePlecare == clasaOrase.Orase[1] || StatieSosire == clasaOrase.Orase[1]))
            {
                if ((StatiePlecare == clasaOrase.Orase[1] && StatieSosire == clasaOrase.Orase[1]))
                {
                    Distanta = 0;
                }
                else if ((StatiePlecare == clasaOrase.Orase[1] && StatieSosire == clasaOrase.Orase[2]) || (StatiePlecare == clasaOrase.Orase[2] && StatieSosire == clasaOrase.Orase[1]))
                {
                    Distanta = 190;
                }
                else if ((StatiePlecare == clasaOrase.Orase[1] && StatieSosire == clasaOrase.Orase[3]) || (StatiePlecare == clasaOrase.Orase[3] && StatieSosire == clasaOrase.Orase[1]))
                {
                    Distanta = 210;
                }
                else if ((StatiePlecare == clasaOrase.Orase[1] && StatieSosire == clasaOrase.Orase[4]) || (StatiePlecare == clasaOrase.Orase[4] && StatieSosire == clasaOrase.Orase[1]))
                {
                    Distanta = 290;
                }
                else if ((StatiePlecare == clasaOrase.Orase[1] && StatieSosire == clasaOrase.Orase[5]) || (StatiePlecare == clasaOrase.Orase[5] && StatieSosire == clasaOrase.Orase[1]))
                {
                    Distanta = 120;
                }
                else if ((StatiePlecare == clasaOrase.Orase[1] && StatieSosire == clasaOrase.Orase[6]) || (StatiePlecare == clasaOrase.Orase[6] && StatieSosire == clasaOrase.Orase[1]))
                {
                    Distanta = 260;
                }
                else if ((StatiePlecare == clasaOrase.Orase[1] && StatieSosire == clasaOrase.Orase[7]) || (StatiePlecare == clasaOrase.Orase[7] && StatieSosire == clasaOrase.Orase[1]))
                {
                    Distanta = 60;
                }
            }
            else if ((StatiePlecare == clasaOrase.Orase[2] || StatieSosire == clasaOrase.Orase[2]))
            {
                if ((StatiePlecare == clasaOrase.Orase[2] && StatieSosire == clasaOrase.Orase[2]))
                {
                    Distanta = 0;
                }
                else if ((StatiePlecare == clasaOrase.Orase[2] && StatieSosire == clasaOrase.Orase[3]) || (StatiePlecare == clasaOrase.Orase[3] && StatieSosire == clasaOrase.Orase[2]))
                {
                    Distanta = 190;
                }
                else if ((StatiePlecare == clasaOrase.Orase[2] && StatieSosire == clasaOrase.Orase[4]) || (StatiePlecare == clasaOrase.Orase[4] && StatieSosire == clasaOrase.Orase[2]))
                {
                    Distanta = 210;
                }
                else if ((StatiePlecare == clasaOrase.Orase[2] && StatieSosire == clasaOrase.Orase[5]) || (StatiePlecare == clasaOrase.Orase[5] && StatieSosire == clasaOrase.Orase[2]))
                {
                    Distanta = 120;
                }
                else if ((StatiePlecare == clasaOrase.Orase[2] && StatieSosire == clasaOrase.Orase[6]) || (StatiePlecare == clasaOrase.Orase[6] && StatieSosire == clasaOrase.Orase[2]))
                {
                    Distanta = 260;
                }
                else if ((StatiePlecare == clasaOrase.Orase[2] && StatieSosire == clasaOrase.Orase[7]) || (StatiePlecare == clasaOrase.Orase[7] && StatieSosire == clasaOrase.Orase[2]))
                {
                    Distanta = 60;
                }
            }

            else if ((StatiePlecare == clasaOrase.Orase[3] || StatieSosire == clasaOrase.Orase[3]))
            {
                if ((StatiePlecare == clasaOrase.Orase[3] && StatieSosire == clasaOrase.Orase[3]))
                {
                    Distanta = 0;
                }
                else if ((StatiePlecare == clasaOrase.Orase[3] && StatieSosire == clasaOrase.Orase[4]) || (StatiePlecare == clasaOrase.Orase[4] && StatieSosire == clasaOrase.Orase[3]))
                {
                    Distanta = 210;
                }
                else if ((StatiePlecare == clasaOrase.Orase[3] && StatieSosire == clasaOrase.Orase[5]) || (StatiePlecare == clasaOrase.Orase[5] && StatieSosire == clasaOrase.Orase[3]))
                {
                    Distanta = 120;
                }
                else if ((StatiePlecare == clasaOrase.Orase[3] && StatieSosire == clasaOrase.Orase[6]) || (StatiePlecare == clasaOrase.Orase[6] && StatieSosire == clasaOrase.Orase[3]))
                {
                    Distanta = 260;
                }
                else if ((StatiePlecare == clasaOrase.Orase[3] && StatieSosire == clasaOrase.Orase[7]) || (StatiePlecare == clasaOrase.Orase[7] && StatieSosire == clasaOrase.Orase[3]))
                {
                    Distanta = 60;
                }
            }

            else if ((StatiePlecare == clasaOrase.Orase[4] || StatieSosire == clasaOrase.Orase[4]))
            {
                if ((StatiePlecare == clasaOrase.Orase[4] && StatieSosire == clasaOrase.Orase[4]))
                {
                    Distanta = 0;
                }
                else if ((StatiePlecare == clasaOrase.Orase[4] && StatieSosire == clasaOrase.Orase[5]) || (StatiePlecare == clasaOrase.Orase[5] && StatieSosire == clasaOrase.Orase[4]))
                {
                    Distanta = 120;
                }
                else if ((StatiePlecare == clasaOrase.Orase[4] && StatieSosire == clasaOrase.Orase[6]) || (StatiePlecare == clasaOrase.Orase[6] && StatieSosire == clasaOrase.Orase[4]))
                {
                    Distanta = 260;
                }
                else if ((StatiePlecare == clasaOrase.Orase[4] && StatieSosire == clasaOrase.Orase[7]) || (StatiePlecare == clasaOrase.Orase[7] && StatieSosire == clasaOrase.Orase[4]))
                {
                    Distanta = 60;
                }
            }

            else if ((StatiePlecare == clasaOrase.Orase[5] || StatieSosire == clasaOrase.Orase[5]))
            {
                if ((StatiePlecare == clasaOrase.Orase[5] && StatieSosire == clasaOrase.Orase[5]))
                {
                    Distanta = 0;
                }
                else if ((StatiePlecare == clasaOrase.Orase[5] && StatieSosire == clasaOrase.Orase[6]) || (StatiePlecare == clasaOrase.Orase[6] && StatieSosire == clasaOrase.Orase[5]))
                {
                    Distanta = 260;
                }
                else if ((StatiePlecare == clasaOrase.Orase[5] && StatieSosire == clasaOrase.Orase[7]) || (StatiePlecare == clasaOrase.Orase[7] && StatieSosire == clasaOrase.Orase[5]))
                {
                    Distanta = 60;
                }
            }

            else if ((StatiePlecare == clasaOrase.Orase[6] || StatieSosire == clasaOrase.Orase[6]))
            {
                if ((StatiePlecare == clasaOrase.Orase[6] && StatieSosire == clasaOrase.Orase[6]))
                {
                    Distanta = 0;
                }
                else if ((StatiePlecare == clasaOrase.Orase[6] && StatieSosire == clasaOrase.Orase[7]) || (StatiePlecare == clasaOrase.Orase[7] && StatieSosire == clasaOrase.Orase[6]))
                {
                    Distanta = 60;
                }
            }

            else if ((StatiePlecare == clasaOrase.Orase[7] || StatieSosire == clasaOrase.Orase[7]))
            {
                if ((StatiePlecare == clasaOrase.Orase[7] && StatieSosire == clasaOrase.Orase[7]))
                {
                    Distanta = 0;
                }
            }

            Pret = Distanta * 0.4;
        }
    }
}
