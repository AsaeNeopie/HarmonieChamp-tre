using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    [HideInInspector] public int gold;
    [HideInInspector] public int carrotSeed;
    [HideInInspector] public int carrot;
    public TMP_Text goldText;
    public TMP_Text carrotSeedText;
    public TMP_Text carrotText;

    private void Update()
    {
        goldText.text = gold.ToString();
        carrotSeedText.text = carrotSeed.ToString();
        carrotText.text = carrot.ToString();
    }
}
