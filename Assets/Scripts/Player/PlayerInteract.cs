using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] float _maxRaycastHit;
    [SerializeField] Plant _plantScript;
    [SerializeField] PlayerInventory _inventory;
    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.canceled) return;
        Interaction();
    }

    private void Interaction()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitData;
        if(Physics.Raycast(ray, out hitData, _maxRaycastHit))
        {
        Debug.Log (hitData.collider);
        Debug.DrawRay(ray.origin, hitData.point - transform.position, Color.red, 10f);
        if (hitData.collider)
        {
            Plant plant = hitData.collider.GetComponent<Plant>();
            if (plant == null || !plant._canHarvest) return;
            Destroy(hitData.collider.gameObject);
            _inventory.carrot ++ ;
        }
        if (hitData.collider)
        {
            if(hitData.collider.TryGetComponent<Field>(out Field field))
            {
                // voir si il y a assez de graine
                field.TryToPlantAt(hitData.point);
            }             
        }
        }
        
    }
}

