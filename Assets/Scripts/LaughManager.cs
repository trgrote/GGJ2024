using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LaughManager : MonoBehaviour
{
    [SerializeField] rho.RuntimeFloat _laughingTimer;

    [SerializeField] UnityEvent _onLaughRunout;

    // Update is called once per frame
    void Update()
    {
        if (_laughingTimer.Value > 0)
        {
            var newValue = _laughingTimer.Value - Time.deltaTime;

            if (newValue <= 0)
            {
                _onLaughRunout.Invoke();
            }
            
            _laughingTimer.Value = Mathf.Max(newValue, 0);
        }
    }
}
