using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class tileButton : Selectable, IPointerClickHandler, ISubmitHandler, IPointerUpHandler, IPointerExitHandler
{
    GameObject ownerTile;
    [SerializeField] GameObject grid;

    public void setTheOwner(GameObject owner) {
        ownerTile = owner;
        grid = GameObject.Find("GirdUI");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ownerTile.GetComponent<TileUIScript>().changeColor(grid.GetComponent<SudokuGrid>().selectedItem);
    }

    public void OnSubmit(BaseEventData eventData)
    {
        
    }

    
}
