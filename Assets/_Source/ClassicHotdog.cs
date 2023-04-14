using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicHotdog : Hotdog
{
    public ClassicHotdog(string name) : base(name)
    {
    }

    public override int GetCost()
    {
        return 210;
    }

    public override string GetName()
    {
        return "Classic Hotdog";
    }
}
