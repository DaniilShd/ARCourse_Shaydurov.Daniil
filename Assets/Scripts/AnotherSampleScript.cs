using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("ARCourse/Another Sample Script")]

public class AnotherSampleScript : MonoBehaviour
{
    [SerializeField] private string _message = "Default message";

    [ContextMenu("LogMessageTest")]

    public void LogMessage()
    {
        Debug.Log(_message);
    }
}
