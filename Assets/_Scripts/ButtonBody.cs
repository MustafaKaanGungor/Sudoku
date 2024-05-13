using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class ButtonBody : MonoBehaviour
{
    [SerializeField] GameObject Image;
    [SerializeField] GameObject SelectionButton;
    [SerializeField] GameObject spawnedTile;
    [SerializeField] GameObject spawnedTileButton;
    [SerializeField] GameObject canvas;



    private SpriteLibrary spriteLibrary;
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        Invoke("SpawnTile", 0.5f);    
    }
    void SpawnTile() {
        spawnedTile = Instantiate(Image, transform.position, transform.rotation);
        spawnedTileButton = Instantiate(SelectionButton, transform.position, transform.rotation, canvas.transform);

        spawnedTileButton.GetComponent<SelectionButton>().setTheOwner(gameObject);

        spriteLibrary = spawnedTile.GetComponent<SpriteLibrary>();

        spriteLibrary.spriteLibraryAsset = SudokuGrid.levelStatic.spriteLibrary;

        
    }

    public void changeColor(int number) {
        spawnedTile.GetComponent<ButtonImageSetter>().ValueChanger(number);
        SelectionButton.GetComponent<SelectionButton>().number = number;
    }
}
