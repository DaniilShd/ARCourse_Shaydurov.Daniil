using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[AddComponentMenu("ARCourse/Object Spawner")]

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _gameObjectToSpawner;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_gameObjectToSpawner);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
