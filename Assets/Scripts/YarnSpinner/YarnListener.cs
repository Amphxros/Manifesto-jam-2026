using UnityEngine;

public abstract class YarnListener : MonoBehaviour
{
    [SerializeField] GameManagerSO gameManager;
    protected YarnManager yarnManager;
    void Start()
    {
        yarnManager = gameManager.yarnManager;
        yarnManager.addListener(this);
        

    }

    protected abstract void OnMessageReceived(YarnEvent yarnEvent);

   
}
