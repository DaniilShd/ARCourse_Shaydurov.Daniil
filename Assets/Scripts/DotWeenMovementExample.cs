using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DotWeenMovementExample : MonoBehaviour
{
    [SerializeField] private float _timeToMove;
    [SerializeField] private Transform _target;
    [SerializeField] private Ease _ease = Ease.Linear;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.DOMove(_target.position, _timeToMove).SetEase(_ease);
        }
    }
}
