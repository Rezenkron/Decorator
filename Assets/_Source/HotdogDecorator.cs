using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HotdogDecorator : Hotdog
{
    protected Hotdog hotdog;
    public HotdogDecorator(string name, Hotdog hotdog) : base(name)
    {
        this.hotdog = hotdog;
    }
}
