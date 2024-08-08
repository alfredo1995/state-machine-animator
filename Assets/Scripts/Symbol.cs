using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Symbol : MonoBehaviour
{
    private SymbolSO model;

    [SerializeField] private UnityEngine.UI.Image imageSymbol;
    [SerializeField] private SymbolSO[] symbols;

    public void SetSymbolModel(SymbolSO symbolModel)
    {
        model = symbolModel;
        SetSymbol();
    }

    public void SetSymbol()
    {
        imageSymbol.sprite = model.spriteSymbol;
    }
}
