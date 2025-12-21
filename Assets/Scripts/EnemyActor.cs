using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActor : Movement
{
    [SerializeField] private Transform _playerTransform;
    protected override Vector3 GetTargetPosition()
    {
       return _playerTransform.position;
    }
}
