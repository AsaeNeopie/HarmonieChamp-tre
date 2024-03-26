using UnityEngine;

public class GoBuy : MonoBehaviour
{
    [SerializeField] GameObject _buyPanel;
    [SerializeField] PlayerInventory _inventory;
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
}
