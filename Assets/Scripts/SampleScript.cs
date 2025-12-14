using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("ARCourse/Sample Script")]

public class SampleScript : MonoBehaviour
{
    public List<ShowData> Data;
    public int IntValue = 10;
    public float FloatValue = 15;
    public double DoubleValue = 30;
    public bool BoolValue = true;
    public string StringValue = "Hello!";
    [Header("Color for mat")]
    [TooltipAttribute("This color will be aplied")]
    public Color ColorMat = Color.red;
    [Space(30)]
    public SampleScript SampleComponent;
    private Dictionary<string, float> _dict = new Dictionary<string, float>();


    [HideInInspector] public float HidenFloat;

    [SerializeField][Range(1.0f, 10.0f)] private float _privateFloatValue;

    [SerializeField] private AnotherSampleScript _logger; 
    private void Start()
    {
        foreach (var item in Data)
        {
            _dict.Add(item.Key, item.Data);
        }

        if (_logger != null)
        {
            _logger.LogMessage();
        }
        else
        {
            Debug.LogWarning("Logger is not assigned");
        }

        Debug.Log($"IntValue {IntValue}");
        Debug.Log($"FloatValue {FloatValue}");
        Debug.Log($"DoubleValue {DoubleValue}");
        Debug.Log($"BoolValue {BoolValue}");
        Debug.Log($"StringValue {StringValue}");
        Debug.Log($"ColorMat {ColorMat}");
    }

    private void Update()
    {
        Debug.Log($"IntValue {IntValue}");
        Debug.Log($"FloatValue {FloatValue}");
        Debug.Log($"DoubleValue {DoubleValue}");
        Debug.Log($"BoolValue {BoolValue}");
        Debug.Log($"StringValue {StringValue}");
        Debug.Log($"ColorMat {ColorMat}");
    }

    public struct ShowData
    {
        public string Key;
        public float Data;
    }
}