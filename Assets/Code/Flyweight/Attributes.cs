using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Monster", menuName = "ScriptableObject/Create New Monster", order = 1)]

public class Attributes : ScriptableObject
{
    //-----------------------------------------------------------------Este es el Flyweight----------------------------------------------------------------

    public Sprite sprite;
    public new string name;
    public string description;
}
