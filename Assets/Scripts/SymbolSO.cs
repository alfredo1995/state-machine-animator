using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Symbol", menuName = "SO / Symbol", order = 0)]

public class SymbolSO : ScriptableObject
{
    public SymbolType symbolType;
    public Sprite spriteSymbol;
    public int Frequency; 

    public enum SymbolType
    {
        A = 0,
        B = 1,
        C = 2,
        D = 3,
        E = 4,
        F = 5,             
    }
}
