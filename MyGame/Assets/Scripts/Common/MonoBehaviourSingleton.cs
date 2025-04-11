using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonobehaviourSingleton<T> : MonoBehaviour where T : Component
{
    private static T instance;
    public static T Instance { get => instance; }
    [Header("Monobehaviour Singleton")]
    [SerializeField]
    protected bool dontDestroyOnLoad = true; 

    protected virtual void Awake()
    {
        if (instance == null)
        {
            // Debug.Log("Awake: " + gameObject.name);
            instance = this as T;
             DontDestroyOnLoad(gameObject);
        } else if (instance != this as T)
        {
            Destroy(this);
        }
    }
}


