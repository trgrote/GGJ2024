using System;
using System.Collections;
using System.Collections.Generic;
using rho;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class EndOfGameMonitor : MonoBehaviour
{
    [SerializeField] rho.RuntimeGameObjectSet _destructableObjects;
    [SerializeField] rho.Event _endOfGameEvent;

    void OnEnable()
    {
        _destructableObjects.SetChanged += CheckEndOfGame;
    }

    private void CheckEndOfGame(RuntimeSet<GameObject> sender)
    {
        if (_destructableObjects.Count == 0)
        {
            _endOfGameEvent.Raise();
        }
    }

    void OnDisable()
    {
        _destructableObjects.SetChanged -= CheckEndOfGame;
    }
}
