local UILogic = require 'UI/UILogic'
--主入口函数。从这里开始lua逻辑
require 'Logic/Game'
function Main()					
	local uiGo = UnityEngine.GameObject.Find('Canvas');
	Util.AddLuaComponent(uiGo, UILogic);
end

--场景切换通知
function OnLevelWasLoaded(level)
	Time.timeSinceLevelLoad = 0
end