using UnityEngine;

/****TODO*****/
// Snap to the board when card is released
// Move cards on the board away when hovering with a dragged card
// Animation, sound and effects when a card is dropped into the board

public class DragAndDrop : MonoBehaviour
{
    private Vector3 mouseOffset;
    private float zAxis;

    public float liftZ = -0.25f;

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mouseOffset;
    }

    private void OnMouseDown()
    {
        transform.Translate(0, 0, liftZ); //Lifts a card a little bit
        zAxis = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;    
        // Calculates the offset so a card just don't snap into the cursor.
        mouseOffset = transform.position - GetMouseWorldPos();
    }

    private void OnMouseUp()
    {
        transform.Translate(0, 0, -liftZ); // Returns a card to the original z
    }

    /*Gets the position of the mouse in world units.
     * Because mouse only have two axis, the Z axis needs to be provided.*/
    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = zAxis; // Uses the Z of the card as the mouse pos Z.
        Vector3 screenToWorld = Camera.main.ScreenToWorldPoint(mousePos);
        return screenToWorld;
    }
}