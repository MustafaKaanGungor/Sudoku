using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;
using System.Linq;

public class ButtonImageSetter : MonoBehaviour
{
    SpriteResolver resolver;
    SpriteLibrary library;
    SpriteLibraryAsset libraryAsset;
    
    void Start()
    {
        resolver = gameObject.GetComponent<SpriteResolver>();
        library = resolver.spriteLibrary;
        libraryAsset = library.spriteLibraryAsset;
    }

    public void ValueChanger(int number) {
        string heyo = libraryAsset.GetCategoryLabelNames("Objects").ElementAt(number);
        resolver.SetCategoryAndLabel("Objects",heyo);
    }
}
