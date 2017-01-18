using UnityEngine;
using System.Collections;
using LuaFramework;
using System.Collections.Generic;

public class Base : MonoBehaviour {
	  private AppFacade m_Facade;
//    private LuaManager m_LuaMgr;
//    private ResourceManager m_ResMgr;
//    private NetworkManager m_NetMgr;
//    private SoundManager m_SoundMgr;
//    private TimerManager m_TimerMgr;
//    private ThreadManager m_ThreadMgr;
//    private ObjectPoolManager m_ObjectPoolMgr;
//
//    /// <summary>
//    /// 注册消息
//    /// </summary>
//    /// <param name="view"></param>
//    /// <param name="messages"></param>
    protected void RegisterMessage(IView view, List<string> messages) {
        if (messages == null || messages.Count == 0) return;
        Controller.Instance.RegisterViewCommand(view, messages.ToArray());
    }

    /// <summary>
    /// 移除消息
    /// </summary>
    /// <param name="view"></param>
    /// <param name="messages"></param>
    protected void RemoveMessage(IView view, List<string> messages) {
        if (messages == null || messages.Count == 0) return;
        Controller.Instance.RemoveViewCommand(view, messages.ToArray());
    }

    protected AppFacade facade {
        get {
            if (m_Facade == null) {
                m_Facade = AppFacade.Instance;
            }
            return m_Facade;
        }
    }
//
//    protected LuaManager LuaManager {
//        get {
//			return Main.luaManager;
//        }
//    }
//
//    protected ResourceManager ResManager {
//        get {
//			return Main.resourceManager;
//        }
//    }
//
//    protected NetworkManager NetManager {
//        get {          
//			return Main.networkManager;
//        }
//    }
//
//    protected SoundManager SoundManager {
//        get {          
//			return Main.soundManager;
//        }
//    }
//
//    protected TimerManager TimerManager {
//        get {         
//			return Main.timerManager;
//        }
//    }
//
//    protected ThreadManager ThreadManager {
//        get {       
//			return Main.threadManager;
//        }
//    }
//
//    protected ObjectPoolManager ObjPoolManager {
//        get {          
//			return Main.objectPoolManager;
//        }
//    }
}
