using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    [SerializeField] private Color _hoverColor;
    [SerializeField] private Color _clickColor;
    [SerializeField] private Camera _camera;


    [SerializeField] private LayerMask _layerMask;
    private List<int> _clickedObjectID = new List<int>();
    private int _lastObjectHitedID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 200, _layerMask))
        {
            if (_lastObjectHitedID == hit.transform.GetInstanceID())
            {
                return;
            }
            if (_clickedObjectID.Contains(hit.transform.GetInstanceID()))
            {
                return;
            }


            var material = hit.transform.GetComponent<MeshRenderer>().material;
            material.SetColor("_Color", _hoverColor);
            _lastObjectHitedID = hit.transform.GetInstanceID();

            if (Input.GetMouseButtonDown(0))
            {
                material.SetColor("_Color", _clickColor);
                _clickedObjectID.Add(hit.transform.GetInstanceID());
            }

        }
        else
        {
            _lastObjectHitedID = -1;
        }
    }
}
