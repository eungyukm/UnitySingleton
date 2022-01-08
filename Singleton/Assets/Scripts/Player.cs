using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Manager.Instance.OnPrint += Print;

        // Singleton 호출
        Manager.Instance.Save();
    }

    public void Print()
    {
        Debug.Log("Print!!");
    }
}