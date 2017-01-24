--region *.lua
local base_class = {};
base_class.gameObject = nil;
base_class.className = "base_class"
function  base_class:New(obj)
    local new_class = {};
    setmetatable(new_class, self);
    self.__index = self;
    new_class.gameObject = obj;
    if obj ~= nil then
        print("******************base_class.New() + " .. obj.name)
    end
    return new_class;
end
--function  base_class.New()
--     print("******************base_class.New()")
--    local new_class = {};
--    return new_class;
--end

function class(parent)
    local new_class = {};
    local t = type(parent);
   
    if t == 'table' then
        print("******************parent")
        setmetatable(new_class, parent);
        new_class.__index = parent;
    else
        print("******************base_class")
        new_class = base_class:New();
    end
   -- print("******************gameObject + " .. new_class.gameObject.name)
    return new_class;
end
--endregion
