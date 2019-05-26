using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestStageManager : MonoBehaviour
{
    [SerializeField] private ForestStageDictionary _stageDictionary;
}

public enum ForestStageEnum
{
    Stage0,
    Stage1,
    Stage2,
    Stage3,
    Stage4,
    Stage5,
    Stage6
}
