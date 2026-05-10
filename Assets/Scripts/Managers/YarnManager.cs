
using System.Collections.Generic;
using UnityEngine;

public class YarnManager : MonoBehaviour
{
    [SerializeField] GameManagerSO gameManagerSO;

    [SerializeField] List<YarnListener> yarnListeners = new List<YarnListener>();

    private void Awake()
    {
        gameManagerSO.yarnManager = this;
    }

    public void addListener(YarnListener listener)
    {
        yarnListeners.Add(listener);
    }
}
