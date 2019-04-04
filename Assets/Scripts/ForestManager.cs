using System.Collections.Generic;
using UnityEngine;

public class ForestManager : MonoBehaviour
{
    [SerializeField] private int _treeCount;
    
    [SerializeField] private float _xDistance = 0.1f;
    [SerializeField] private float _yDistance = 0.1f;
    [SerializeField] private GameObject _treePrefab;
    [SerializeField] private Vector2 _treeDragDelta;
    
    private PolygonCollider2D _collider;

    private List<GameObject> _treeList = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        _collider = GetComponent<PolygonCollider2D>();  
        GenerateForest();
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
    }
}
