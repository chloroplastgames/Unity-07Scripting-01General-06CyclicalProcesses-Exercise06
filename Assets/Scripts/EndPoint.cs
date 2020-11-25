using UnityEngine;
using UnityEngine.Events;

public class EndPoint : MonoBehaviour
{

    #region Fields/Properties

    /// <summary>
    /// "Reached" event.
    /// </summary>
    public UnityEvent OnReachedEvent { get; private set; } = new UnityEvent();

    #endregion


    #region Lifecycle

    /* DUDA: Los OnEnable no van después de todos los Awakes!!!¿?¿?¿? - Parece que no.
    private void Awake()
    {
        OnReachedEvent = new UnityEvent();
    }
    */

    private void OnTriggerEnter()
    {
        OnReached();
    }

    #endregion


    #region Own methods

    private void OnReached()
    {
        OnReachedEvent?.Invoke();
    }

    #endregion

}
