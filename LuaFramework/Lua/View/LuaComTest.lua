LuaComTest = {}
function LuaComTest.Awake()
	logWarn("******************************Lua Component Test Awake");
	local go = UnityEngine.GameObject ('go')
	go:AddComponent(System.Type.GetType('UIEventListener'))
	go:AddComponent(System.Type.GetType('UnityEngine.Animation, UnityEngine'))
	--go:AddComponent(System.Type.GetType('UnityEngine.UI.Button, UnityEngine.UI'))
	local listener = gameObject:AddComponent(System.Type.GetType('UIEventListener'))
	print(gameObject.transform.name)

	
end

function LuaComTest.Start()
	logWarn("******************************Lua Component Test Start");
	local tran = gameObject.transform:FindChild("TestBtn");
	local listener = tran.gameObject:AddComponent(System.Type.GetType('UIEventListener'));
	listener.onClick = LuaComTest.OnClick;
end

function LuaComTest.OnClick(data)
	logWarn("Clicked:"..data.target.name..":"..data.clickedPosition.x);
end