using UnityEngine;

public class GoBuy : MonoBehaviour
{
    [SerializeField] GameObject _buyPanel;

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
}
