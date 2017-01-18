﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UIEventListenerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UIEventListener), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("OnPointerClick", OnPointerClick);
		L.RegFunction("OnPointerDown", OnPointerDown);
		L.RegFunction("OnPointerUp", OnPointerUp);
		L.RegFunction("OnBeginDrag", OnBeginDrag);
		L.RegFunction("OnDrag", OnDrag);
		L.RegFunction("OnEndDrag", OnEndDrag);
		L.RegFunction("OnDrop", OnDrop);
		L.RegFunction("OnScroll", OnScroll);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("onClick", get_onClick, set_onClick);
		L.RegVar("onClickUp", get_onClickUp, set_onClickUp);
		L.RegVar("onClickDown", get_onClickDown, set_onClickDown);
		L.RegVar("onBeginDrag", get_onBeginDrag, set_onBeginDrag);
		L.RegVar("onDrag", get_onDrag, set_onDrag);
		L.RegVar("onEndDrag", get_onEndDrag, set_onEndDrag);
		L.RegVar("onDrop", get_onDrop, set_onDrop);
		L.RegVar("onScroll", get_onScroll, set_onScroll);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIEventListener obj = (UIEventListener)ToLua.CheckObject(L, 1, typeof(UIEventListener));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnPointerClick(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerDown(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIEventListener obj = (UIEventListener)ToLua.CheckObject(L, 1, typeof(UIEventListener));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnPointerDown(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerUp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIEventListener obj = (UIEventListener)ToLua.CheckObject(L, 1, typeof(UIEventListener));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnPointerUp(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnBeginDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIEventListener obj = (UIEventListener)ToLua.CheckObject(L, 1, typeof(UIEventListener));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnBeginDrag(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIEventListener obj = (UIEventListener)ToLua.CheckObject(L, 1, typeof(UIEventListener));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnDrag(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnEndDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIEventListener obj = (UIEventListener)ToLua.CheckObject(L, 1, typeof(UIEventListener));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnEndDrag(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrop(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIEventListener obj = (UIEventListener)ToLua.CheckObject(L, 1, typeof(UIEventListener));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnDrop(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnScroll(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIEventListener obj = (UIEventListener)ToLua.CheckObject(L, 1, typeof(UIEventListener));
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.OnScroll(arg0);
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
	static int get_onClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UIEventParam> ret = obj.onClick;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onClick on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onClickUp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UIEventParam> ret = obj.onClickUp;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onClickUp on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onClickDown(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UIEventParam> ret = obj.onClickDown;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onClickDown on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onBeginDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UIEventParam> ret = obj.onBeginDrag;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onBeginDrag on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UIEventParam> ret = obj.onDrag;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onDrag on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onEndDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UIEventParam> ret = obj.onEndDrag;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onEndDrag on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDrop(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UIEventParam> ret = obj.onDrop;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onDrop on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onScroll(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UnityEngine.Vector2> ret = obj.onScroll;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onScroll on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UIEventParam> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction<UIEventParam>)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction<UIEventParam>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UIEventParam>), func) as UnityEngine.Events.UnityAction<UIEventParam>;
			}

			obj.onClick = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onClick on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onClickUp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UIEventParam> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction<UIEventParam>)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction<UIEventParam>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UIEventParam>), func) as UnityEngine.Events.UnityAction<UIEventParam>;
			}

			obj.onClickUp = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onClickUp on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onClickDown(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UIEventParam> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction<UIEventParam>)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction<UIEventParam>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UIEventParam>), func) as UnityEngine.Events.UnityAction<UIEventParam>;
			}

			obj.onClickDown = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onClickDown on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onBeginDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UIEventParam> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction<UIEventParam>)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction<UIEventParam>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UIEventParam>), func) as UnityEngine.Events.UnityAction<UIEventParam>;
			}

			obj.onBeginDrag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onBeginDrag on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UIEventParam> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction<UIEventParam>)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction<UIEventParam>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UIEventParam>), func) as UnityEngine.Events.UnityAction<UIEventParam>;
			}

			obj.onDrag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onDrag on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onEndDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UIEventParam> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction<UIEventParam>)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction<UIEventParam>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UIEventParam>), func) as UnityEngine.Events.UnityAction<UIEventParam>;
			}

			obj.onEndDrag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onEndDrag on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDrop(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UIEventParam> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction<UIEventParam>)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction<UIEventParam>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UIEventParam>), func) as UnityEngine.Events.UnityAction<UIEventParam>;
			}

			obj.onDrop = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onDrop on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onScroll(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			UnityEngine.Events.UnityAction<UnityEngine.Vector2> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction<UnityEngine.Vector2>)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction<UnityEngine.Vector2>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UnityEngine.Vector2>), func) as UnityEngine.Events.UnityAction<UnityEngine.Vector2>;
			}

			obj.onScroll = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onScroll on a nil value" : e.Message);
		}
	}
}
