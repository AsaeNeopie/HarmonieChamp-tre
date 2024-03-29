using UnityEngine;

public class GoSell : MonoBehaviour
{
    /// <summary>
    /// Permet de vendre les carrotes et tomates
    /// </summary>
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
        if (_inventory.Carrot >= 1)
        {
            _inventory.Carrot -- ;
            _inventory.Gold += 6;
        }
    }
    public void SellTomato()
    {
        if (_inventory.Tomato >= 1)
        {
            _inventory.Tomato--;
            _inventory.Gold += 3;
        }
    }
}
