using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CesarHotdog : Hotdog
{
    public CesarHotdog(string name) : base(name)
    {
    }

    public override int GetCost()
    {
        return 290;
    }

    public override string GetName()
    {
        return "Cesar Hotdog";
    }
}
