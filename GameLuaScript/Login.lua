local Login = {}

function Login:New()
	local o = {}
    setmetatable(o, self)  
    self.__index = self  
    return o
end

function Login.Awake()
    print('Awake')
	self.loginBtn = gameObject.transform:FindChild('OKBtn');
	self.loginListener = dself.loginBtn.gameObject:AddComponent(System.Type.GetType('UIEventListener'));
	self.loginListener.onClicked = Login.OnOKLoginBtn;
end

function Login.OnOKLoginBtn(arg)
	print(arg.target.name)
end
return Login;