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

        public static string luaComponent = "";

        public string luaComponentName = "";

        public LuaTable luaComponentInst = null;
        protected void Awake() {
           // luaComponentName = luaComponent;
            Main.luaManager.DoFile(luaComponentName);
			LuaManager.inst.AddArgToLua ("gameObject", gameObject);
            Util.CallMethod(luaComponentName, "Awake");
        }

        protected void Start() {
            Util.CallMethod(luaComponentName, "Start");
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