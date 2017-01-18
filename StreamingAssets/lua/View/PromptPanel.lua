require 'View/LuaComTest'
local transform;
--local gameObject;

PromptPanel = {};
local this = PromptPanel;

--启动事件--
function PromptPanel.Awake()
	transform = gameObject.transform;

	this.InitPanel();
	logWarn("**********************************************Awake lua--->>"..gameObject.name);
	Util.AddLuaComponent(transform, "LuaComTest");
end

--初始化面板--
function PromptPanel.InitPanel()
	this.btnOpen = transform:FindChild("Open").gameObject;
	this.gridParent = transform:FindChild('ScrollView/Grid');
end

--单击事件--
function PromptPanel.OnDestroy()
	logWarn("OnDestroy---->>>");
end