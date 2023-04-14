using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatHotdog : Hotdog
{
    public MeatHotdog(string name) : base(name)
    {
    }

    public override int GetCost()
    {
        return 330;
    }

    public override string GetName()
    {
        return "Meat Hotdog";
    }
}
