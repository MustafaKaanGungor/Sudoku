using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class TileUIScript : MonoBehaviour
{
    [SerializeField] GameObject Tile;
    [SerializeField] GameObject TileButton;
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
        spawnedTile = Instantiate(Tile, transform.position, transform.rotation);
        spawnedTileButton = Instantiate(TileButton, transform.position, transform.rotation, canvas.transform);

        spawnedTileButton.GetComponent<tileButton>().setTheOwner(gameObject);

        spriteLibrary = spawnedTile.GetComponent<SpriteLibrary>();

        spriteLibrary.spriteLibraryAsset = SudokuGrid.levelStatic.spriteLibrary;
    }

    public void changeColor(int number) {
        spawnedTile.GetComponent<TileScript>().ValueChanger(number);
    }
    
}
