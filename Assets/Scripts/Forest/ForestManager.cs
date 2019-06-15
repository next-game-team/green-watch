﻿using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ForestManager : NatureManager
{
    [SerializeField, ReadOnly] private int _treeCount;
    [SerializeField, ReadOnly] private int _currentTreeCount;
    [Header("Generation Setup"), SerializeField] private float _xDistance = 0.1f;
    [SerializeField] private float _yDistance = 0.1f;
    [SerializeField] private Vector2 _treeDragDelta;
    [SerializeField] private GameObject[] _treePrefab;
    
    private PolygonCollider2D _collider;

    private readonly List<GameObject> _treeList = new List<GameObject>();
    private readonly Stack<List<GameObject>> _treeDisableHistory = new Stack<List<GameObject>>();
    
    // Start is called before the first frame update
    void Start()
    {
        _collider = GetComponent<PolygonCollider2D>();  
        InitForest();
    }

    public void InitForest()
    {
        _collider = GetComponent<PolygonCollider2D>();
        InitStage();
        GenerateForest();
    }

    protected override void OnNextStage()
    {
        var stageInfo = ForestStageManager.Instance.GetStageInfo(GetCurrentStage());
        DecreaseTreeCount(stageInfo);
    }

    private void DecreaseTreeCount(ForestStageInfo stageInfo)
    {
        // Calculate how many trees must be cut
        var treesToDecreaseCount = _currentTreeCount - (int)(_treeCount * stageInfo.TreeCountRate);

        var decreaseHistoryList = new List<GameObject>(treesToDecreaseCount);
        var enabledTreeList = GetEnabledTreeList();

        // Decrease trees
        for (var i = 0; i < treesToDecreaseCount; i++)
        {
            var randomTreeIndex = Random.Range(0, enabledTreeList.Count); // Get random tree
            enabledTreeList[randomTreeIndex].SetActive(false); // Disable this tree
            decreaseHistoryList.Add(enabledTreeList[randomTreeIndex]); // Save index of this tree
            enabledTreeList.RemoveAt(randomTreeIndex); // Remove this tree from enabled list
        }
        
        // Save history
        _treeDisableHistory.Push(decreaseHistoryList);

        _currentTreeCount -= treesToDecreaseCount;
    }

    protected override void OnPreviousStage()
    {
        var decreaseHistoryList = _treeDisableHistory.Pop();
        _currentTreeCount += decreaseHistoryList.Count;
        decreaseHistoryList.ForEach(tree => tree.SetActive(tree));
    }

    private List<GameObject> GetEnabledTreeList()
    {
        return _treeList.FindAll(tree => tree.activeSelf);
    }

    private void GenerateForest()
    {
        // Clear children
        foreach (var child in transform.GetComponentsInChildren<Tree>())
        {
            DestroyImmediate(child.gameObject);
        }
        _treeList.Clear();
        
        // Generate new forest
        var vector = new Vector3();
        for (var x = _collider.bounds.min.x; x < _collider.bounds.max.x; x += _xDistance)
        {
            for (var y = _collider.bounds.min.y; y < _collider.bounds.max.y; y += _yDistance)
            {
                vector.x = x;
                vector.y = y;

                vector.x += Random.Range(-_treeDragDelta.x, _treeDragDelta.x);
                vector.y += Random.Range(-_treeDragDelta.y, _treeDragDelta.y);

                if (_collider.OverlapPoint(vector))
                {
                    var randomTree = _treePrefab[Random.Range(0, _treePrefab.Length)];
                    var tree = Instantiate(randomTree, vector, Quaternion.identity, transform);
                    _treeList.Add(tree);
                }
            }
        }

        _treeCount = _treeList.Count;
        _currentTreeCount = _treeCount;
    }
}
