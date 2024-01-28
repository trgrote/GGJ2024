using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaitForInput : MonoBehaviour
{
    [SerializeField] UnityEvent _spacePressed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _spacePressed.Invoke();
        }
    }
}
