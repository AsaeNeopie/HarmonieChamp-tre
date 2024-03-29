using TMPro;
using UnityEngine;

public class InventoryText : MonoBehaviour
{
    [SerializeField] TMP_Text _goldText;
    [SerializeField] TMP_Text _carrotSeedText;
    [SerializeField] TMP_Text _carrotText;
    [SerializeField] TMP_Text _tomatoSeedText;
    [SerializeField] TMP_Text _tomatoText;
    [SerializeField] PlayerInventory _inventory;

    void Update()
    {
        _goldText.text = _inventory.gold.ToString();
        _carrotSeedText.text = _inventory.carrotSeed.ToString();
        _carrotText.text = _inventory.carrot.ToString();
        _tomatoSeedText.text = _inventory.tomatoSeed.ToString();
        _tomatoText.text = _inventory.tomato.ToString();
    }
}
