using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diginaplo1119_Vinklarik;

class Naplo
{
    string nev;
    int ot;
    int negy;
    int harom;
    int ketto;
    int egy;
    double atlag;

    public string Nev { get => nev; set => nev = value; }
    public int Ot { get => ot; set => ot = value; }
    public int Negy { get => negy; set => negy = value; }
    public int Harom { get => harom; set => harom = value; }
    public int Ketto { get => ketto; set => ketto = value; }
    public int Egy { get => egy; set => egy = value; }
    public double Atlag { get => atlag; set => atlag = value; } 

    public Naplo(string sor)
    {
        string[] darabok = sor.Split(";");
        nev = darabok[0];
        ot = Convert.ToInt32(darabok[1]);
        negy = Convert.ToInt32(darabok[2]);
        harom = Convert.ToInt32(darabok[3]);
        ketto = Convert.ToInt32(darabok[4]);
        egy = Convert.ToInt32(darabok[5]);
        double darabszam = ot + negy + harom + ketto + egy;
        atlag = ot * 5 + negy * 4 + harom * 3 + ketto * 2 + egy;
        atlag = atlag / darabszam;
        atlag = Math.Round(atlag, 2);
    }

    public int pontszamitas()
    {
        return ot * 3 + negy * 2 + ketto * -1 + egy * -2;
    }
}
