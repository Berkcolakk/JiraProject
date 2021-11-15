const Param = require("../../Fragments/Parameters/Parameters.js");
document.onreadystatechange = function () {
    if (document.readyState == 'complete') {
        const electron = require('electron');
        const BrowserWindow = electron.remote.BrowserWindow;
        const path = require('path')
        const loginBtn = document.getElementById("btnSubmit")
        loginBtn.addEventListener("click", function () {
            let userName = document.getElementById("txtUserName").value;
            let password = document.getElementById("txtPassword").value;
            if (userName != "" && password != "") {
                let user = {
                    Email: userName,
                    Password: password
                }
                let xmlHttp = new XMLHttpRequest();
                xmlHttp.open("POST", Param.Parameters.GetRequestName() + "/User/Login", true);
                xmlHttp.setRequestHeader("Content-type", "application/json");
                xmlHttp.send(JSON.stringify(user));
                xmlHttp.onreadystatechange = function () {
                    if (xmlHttp.readyState == 4 && xmlHttp.status == 200) {
                        debugger;
                        if (xmlHttp.responseText == "true") {
                            let options = {
                                width: 800,
                                height: 500,
                                webPreferences: {
                                    preload: Param.Parameters.GetAbsoulutePath('../../Module/Login/Login.js'),
                                    nodeIntegration: true
                                }
                            }
                            BrowserWindow.loadURL(Param.Parameters.GetAbsoulutePath('../../View/Layout/Layout.html'));
                            const win = new BrowserWindow(options);
                            win.loadURL(Param.Parameters.GetAbsoulutePath('../../View/Layout/Layout.html'));
                        } else {
                            alert("Kullanıcı adı veya şifreniz hatalıdır!");
                        }
                    }
                }
            }
        })
    }
}