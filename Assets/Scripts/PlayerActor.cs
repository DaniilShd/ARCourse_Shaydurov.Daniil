using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActor : Movement
{
    [SerializeField] private Camera _camera;

    [SerializeField] private float _rayLength = 100.0f;
    [SerializeField] private LayerMask _layerMask;

    private Vector3 _lastHitPoint;
    protected override Vector3 GetTargetPosition()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, _rayLength, _layerMask))
        {
            _lastHitPoint = hit.point;
            
            return _lastHitPoint;
        }
        return _lastHitPoint;
    }




}
