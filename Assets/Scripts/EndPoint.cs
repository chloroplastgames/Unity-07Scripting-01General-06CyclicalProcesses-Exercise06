using UnityEngine;
using UnityEngine.Events;

public class EndPoint : MonoBehaviour
{
    public bool IsEnter { get; private set; } 

    public UnityEvent EndPointChange;

    private void Start()
    {
        IsEnter = false;
    }

    private void OnTriggerEnter()
    {
        if (!IsEnter)
        {
            IsEnter = true;
            OnEndPointChange();
        }
    }

    private void OnEndPointChange()
    {
        if (EndPointChange != null)
        {
            EndPointChange.Invoke();
        }
    }
}
