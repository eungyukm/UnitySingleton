using UnityEngine;
using UnityEngine.Events;

public class UnityActionExample : MonoBehaviour
{
    public UnityAction OnActionCall;

    private void OnEnable()
    {
        OnActionCall += Print;
    }

    private void Start()
    {
        OnActionCall();
    }

    public void Print()
    {
        //Debug.Log("Print!!");
    }
}
