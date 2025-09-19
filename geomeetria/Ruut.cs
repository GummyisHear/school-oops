﻿using oops.geomeetria;

public class Ruut : IKujund
{
    public double Külg { get; set; }

    public Ruut(double külg)
    {
        Külg = külg;
    }

    public double ArvutaPindala() => Külg * Külg;
    public double ArvutaÜmbermõõt() => 4 * Külg;
}