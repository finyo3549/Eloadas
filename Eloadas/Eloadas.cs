using System;

public class Eloadas
{
    private bool[,] foglalasok;

    public Eloadas(int sorokSzama, int helyekSzama)
    {
        if (sorokSzama <= 0 || helyekSzama <= 0)
        {
            throw new ArgumentException("A sorokSzama és a helyekSzama értékeinek nagyobbnak kell lenniük, mint 0.");
        }

        foglalasok = new bool[sorokSzama, helyekSzama];
    }

    public bool Lefoglal()
    {
        for (int i = 0; i < foglalasok.GetLength(0); i++)
        {
            for (int j = 0; j < foglalasok.GetLength(1); j++)
            {
                if (!foglalasok[i, j])
                {
                    foglalasok[i, j] = true;
                    return true; 
                }
            }
        }
        return false; 
    }

    public int SzabadHelyek
    {
        get
        {
            int szabad = 0;
            foreach (bool hely in foglalasok)
            {
                if (!hely)
                {
                    szabad++;
                }
            }
            return szabad;
        }
    }

    public bool Teli
    {
        get
        {
            foreach (bool hely in foglalasok)
            {
                if (!hely)
                {
                    return false;
                }
            }
            return true; 
        }
    }

    public bool Foglalt(int sorSzam, int helySzam)
    {
        if (sorSzam <= 0 || sorSzam > foglalasok.GetLength(0) || helySzam <= 0 || helySzam > foglalasok.GetLength(1))
        {
            throw new ArgumentException("Érvénytelen sorSzam vagy helySzam.");
        }

        return foglalasok[sorSzam - 1, helySzam - 1]; 
    }
}
