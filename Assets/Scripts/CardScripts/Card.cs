using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IPointerClickHandler
{
    // INHERITANCE
    public virtual void playCard()
    {

        Debug.Log("Use|");
    
    }

    // INHERITANCE
    public virtual void OnPointerClick(PointerEventData eventData)
    {
        playCard();
    }
}
