using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    [HideInInspector] public int gold;
    [HideInInspector] public int carrotSeed;
    [HideInInspector] public int carrot;
    [HideInInspector] public int tomatoSeed;
    [HideInInspector] public int tomato;
    public TMP_Text goldText;
    public TMP_Text carrotSeedText;
    public TMP_Text carrotText;
    public TMP_Text tomatoSeedText;
    public TMP_Text tomatoText;

    private void Update()
    {
        goldText.text = gold.ToString();
        carrotSeedText.text = carrotSeed.ToString();
        carrotText.text = carrot.ToString();
        tomatoSeedText.text = tomatoSeed.ToString();
        tomatoText.text = tomato.ToString();
    }
}
