using UnityEngine;
using LuaInterface;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

namespace LuaFramework {
    public class LuaBehaviour : MonoBehaviour {
        private string data = null;
        private Dictionary<string, LuaFunction> buttons = new Dictionary<string, LuaFunction>();

        public static string sLuaComponentName = "";

        public string luaComponentName = "";

        public LuaTable luaComponentTableInst = null;
        protected void Awake() {
            if (!string.IsNullOrEmpty(sLuaComponentName))
            {
                luaComponentName = sLuaComponentName;
                sLuaComponentName = "";
            }
            else if(string.IsNullOrEmpty(luaComponentName))
            {
                luaComponentName = name;
            }
   
            LuaManager.inst.Require(luaComponentName);
            LuaTable classType = LuaManager.inst.GetTable(luaComponentName);
            if (classType == null) return;

            LuaFunction classNew = classType.GetLuaFunction("New");
            if (classNew == null) return;
          
            object[] rets = classNew.Call(classType, gameObject);
            if (rets.Length != 1) return;

            luaComponentTableInst = (LuaTable)rets[0];
     //       luaComponentTableInst["gameObject"] = gameObject;

            LuaFunction awakeFun = luaComponentTableInst.GetLuaFunction("Awake");
            if (awakeFun != null)
            {
                awakeFun.Call(luaComponentTableInst);
            }
        }

        protected void Start() {
            if (luaComponentTableInst == null) return;
            LuaFunction startFun = luaComponentTableInst.GetLuaFunction("Start");
            if (startFun != null)
            {
                startFun.Call(luaComponentTableInst);
            }
          //  Util.CallMethod(luaComponentName, "Start");
        }

        protected void OnClick() {
            Util.CallMethod(luaComponentName, "OnClick");
        }

        protected void OnClickEvent(GameObject go) {
            Util.CallMethod(luaComponentName, "OnClick", go);
        }

        /// <summary>
        /// 添加单击事件
        /// </summary>
        public void AddClick(GameObject go, LuaFunction luafunc) {
            if (go == null || luafunc == null) return;
            buttons.Add(go.name, luafunc);
            go.GetComponent<Button>().onClick.AddListener(
                delegate() {
                    luafunc.Call(go);
                }
            );
        }

        /// <summary>
        /// 删除单击事件
        /// </summary>
        /// <param name="go"></param>
        public void RemoveClick(GameObject go) {
            if (go == null) return;
            LuaFunction luafunc = null;
            if (buttons.TryGetValue(go.name, out luafunc)) {
                luafunc.Dispose();
                luafunc = null;
                buttons.Remove(go.name);
            }
        }

        /// <summary>
        /// 清除单击事件
        /// </summary>
        public void ClearClick() {
            foreach (var de in buttons) {
                if (de.Value != null) {
                    de.Value.Dispose();
                }
            }
            buttons.Clear();
        }

        //-----------------------------------------------------------------
//        protected void OnDestroy() {
//            ClearClick();
//#if ASYNC_MODE
//            string abName = name.ToLower().Replace("panel", "");
//            Main.resourceManager.UnloadAssetBundle(abName + AppConst.ExtName);
//#endif
//            Util.ClearMemory();
//            Debug.Log("~" + name + " was destroy!");
//        }
    }
}