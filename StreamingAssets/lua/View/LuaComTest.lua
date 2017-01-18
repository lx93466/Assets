LuaComTest = {}
function LuaComTest.Awake()	
	logWarn("******************************Lua Component Test Awake");
	local open = gameObject.transform.FindChild('TestBtn');
	local listener = Util.AddComponent(open, "UIEventListener");
	listener.onClick = LuaComTest.OnClick;
end

function LuaComTest.Start()	
	logWarn("******************************Lua Component Test Start");
end

function LuaComTest.OnClick(data)
	logWarn("Clicked " .. data.gameObject.name);
end