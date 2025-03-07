using UnityEngine;

public abstract class AInteractable : MonoBehaviour
{
    public string promtMessage;
    public void BaseInteraction(){
        Interact();
    }
    protected virtual void Interact(){

    }
}
