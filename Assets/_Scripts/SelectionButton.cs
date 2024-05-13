using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectionButton : Selectable, IPointerClickHandler, ISubmitHandler, IPointerUpHandler, IPointerExitHandler
{
    GameObject ownerTile;
    [SerializeField] GameObject grid;

    public int number;

    public void setTheOwner(GameObject owner) {
        ownerTile = owner;
        grid = GameObject.Find("GirdUI");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        grid.GetComponent<SudokuGrid>().selectedItem = number;
    }

    public void OnSubmit(BaseEventData eventData)
    {
        
    }

    
}
