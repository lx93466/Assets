using UnityEngine;
using System.Collections;
using LuaInterface;
using LuaFramework;
public class LuaComponent : MonoBehaviour
{
    public static LuaTable sLuaTable = null;
    public LuaTable luaTable = null;
    void Awake()
    {
        luaTable = sLuaTable;
        LuaFunction fun = luaTable.GetLuaFunction("Awake");
        if (fun != null)
        {
            LuaManager.inst.AddArgToLua("gameObject", gameObject);
            fun.Call(luaTable);
        }    
    }
	// Use this for initialization
	void Start () {
        LuaFunction fun = luaTable.GetLuaFunction("Start");
        if (fun != null)
        {
            fun.Call(luaTable);
        }    
	}
}
