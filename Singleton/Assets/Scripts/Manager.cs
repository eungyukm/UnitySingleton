using UnityEngine;
using UnityEngine.Events;

public class Manager : MonoBehaviour
{
    public static Manager Instance;

    public UnityAction OnPrint;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        if(OnPrint != null)
        {
            OnPrint();
        }
    }

    public void Save()
    {
        Debug.Log("Save!!");
    }
}
