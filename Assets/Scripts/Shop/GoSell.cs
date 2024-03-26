using UnityEngine;

public class GoSell : MonoBehaviour
{
    [SerializeField] GameObject _sellPanel;
    [SerializeField] PlayerInventory _inventory;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _sellPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _sellPanel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void SellCarrot()
    {
        if (_inventory.carrot >= 1)
        {
            _inventory.carrot -- ;
            _inventory.gold += 5;
        }
    }
}
