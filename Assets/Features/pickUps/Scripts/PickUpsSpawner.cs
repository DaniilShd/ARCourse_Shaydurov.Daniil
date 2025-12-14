using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpsSpawner : MonoBehaviour
{
    [SerializeField] private PickUp _pickupPrefab;
    [SerializeField] private float _spawnTimeDelay;
    [SerializeField] private Vector2Int _xRandomBorders = new Vector2Int(-30, 30);
    [SerializeField] private Vector2Int _zRandomBorders = new Vector2Int(-30, 30);

    private float _currentTime;
    private System.Random _random;

    private void Awake()
    {
        _random = new System.Random();
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime >= _spawnTimeDelay)
        {
            var x = _random.Next(_xRandomBorders.x, _xRandomBorders.y);
            var z = _random.Next(_zRandomBorders.x, _zRandomBorders.y);

            Instantiate(_pickupPrefab, new Vector3(x, 0, z), Quaternion.identity);

            _currentTime = 0;
        }
    }
}