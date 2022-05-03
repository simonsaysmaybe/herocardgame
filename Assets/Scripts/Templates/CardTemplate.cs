using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CardType { HERO, POWER };

public enum PowerType
{
    PSYCHIC,
    PHYSICAL,
    TECH,
    CINETIC,
    MAGICAL,
    SPECIAL
}
[CreateAssetMenu(fileName = "New Card", menuName ="New Card/Power", order = 2)]
public class CardTemplate : ScriptableObject
{
    public CardType cardType;
    public PowerType powerType;

    public string cardName;
    public string cardDescription;

    public int cardEnergyCost;

    public Sprite artwork;

    public virtual void OnPlay()
    {
        // When card is played. Must override.
    }

    public virtual void OnDeath()
    {
        //When card is killed. Must override.
    }
}
