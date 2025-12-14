using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("ARCourse/Material Color Changer")]
[RequireComponent(typeof(MeshRenderer))]

public class MaterialColorChanger : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    [SerializeField] private Color _color;

    void Start()
    {
        _meshRenderer = gameObject.GetComponent<MeshRenderer>();
    
    }

    void Update()
    {
        _meshRenderer.material.color = _color;
    }
}
