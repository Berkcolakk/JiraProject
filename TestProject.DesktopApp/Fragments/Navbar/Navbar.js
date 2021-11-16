const Param = require("../../Fragments/Parameters/Parameters.js");

document.onreadystatechange = function () {
    if (document.readyState == 'complete') {
        let xmlHttp = new XMLHttpRequest();
        xmlHttp.open("POST", Param.Parameters.GetRequestName() + "/Menus/GetAllMenus", true);
        xmlHttp.setRequestHeader("Content-type", "application/json");
        xmlHttp.send(JSON.stringify(user));
        xmlHttp.onreadystatechange = function () {
            if (xmlHttp.readyState == 4 && xmlHttp.status == 200) {
                debugger;
                if (xmlHttp.responseText == "true") {
                    window.location.href = Param.Parameters.GetAbsoulutePath('../../View/Layout/Layout.html');
                } else {
                    alert("Kullanıcı adı veya şifreniz hatalıdır!");
                }
            }
        }
    }
})