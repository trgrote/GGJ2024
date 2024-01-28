using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    [SerializeField] rho.RuntimeFloat _laughCounter;
    [SerializeField] rho.Event _startGameEvt;

    // Start is called before the first frame update
    void Start()
    {
        _laughCounter.Value = 0;
        StartCoroutine(StartGameAfterDelay());
    }

    IEnumerator StartGameAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        _startGameEvt.Raise();
    }
}
