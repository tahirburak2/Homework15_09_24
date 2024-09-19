using System;

namespace Oop_Homeworks.Soru6;

public class ScientificClaculator : Calculator
{
    public override int Add(int input1, int input2)
    {
        int toplam = 0;
        toplam = input1 + input2;
        return toplam;
    }
    public override int Substract(int input1, int input2)
    {
        int çıkar = 0;
        if (input1 < input2)
        {
            çıkar = input2 - input1;
        }
        else if (input1 > input2)
        {
            çıkar = input2 - input1;
        }
        return çıkar;
    }
    public override int Multiply(int input1, int input2)
    {
        int çarp = 0;
        çarp = input1 * input2;
        return çarp;
    }
    public override int Divide(int input1, int input2)
    {
        int bölüm = 0;
        bölüm = input1 / input2;
        return bölüm;
    }
}
