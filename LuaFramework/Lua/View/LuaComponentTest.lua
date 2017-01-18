--region *.lua
--Date
--此文件由[BabeLua]插件自动生成
local  LuaComponentTest = {name = "test"};
function LuaComponentTest:new(obj)
        local o = {}
       setmetatable(o, self)  
       self.__index = self  
      return o
end  

function LuaComponentTest:Awake()
        print("LuaComponentTest Awake name = "..self.name );
end
function LuaComponentTest:Start()
        print("LuaComponentTest Start name = "..self.name );
end
return LuaComponentTest
--endregion
