using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
public class SudokuGrid : MonoBehaviour
{
    private int gridSize = 0;
    [SerializeField] private GameObject tileUI;
    [SerializeField] private GameObject ObjectMenu;
    [SerializeField] private GameObject selectionButton;
    [SerializeField] public LevelObject level;
    [SerializeField] public static LevelObject levelStatic;

    [SerializeField] public int selectedItem;

    void Start() {
        levelStatic = level;

        SetGridLayout();
        SetSelectionButtons();
        SpawnTiles();
        SpawnSelectionButtons();
    }

    void SetGridLayout() {
        gridSize = level.spriteLibrary.GetCategoryLabelNames("Objects").Count();
        GridLayoutGroup layout = gameObject.GetComponent<GridLayoutGroup>();

        layout.cellSize = new Vector2(900/gridSize, 900/gridSize);
    }

    void SpawnTiles() {
        for(int i = 0; i < gridSize; i++) {
            for(int j = 0; j < gridSize; j++) {
                Instantiate(tileUI, transform.position, transform.rotation, gameObject.transform);
            }
        }
    }

    void SetSelectionButtons() {
        GridLayoutGroup objectLayout = ObjectMenu.GetComponent<GridLayoutGroup>();

        if(gridSize < 5) {
            objectLayout.cellSize = new Vector2(800/(gridSize+1),250);
        } else {
            objectLayout.cellSize = new Vector2(800 * 2/(gridSize+1),125);
        }
    }

    void SpawnSelectionButtons() {
        for(int i = 0; i <= gridSize; i++) {
            Instantiate(selectionButton, ObjectMenu.transform.position, ObjectMenu.transform.rotation, ObjectMenu.transform);
        }

        Invoke("setColorsofButtons", 1f);
    }

    void setColorsofButtons() {
        for(int i = 0; i < gridSize; i++) {
            ObjectMenu.transform.GetChild(i).GetComponent<ButtonBody>().changeColor(i);
        }
    }
}
