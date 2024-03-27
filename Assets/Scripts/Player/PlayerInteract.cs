using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] float _maxRaycastHit;
    [SerializeField] Plant _plantScript;
    [SerializeField] PlayerInventory _inventory;
    [SerializeField] Camera _cam;
    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.canceled) return;
        Interaction();
    }

    private void Interaction()
    {
        Ray ray = new Ray(transform.position, _cam.transform.forward);
        RaycastHit hitData;

        if(Physics.Raycast(ray, out hitData, _maxRaycastHit))
        {
            Debug.Log (hitData.collider);
            Debug.DrawRay(ray.origin, hitData.point - transform.position, Color.red, 10f);

            if (hitData.collider == null) return;

            Plant plant = hitData.collider.GetComponent<Plant>();
            if (plant != null && plant._canHarvest)
            {
                Destroy(hitData.collider.gameObject);
                _inventory.carrot++;
                return;
            }

            Field field = hitData.collider.GetComponent<Field>();
            if (field != null && _inventory.carrotSeed > 0)
            {
                field.TryToPlantAt(hitData.point);
                _inventory.carrotSeed--;
                return;
            }
        }
    }   
}

