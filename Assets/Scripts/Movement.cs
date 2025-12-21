using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movement : MonoBehaviour
{ 

    [SerializeField] private float _speed;

    [SerializeField] private float _distanceToStop = 1.0f;

    protected abstract Vector3 GetTargetPosition();
  
    void Update()
    {

        var target = GetTargetPosition();

        if (Vector3.Distance(transform.position, target) <= _distanceToStop)
            {
                return;
            }

        var direction = (target - transform.position).normalized;
        transform.Translate(direction * _speed * Time.deltaTime);
    

    }
}
