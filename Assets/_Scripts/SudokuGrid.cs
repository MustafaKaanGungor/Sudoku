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
    }

    void SpawnSelectionButtons() {

    }
}
