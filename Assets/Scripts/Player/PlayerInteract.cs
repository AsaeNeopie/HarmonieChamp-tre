using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{
    /// <summary>
    /// Permet d'interagir avec les champs, et les legumes.
    /// </summary>
    /// <param name="context"></param>

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
        Ray ray = new Ray(_cam.transform.position, _cam.transform.forward);
        RaycastHit hitData;

        if(Physics.Raycast(ray, out hitData, _maxRaycastHit))
        {
            Debug.Log (hitData.collider);
            Debug.DrawRay(ray.origin, hitData.point - transform.position, Color.red, 10f);

            if (hitData.collider == null) return;
            
            Plant plant = hitData.collider.GetComponent<Plant>();
            if (plant != null && plant.canHarvest && plant.IsCarrot)
            {
                plant.Field.FreeSlot();
                Destroy(hitData.collider.gameObject);
                _inventory.carrot++;                
                return;
            }
            else if (plant != null && plant.canHarvest && plant.IsTomato)
            {
                plant.Field.FreeSlot();
                Destroy(hitData.collider.gameObject);
                _inventory.tomato +=3;
                return;
            }


            Field field = hitData.collider.GetComponent<Field>();
            if (field != null && _inventory.carrotSeed > 0 && field.IsCarrotField)
            {
                field.TryToPlantAt(hitData.point);
                _inventory.carrotSeed--;
                return;
            }

            if (field != null && _inventory.tomatoSeed > 0 && field.IsTomatoField)
            {
                field.TryToPlantAt(hitData.point);
                _inventory.tomatoSeed--;
                return;
            }
        }
    }   
}

