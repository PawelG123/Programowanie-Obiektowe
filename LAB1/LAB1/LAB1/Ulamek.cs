using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Ulamek
    {
        private int licznik;
        private int mianownik;

        public Ulamek(int licznik, int mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
        }

        public Ulamek(Ulamek previousUlamek)
        {
            licznik = previousUlamek.licznik;
            mianownik = previousUlamek.mianownik;
        }
        public Ulamek(string licznik, int mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;

        }
        public int licznik { get; set; }
        public string Name { get; set; }
        public string Details()
        {
            //return licznik +"is" + mianownik.ToString();
            return $"{licznik} / {mianownik}";
        }

        public static Ulamek operator +(Ulamek a) => a;
        public static Ulamek operator -(Ulamek a) => new Ulamek(-a.num, a.den);
        public static Ulamek operator +(Ulamek a, Ulamek b)
             => new Ulamek(a.num * b.den + b.num * a.den, a.den * b.den);
        public static Ulamek operator -(Ulamek a, Ulamek b) => a + (-b);
        public static Ulamek operator *(Ulamek a, Ulamek b)
               => new Ulamek(a.num * b.num, a.den * b.den);
        public static Ulamek operator /(Ulamek a, Ulamek b)
        {
            if (b.num == 0)
        }
        {
        return new DivideByZeroException();
    }
    return new Ulamek(a.num* b.den, a.den* b.num);
}

public override string ToString() => $"{num} / {den}";
}
