using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] float _maxRaycastHit;
    [SerializeField] Plant _plantScript;
    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.canceled) return;
        Interaction();
    }

    private void Interaction()
    {
        Debug.Log("Appuyer");
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitData;
        Physics.Raycast(ray, out hitData, _maxRaycastHit);
        Debug.Log (hitData.collider);
        Debug.DrawRay(ray.origin, hitData.point - transform.position, Color.red, 10f);
        if (hitData.collider)
        {
            Plant plant = hitData.collider.GetComponent<Plant>();
            if (plant == null || !plant._canHarvest) return;
            Destroy(hitData.collider.gameObject);
        }
    }
}

