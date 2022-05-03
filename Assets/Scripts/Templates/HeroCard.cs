using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Hero", menuName ="New Card/Hero", order = 1)]
public class HeroCard : CardTemplate
{
    public int heroAttack;
    public int heroHealth;
    public int heroStarRank;

    public override void OnPlay()
    {
        
    }

    public override void OnDeath()
    {
        
    }
}
