using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PowerDisplay : MonoBehaviour
{
    public PowerCard card;

    #region References
    public TextMeshPro cardName, cardDescription, cardEnergyCost;

    public Image artwork;

    private void DisplayRefs()
    {
        cardName.text = card.cardName;
        cardDescription.text = card.cardDescription;
        cardEnergyCost.text = card.cardEnergyCost.ToString();
        artwork.sprite = card.artwork;
    }

    #endregion

    private void Awake()
    {
        DisplayRefs();
    }
}
