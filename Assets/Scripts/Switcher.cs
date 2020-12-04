using UnityEngine;
using UnityEngine.Events;

public class Switcher : MonoBehaviour
{
    public bool IsSwitched { get; private set; } 

    public UnityEvent SwitchChange;

    private void Start()
    {
        IsSwitched = false;
    }

    private void OnTriggerEnter()
    {
        if (!IsSwitched)
        {
            IsSwitched = true;

            OnSwitchChange();
        }
    }

    private void OnSwitchChange()
    {
        if (SwitchChange != null)
        {
            SwitchChange.Invoke();
        }
    }
}
