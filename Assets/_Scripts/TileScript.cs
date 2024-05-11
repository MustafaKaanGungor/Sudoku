using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class TileScript : MonoBehaviour
{
    SpriteResolver resolver;
    SpriteLibrary library;
    SpriteLibraryAsset libraryAsset;
    
    void Start()
    {
        resolver = gameObject.GetComponent<SpriteResolver>();
        library = resolver.spriteLibrary;
        libraryAsset = library.spriteLibraryAsset;

        int randNumber = Random.Range(0,libraryAsset.GetCategoryLabelNames("Objects").Count());

        string heyo = libraryAsset.GetCategoryLabelNames("Objects").ElementAt(randNumber);
        resolver.SetCategoryAndLabel("Objects",heyo);
    }

    public void ValueChanger(int number) {
        string heyo = libraryAsset.GetCategoryLabelNames("Objects").ElementAt(number);
        resolver.SetCategoryAndLabel("Objects",heyo);
    }
}
