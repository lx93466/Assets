using UnityEngine;
using System.Collections;
using LuaFramework;

public class Main : MonoBehaviour {
	[HideInInspector]
	public static Main instance = null;
	[HideInInspector]
	public static LuaManager luaManager = null;
	[HideInInspector]
	public static PanelManager panelManager = null;
	[HideInInspector]
	public static SoundManager soundManager = null;
	[HideInInspector]
	public static NetworkManager networkManager = null;
	[HideInInspector]
	public static ThreadManager threadManager = null;
	[HideInInspector]
	public static ResourceManager resourceManager = null;
	[HideInInspector] 
	public static ObjectPoolManager objectPoolManager = null;
	[HideInInspector]
	public static GameManager gameManager = null;

	void Awake()
	{
		instance = this;
		panelManager = gameObject.AddComponent<PanelManager> ();
		soundManager = gameObject.AddComponent<SoundManager> ();
		networkManager = gameObject.AddComponent<NetworkManager> ();
		resourceManager = gameObject.AddComponent<ResourceManager> ();
		threadManager = gameObject.AddComponent<ThreadManager> ();
		objectPoolManager = gameObject.AddComponent<ObjectPoolManager> ();
		luaManager = gameObject.AddComponent<LuaManager> ();
		gameManager = gameObject.AddComponent<GameManager> ();
	}
}
