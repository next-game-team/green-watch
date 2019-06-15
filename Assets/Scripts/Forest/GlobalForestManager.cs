using System.Collections.Generic;
using UnityEngine;

public class GlobalForestManager : Singleton<GlobalForestManager>
{
    [SerializeField] 
    private Tree _treePrefab;
    public Tree TreePrefab => _treePrefab;

    [SerializeField] private List<Sprite> _treeSprites;

    public Sprite GetRandomTreeSprite()
    {
        return RandomUtils.GetRandomObjectFromList(_treeSprites);
    }

}
