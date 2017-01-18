local transform;
--local gameObject;

MessagePanel = {};
local this = MessagePanel;

--启动事件--
function MessagePanel.Awake()
	transform = gameObject.transform;
	

	--transform.position = Vector3.zero;
	this.InitPanel();
	logWarn("Awake lua--->>"..gameObject.name);
	--Util.AddLuaComponent("LuaComTest");
end

--初始化面板--
function MessagePanel.InitPanel()
	this.btnClose = transform:FindChild("Button").gameObject;
end

--单击事件--
function MessagePanel.OnDestroy()
	logWarn("OnDestroy---->>>");
end

