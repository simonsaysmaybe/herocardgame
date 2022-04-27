using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

/*
 * Manage display and logic of hero cards.
 */

public class HeroManager : MonoBehaviour
{
    public Hero hero;
    public TMP_Text cardName, description, star, energy, attack, health;
    public Image artwork;
    private void Start()
    {
        ReferenceAll();
    }

    private void ReferenceAll()
    {
        //TMP
        cardName.text = hero.cardName;
        description.text = hero.description;
        star.text = hero.star.ToString();
        energy.text = hero.energyCost.ToString();
        attack.text = hero.attack.ToString();
        health.text = hero.health.ToString();
        ////

        artwork.sprite = hero.artWork;
    }
}
