using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private float distance = 3f; 
    [SerializeField] private LayerMask mask; 
    void Awake()
    {
        cam = GetComponent<PlayerLook>().cam;
    }

    void Start()
    {
        
    }

    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        //Makes the Ray visible
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo, distance, mask)){
            if(hitInfo.collider.GetComponent<AInteractable>() != null){
                Debug.Log(hitInfo.collider.GetComponent<AInteractable>().promtMessage);
            }
        }
    }
}
