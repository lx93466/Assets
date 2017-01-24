using UnityEngine;
using System.Collections;
using LuaInterface;

namespace LuaFramework {
	public class LuaManager : MonoBehaviour {
		private LuaState luaState;
        private LuaLoader luaLoader;
        private LuaLooper loop = null;
		private bool init = false;

        private static LuaManager _inst = null;
        public static LuaManager inst
        {
            set { _inst = value; }
            get
            {
                if (_inst == null)
                {
                    GameObject go = new GameObject("[LuaManager]");
                    return go.AddComponent<LuaManager>();
                }
                return _inst;
            }
        }
        void Awake() {
            //重新执行脚本生命周期时，防止做重新初始化工作。
            if (_inst != null) return;
            _inst = this;
            //在场景中添加此脚本时，每次返回添加脚本的场景，都会重新执行脚本生命周期。
            //在代码中通过inst新建对象添加脚本时，返回添加场景，不会重新执行脚本生命周期。
            DontDestroyOnLoad(this);

            luaLoader = new LuaLoader();
            luaState = new LuaState();
            this.OpenThirdLibs();
            luaState.LuaSetTop(0);

            LuaBinder.Bind(luaState);
            LuaCoroutine.Register(luaState, this);

			InitStart ();
        }

        public void InitStart() {
			if (!init) {
				InitLuaPath();
				InitLuaBundle();
				this.luaState.Start();    //启动LUAVM
				this.StartMain();
				this.StartLooper();
				init = true;
			}
        }
		public void AddArgToLua(string argName, Object arg)
		{
			if (init) {
				luaState [argName] = arg;
			}
		}
        public LuaTable GetTable(string tableName, bool log = true)
        {
            return luaState.GetTable(tableName, log);
        }
        void StartLooper() {
            loop = gameObject.AddComponent<LuaLooper>();
            loop.luaState = luaState;
        }

        //cjson 比较特殊，只new了一个table，没有注册库，这里注册一下
        protected void OpenCJson() {
            luaState.LuaGetField(LuaIndexes.LUA_REGISTRYINDEX, "_LOADED");
            luaState.OpenLibs(LuaDLL.luaopen_cjson);
            luaState.LuaSetField(-2, "cjson");

            luaState.OpenLibs(LuaDLL.luaopen_cjson_safe);
            luaState.LuaSetField(-2, "cjson.safe");
        }

        void StartMain() {
            luaState.Require("GameEntrance");

            LuaFunction main = luaState.GetFunction("GameEnter");
            main.Call();
            main.Dispose();
            main = null;    
        }
        
        /// <summary>
        /// 初始化加载第三方库
        /// </summary>
        void OpenThirdLibs() {
            luaState.OpenLibs(LuaDLL.luaopen_pb);      
            luaState.OpenLibs(LuaDLL.luaopen_sproto_core);
            luaState.OpenLibs(LuaDLL.luaopen_protobuf_c);
            luaState.OpenLibs(LuaDLL.luaopen_lpeg);
            luaState.OpenLibs(LuaDLL.luaopen_bit);
            luaState.OpenLibs(LuaDLL.luaopen_socket_core);

            this.OpenCJson();
        }

        /// <summary>
        /// 初始化Lua代码加载路径
        /// </summary>
        void InitLuaPath() {
            if (AppConst.DebugMode) {
                string rootPath = AppConst.FrameworkRoot;
                luaState.AddSearchPath(rootPath + "/Lua");
                luaState.AddSearchPath(rootPath + "/ToLua/Lua");
                luaState.AddSearchPath(Application.dataPath + "/GameLuaScript");
            } else {
                luaState.AddSearchPath(Util.DataPath + "lua");
            }
        }

        /// <summary>
        /// 初始化LuaBundle
        /// </summary>
        void InitLuaBundle() {
            if (luaLoader.beZip) {
                luaLoader.AddBundle("lua/lua.unity3d");
                luaLoader.AddBundle("lua/lua_math.unity3d");
                luaLoader.AddBundle("lua/lua_system.unity3d");
                luaLoader.AddBundle("lua/lua_system_reflection.unity3d");
                luaLoader.AddBundle("lua/lua_unityengine.unity3d");
                luaLoader.AddBundle("lua/lua_common.unity3d");
                luaLoader.AddBundle("lua/lua_logic.unity3d");
                luaLoader.AddBundle("lua/lua_view.unity3d");
                luaLoader.AddBundle("lua/lua_controller.unity3d");
                luaLoader.AddBundle("lua/lua_misc.unity3d");

                luaLoader.AddBundle("lua/lua_protobuf.unity3d");
                luaLoader.AddBundle("lua/lua_3rd_cjson.unity3d");
                luaLoader.AddBundle("lua/lua_3rd_luabitop.unity3d");
                luaLoader.AddBundle("lua/lua_3rd_pbc.unity3d");
                luaLoader.AddBundle("lua/lua_3rd_pblua.unity3d");
                luaLoader.AddBundle("lua/lua_3rd_sproto.unity3d");
            }
        }

        public object[] DoFile(string filename) {
            return luaState.DoFile(filename);
        }

        public void Require(string filename)
        {
            luaState.Require(filename);
        }

        public LuaState GetState()
        {
            return luaState;
        }
        public LuaState GetLuaState()
        {
            return luaState;
        }
		public object[] DoString(string chunk, string chunkName)
		{
			return luaState.DoString(chunk, chunkName);
		}
        // Update is called once per frame
        public object[] CallFunction(string funcName, params object[] args) {
            LuaFunction func = luaState.GetFunction(funcName);
            if (func != null) {
                return func.Call(args);
            }
            else
            {
                Debug.LogWarning("没有找到函数：" + funcName);
            }
            return null;
        }

        public void LuaGC() {
            luaState.LuaGC(LuaGCOptions.LUA_GCCOLLECT);
        }

        public void Close() {
            loop.Destroy();
            loop = null;

            luaState.Dispose();
            luaState = null;
            luaLoader = null;
        }
    }
}