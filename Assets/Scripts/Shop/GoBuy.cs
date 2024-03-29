using UnityEngine;

public class GoBuy : MonoBehaviour
{
    /// <summary>
    /// Permet d'acheter des graines et le champs de tomate 
    /// </summary>
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
        if (_inventory.Gold >= 3)
        {
            _inventory.Gold -= 3;
            _inventory.CarrotSeed ++;
        }
    }

    public void BuyTomatotSeed()
    {
        if (_inventory.Gold >= 5)
        {
            _inventory.Gold -= 5;
            _inventory.TomatoSeed++;
        }
    }
    public void BuyField()
    {
        if (_inventory.Gold >= 15)
        {
            _inventory.Gold -= 15;
            _tomatoBuyButton.SetActive(true);
            _tomatofield.SetActive(true);
            _fieldButton.SetActive(false);
        }
    }
}
