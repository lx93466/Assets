require 'Test'
require 'Test2'
Login = class();
Login.loginBtn = nil;
Login.loginListener = nil;

function Login:Awake()
    print('^^^^^^Awake + '..self.gameObject.name)
	self.loginBtn = self.gameObject.transform:FindChild('OKBtn');
	self.loginListener = self.loginBtn.gameObject:AddComponent(System.Type.GetType('UIEventListener'));
	self.loginListener.onClick = self.OnOKLoginBtn;
end

function Login:Start()
    print('^^^^^^Start')
end

function Login.OnOKLoginBtn(arg)
	print(arg.target.name)
   -- print("OnOKLoginBtn + " .. self.className)
end
return Login;