using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class tileButton : Selectable, IPointerClickHandler, ISubmitHandler, IPointerUpHandler, IPointerExitHandler
{
    GameObject ownerTile;

    public void setTheOwner(GameObject owner) {
        ownerTile = owner;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ownerTile.GetComponent<TileUIScript>().changeColor(4);
    }

    public void OnSubmit(BaseEventData eventData)
    {
        
    }

    
}
