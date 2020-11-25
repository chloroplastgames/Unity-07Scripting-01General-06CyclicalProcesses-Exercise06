using UnityEngine;
using UnityEngine.Events;

public class Switcher : MonoBehaviour
{

    #region Fields/Properties

    /// <summary>
    /// "Pressed" event.
    /// </summary>
    public UnityEvent OnPressedEvent { get; private set; } = new UnityEvent();

    private bool _isPressed;

    #endregion


    #region Lifecycle

    /* DUDA: Los OnEnable no van después de todos los Awakes!!!¿?¿?¿? - Parece que no.
    private void Awake()
    {
Debug.Log("--------- Switcher Awake!!!");
        OnPressedEvent = new UnityEvent();
Debug.Log("--------- OnPressedEvent = [" + OnPressedEvent + "]");
    }
    */

    private void Start()
    {
        _isPressed = false;
    }

    private void OnTriggerEnter()
    {
        if (!_isPressed)
        {
            Press();
        }
    }

    #endregion


    #region Own methods

    private void Press()
    {
        _isPressed = true;
        OnPressed();
        transform.position += Vector3.down * 0.25f;
    }

    private void OnPressed()
    {
        OnPressedEvent?.Invoke();
    }

    #endregion

}
