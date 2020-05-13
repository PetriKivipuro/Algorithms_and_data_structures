using System;

namespace part1
{
    public class Substrings
    {
        public int Calculate(string a, string b)
        {
            int sum = 0;
            int al = a.Length;
            int bl = b.Length;

            for (int i = 0; i <= (al - bl); i++)
            {
                if (a[i] == b[0])
                {
                    for (int j = 0; j < bl; j++)
                    {
                        if (a[i + j] == b[j])
                        {
                            if (j == bl - 1)
                            {
                                sum++;
                                break;
                            }
                        }
                    }
                }
            }
            return sum;

        }
    }
}




namespace part1
{
    using System.Text.RegularExpressions;
    public class Substrings2
    {
        public int Calculate(string a, string b)
        {
            // @"(?=SUBSTRING)
            return Regex.Matches(a, @"(?=" + b + ")").Count;

        }
    }
}

/*
Tässä oma pohdinta ennen mallivastauksia


string a muutetaan listaksi
samoin string b

string b:tä verrataan string a:han
    b listan ensimmäinen arvo käydään läpi verraten a listaan

    jos b ensimmäistä arvoa ei löydy == 0

    jos b listan ensimmäinen löytyy
    otetaan b listan toinen ja verrataan löytyykö b1 + be

    jos listän ensimmäinen ja toinen löytyy otetan b listan kolmas arvo
    jnejne

    kun kaikki on käyty läpi verrataan montako b listaa löytyy kokonaisuudessaan a listasta

    ja annetaan tulos
*/
