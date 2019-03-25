using UnityEngine;

/* Code partly of Brackeys Youtube Tutorial 
 * https://www.youtube.com/watch?v=9tePzyL6dgc&t=101s
*/

public class Interactable : MonoBehaviour
{

    public float radius = 3f;               // how close player needs to get 
    public Transform interactionTransform;  // The transform from where interact

    bool isFocus = false;           // Is interactable currently focused?
    Transform player;               // Reference to the player transform

    bool hasInteracted = false;     // already interacted with the object

    public virtual void Interact()
    {
        // This method is meant to be overwritten
        Debug.Log("Interacting with " + transform.name);
    }

    void Update()
    {
        // If we are currently being focused
        // and we haven't already interacted with the object
        if (isFocus && !hasInteracted)
        {
            // If we are close enough
            float distance = Vector3.Distance(player.position, interactionTransform.position);
            if (distance <= radius)
            {
                // Interact with the object
                Interact();
                hasInteracted = true;
            }
        }
    }

    // Called when the object starts being focused
    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasInteracted = false;
    }

    // Called when the object is no longer focused
    public void OnDefocused()
    {
        isFocus = false;
        player = null;
        hasInteracted = false;
    }

    // CallBack function to visualize radius
    void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
            interactionTransform = transform;

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }


}