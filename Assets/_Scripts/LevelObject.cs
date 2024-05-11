using UnityEngine;
using UnityEngine.U2D.Animation;

[CreateAssetMenu(menuName = "LevelCreation/LevelObject")]
public class LevelObject : ScriptableObject{
    [SerializeField] public SpriteLibraryAsset spriteLibrary;

    [SerializeField] DifficultyLevels difficulty;
}

enum DifficultyLevels {
    EASY,
    MEDIUM,
    HARD
}