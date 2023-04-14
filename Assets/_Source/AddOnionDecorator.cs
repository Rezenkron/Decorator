using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddOnionDecorator : HotdogDecorator
{
    private int OnionCost = 30;

    public AddOnionDecorator(string name, Hotdog hotdog) : base(name, hotdog)
    {
    }

    public override int GetCost()
    {
        return hotdog.GetCost() + OnionCost;
    }

    public override string GetName()
    {
        return hotdog.GetName() + "with Onion";
    }
}
