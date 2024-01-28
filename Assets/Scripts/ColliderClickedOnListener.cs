using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class ColliderClickedOnListener : MonoBehaviour
{
    [SerializeField] UnityEvent _onClicked;
    Camera m_Camera;
    void Awake()
    {
        m_Camera = Camera.main;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = m_Camera.ScreenPointToRay(mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                // Use the hit variable to determine what was clicked on.
                var myCollider = GetComponent<Collider>();
                if (hit.collider == myCollider)
                {
                    _onClicked.Invoke();
                }
            }
        }
    }
}
