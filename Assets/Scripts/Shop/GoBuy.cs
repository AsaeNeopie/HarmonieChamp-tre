using UnityEngine;

public class GoBuy : MonoBehaviour
{
    [SerializeField] GameObject _buyPanel;
    [SerializeField] PlayerInventory _inventory;
    [SerializeField] GameObject _tomatofield;
    [SerializeField] GameObject _tomatoBuyButton;
    [SerializeField] GameObject _tomatoSellButton;
    [SerializeField] GameObject _fieldButton;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _buyPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            _buyPanel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void BuyCarrotSeed()
    {
        if (_inventory.gold >= 3)
        {
            _inventory.gold -= 3;
            _inventory.carrotSeed ++;
        }
    }

    public void BuyTomatotSeed()
    {
        if (_inventory.gold >= 5)
        {
            _inventory.gold -= 5;
            _inventory.tomatoSeed++;
        }
    }
    public void buyField()
    {
        if (_inventory.gold >= 15)
        {
            _inventory.gold -= 15;
            _tomatoBuyButton.SetActive(true);
            _tomatofield.SetActive(true);
            _fieldButton.SetActive(false);
        }
    }
}
