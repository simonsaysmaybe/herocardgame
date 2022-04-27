using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Card template for Hero cards.
 */
[CreateAssetMenu(fileName = "New Card", menuName = "Card/Hero", order = 1)]
public class Hero : ScriptableObject
{

    public string cardName;
    public string description;
   
    public int attack;
    public int health;
    public int star;
    public int energyCost;

    public PowerType type;

    public Sprite artWork;

    public bool havePower;
}
