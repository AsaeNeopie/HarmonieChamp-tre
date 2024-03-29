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
        _goldText.text = _inventory.Gold.ToString();
        _carrotSeedText.text = _inventory.CarrotSeed.ToString();
        _carrotText.text = _inventory.Carrot.ToString();
        _tomatoSeedText.text = _inventory.TomatoSeed.ToString();
        _tomatoText.text = _inventory.Tomato.ToString();
    }
}
