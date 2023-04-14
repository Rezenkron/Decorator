using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPicklesDecorator : HotdogDecorator
{
    private int PicklesCost = 50;

    public AddPicklesDecorator(string name, Hotdog hotdog) : base(name, hotdog)
    {

    }

    public override int GetCost()
    {
        return hotdog.GetCost() + PicklesCost;
    }

    public override string GetName()
    {
        return hotdog.GetName() + "with Pickles";
    }
}
