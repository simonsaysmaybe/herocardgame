using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New card", menuName = "Card/Power")]
public class Power : ScriptableObject
{
    public string cardName;
    public string description;

    public int cost;

    public Sprite artWork;

    public PowerType type;
}
