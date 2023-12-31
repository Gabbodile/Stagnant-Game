using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameBehaviour : MonoBehaviour
{
    //Project Specific
    // protected static *ManagerName* *_MN* { get { return *ManagerName*.Instance; } }
    protected static GameManager _GM { get { return GameManager.Instance; } }
    protected static DialogueManager _DM { get { return DialogueManager.Instance; } }
    protected static LoopAndChoices _LOOP { get { return LoopAndChoices.Instance; } }
    protected static TimeChange _TIME { get { return TimeChange.Instance; } }
    protected static ItemGlow _Glow { get { return ItemGlow.Instance; } }
    protected static SceneController _SC { get { return SceneController.Instance; } }
    protected static UIManager _UI { get { return UIManager.Instance; } }
    protected static SaturationIncrease _SI { get { return SaturationIncrease.Instance; } }
    protected static PhoneUI _PU { get { return PhoneUI.Instance; } }
    protected static ScreenFader _SF { get { return ScreenFader.Instance; } }

    

}
    
public class GameBehaviour<T> : GameBehaviour where T : GameBehaviour
{
    public bool dontDestroy;
    static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("GameBehaviour<" + typeof(T).ToString() + "> not instantiated!\nNeed to call Instantiate() from " + typeof(T).ToString() + "Awake().");
            return _instance;
        }
    }
    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
            if (dontDestroy) DontDestroyOnLoad(gameObject);
        }
        //else
           // Destroy(gameObject);
    }
    //
    // Instantiate singleton
    // Must be called first thing on Awake()
    protected bool Instantiate()
    {
        if (_instance != null)
        {
            Debug.LogWarning("Instance of GameBehaviour<" + typeof(T).ToString() + "> already exists! Destroying myself.\nIf you see this when a scene is LOADED from another one, ignore it.");
            DestroyImmediate(gameObject);
            return false;
        }
        _instance = this as T;
        return true;
    }
}