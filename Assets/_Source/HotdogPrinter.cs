using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotdogPrinter : MonoBehaviour
{
    private ClassicHotdog classicHotdog;
    private CesarHotdog cesarHotdog;
    private MeatHotdog meatHotdog;

    private AddPicklesDecorator addPicklesClassic;
    private AddPicklesDecorator addPicklesCesar;
    private AddPicklesDecorator addPicklesMeat;

    private AddOnionDecorator addOnionClassic;
    private AddOnionDecorator addOnionCesar;
    private AddOnionDecorator addOnionMeat;

    private void Awake()
    {
        classicHotdog = new ClassicHotdog("");
        cesarHotdog = new CesarHotdog("");
        meatHotdog = new MeatHotdog("");
        addPicklesClassic = new AddPicklesDecorator("", classicHotdog);
        addPicklesCesar = new AddPicklesDecorator("", cesarHotdog);
        addPicklesMeat = new AddPicklesDecorator("", meatHotdog);

        addOnionClassic = new AddOnionDecorator("", classicHotdog);
        addOnionCesar = new AddOnionDecorator("", cesarHotdog);
        addOnionMeat = new AddOnionDecorator("", meatHotdog);
    }
    private void Start()
    {
        Debug.Log($"{classicHotdog.GetName()} - " + classicHotdog.GetCost() + "\n" +
            "Additional info:\n" +
            $"{addPicklesClassic.GetName()} - " + $"{addPicklesClassic.GetCost()}\n" +
            $"{addOnionClassic.GetName()} - " + $"{addOnionClassic.GetCost()}\n");
    }
}
