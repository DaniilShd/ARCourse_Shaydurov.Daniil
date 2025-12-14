using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _currentHealth;
    [SerializeField] private int _currentPoint;

    public float CurrentHelt()
    {
        return 1.0f;
    }

    public int CurrentPoint()
    {
        return 1;
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
