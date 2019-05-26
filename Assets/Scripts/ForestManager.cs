using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ForestManager : MonoBehaviour
{
    [Header("Info"), SerializeField, ReadOnly, Range(0, ForestStageManager.MaxStage)] private int _currentStage;
    [SerializeField, ReadOnly] private int _treeCount;
    [SerializeField, ReadOnly] private int _currentTreeCount;
    [Header("Generation Setup"), SerializeField] private float _xDistance = 0.1f;
    [SerializeField] private float _yDistance = 0.1f;
    [SerializeField] private Vector2 _treeDragDelta;
    [SerializeField] private GameObject _treePrefab;
    
    private PolygonCollider2D _collider;

    private readonly List<GameObject> _treeList = new List<GameObject>();
    private readonly Stack<List<int>> _treeDisableHistory = new Stack<List<int>>();
    
    // Start is called before the first frame update
    void Start()
    {
        _collider = GetComponent<PolygonCollider2D>();  
        InitForest();
    }

    void InitForest()
    {
        _currentStage = 0;
        GenerateForest();
    }

    public void NextStage()
    {
        if (_currentStage == ForestStageManager.MaxStage)
        {
            Debug.LogWarning("Max stage was already reached.");
            return;
        }
        
        _currentStage++;
        var stageInfo = ForestStageManager.Instance.GetStageInfo(_currentStage);
        DecreaseTreeCount(stageInfo);
    }

    private void DecreaseTreeCount(ForestStageInfo stageInfo)
    {
        // Calculate how many trees must be cut
        var treesToDecreaseCount = _currentTreeCount - (int)(_treeCount * stageInfo.TreeCountRate);

        var decreaseHistoryList = new List<int>(treesToDecreaseCount);
        var enabledTreeList = GetEnabledTreeList();

        // Decrease trees
        for (var i = 0; i < treesToDecreaseCount; i++)
        {
            var randomTreeIndex = Random.Range(0, enabledTreeList.Count); // Get random tree
            enabledTreeList[randomTreeIndex].Value.SetActive(false); // Disable this tree
            decreaseHistoryList.Add(enabledTreeList[randomTreeIndex].Key); // Save index of this tree
            enabledTreeList.RemoveAt(randomTreeIndex); // Remove this tree from enabled list
        }
        
        // Save history
        _treeDisableHistory.Push(decreaseHistoryList);

        _currentTreeCount -= treesToDecreaseCount;
    }

    private List<KeyValuePair<int, GameObject>> GetEnabledTreeList()
    {
        var enabledTreeList = new List<KeyValuePair<int, GameObject>>();

        for (var index = 0; index < _treeList.Count; index++)
        {
            if (_treeList[index].activeSelf)
            {
                enabledTreeList.Add(new KeyValuePair<int, GameObject>(index, _treeList[index]));
            }
        }

        return enabledTreeList;
    }

    void GenerateForest()
    {
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
                    var tree = Instantiate(_treePrefab, vector, Quaternion.identity, transform);
                    _treeList.Add(tree);
                }
            }
        }

        _treeCount = _treeList.Count;
        _currentTreeCount = _treeCount;
    }
}
