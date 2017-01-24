﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaFramework_LuaBehaviourWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaFramework.LuaBehaviour), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("AddClick", AddClick);
		L.RegFunction("RemoveClick", RemoveClick);
		L.RegFunction("ClearClick", ClearClick);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("luaComponent", get_luaComponent, set_luaComponent);
		L.RegVar("luaComponentName", get_luaComponentName, set_luaComponentName);
		L.RegVar("luaComponentInst", get_luaComponentInst, set_luaComponentInst);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			LuaFunction arg1 = ToLua.CheckLuaFunction(L, 3);
			obj.AddClick(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaBehaviour));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.RemoveClick(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaFramework.LuaBehaviour));
			obj.ClearClick();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_luaComponent(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, LuaFramework.LuaBehaviour.sLuaComponentName);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_luaComponentName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)o;
			string ret = obj.luaComponentName;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index luaComponentName on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_luaComponentInst(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)o;
			LuaInterface.LuaTable ret = obj.luaComponentTableInst;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index luaComponentInst on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_luaComponent(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			LuaFramework.LuaBehaviour.sLuaComponentName = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_luaComponentName(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.luaComponentName = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index luaComponentName on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_luaComponentInst(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaFramework.LuaBehaviour obj = (LuaFramework.LuaBehaviour)o;
			LuaTable arg0 = ToLua.CheckLuaTable(L, 2);
			obj.luaComponentTableInst = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index luaComponentInst on a nil value" : e.Message);
		}
	}
}

