using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

//Display card information on the UI.

/*Do NOT use this script to add logic to cards. Use a Card Manager instead.*/

public class HeroDisplay : MonoBehaviour
{
    public HeroCard card;

    #region References
    public TextMeshPro cardName, cardDescription, cardAttack, cardHealth,
        cardStarRank, cardEnergyCost;

    public Image artwork;

    private void DisplayRefs()
    {
        cardName.text = card.cardName;
        cardDescription.text = card.cardDescription;
        cardAttack.text = card.heroAttack.ToString();
        cardHealth.text = card.heroHealth.ToString();
        cardStarRank.text = card.heroStarRank.ToString();
        cardEnergyCost.text = card.cardEnergyCost.ToString();
        artwork.sprite = card.artwork;
    }

    #endregion

    private void Awake()
    {
        DisplayRefs();
    }
}
