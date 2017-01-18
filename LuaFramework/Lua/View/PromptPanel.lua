require 'View/LuaComTest'
local  com = require 'View/LuaComponentTest'
PromptPanel = {};

function PromptPanel:new()
	local o = {}
	setmetatable(o, self)
	self.__index = self
	logWarn("**********************************************Awake lua--->> PromptPanel:new()");
	return o
end

--启动事件--
function PromptPanel:Awake()
	self.transform = gameObject.transform;
	PromptPanel.InitPanel(self);
	logWarn("**********************************************Awake lua--->>"..gameObject.name);
	logWarn("**********************************************Awake lua--->>"..com.name);
	--Util.AddLuaComponent(transform, "LuaComTest");
	local compo = Util.AddLuaComponent(transform, com);
	compo.name = "LuaAdd"
end

--初始化面板--
--成员方法
function PromptPanel:InitPanel()
	self.btnOpen = self.transform:FindChild("Open").gameObject;
	self.testBtn = self.transform:FindChild("TestBtn").gameObject;
	local listener = self.testBtn:AddComponent(System.Type.GetType('UIEventListener'));
	listener.onClick = PromptPanel.OnClick
	self.gridParent = self.transform:FindChild('ScrollView/Grid');
end
--委托必须是静态方法
function PromptPanel.OnClick(args)
	log("&&&&&&&&&&&&&&"..self.transform.name);
end
--单击事件--
function PromptPanel:OnDestroy()
	logWarn("OnDestroy---->>>");
end