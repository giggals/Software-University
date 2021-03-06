﻿using System;
using System.Collections.Generic;
using System.Text;


public class Engine
{
    private const string offset = "  ";

    public string model;
    public int power;
    public int displacement = -1;
    public string efficiency = "n/a";

  
    public string Efficiency
    {
        get { return efficiency; }
        set { efficiency = value; }
    }


    public Engine(string model, int power)
    {
        this.model = model;
        this.power = power;
    }

    public int Displacement
    {
        get { return this.displacement; }
        set { this.displacement = value; }
    }

    public Engine(string model, int power, int displacement) : this(model , power)
    {
        this.Displacement = displacement;
    }

    public Engine(string model, int power, string efficiency) : this(model , power)
    {
        this.Efficiency = efficiency;
    }

    public Engine(string model, int power, int displacement, string efficiency) : this(model, power ,  efficiency)
    {
        this.Displacement = displacement;
    }
    
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("{0}{1}:\n", offset, this.model);
        sb.AppendFormat("{0}{0}Power: {1}\n", offset, this.power);
        sb.AppendFormat("{0}{0}Displacement: {1}\n", offset, this.displacement == -1 ? "n/a" : this.displacement.ToString());
        sb.AppendFormat("{0}{0}Efficiency: {1}\n", offset, this.efficiency);

        return sb.ToString();
    }
}


