const Param = require("../../Fragments/Parameters/Parameters.js");

document.onreadystatechange = function () {
    if (document.readyState == 'complete') {
        const loginBtn = document.getElementById("btnSubmit")
        loginBtn.addEventListener("click", function () {
            window.location.href = Param.Parameters.GetAbsoulutePath('../../View/Layout/Layout.html');
            //let userName = document.getElementById("txtUserName").value;
            //let password = document.getElementById("txtPassword").value;
            //if (userName != "" && password != "") {
            //    let user = {
            //        Email: userName,
            //        Password: password
            //    }
            //    let xmlHttp = new XMLHttpRequest();
            //    xmlHttp.open("POST", Param.Parameters.GetRequestName() + "/User/Login", true);
            //    xmlHttp.setRequestHeader("Content-type", "application/json");
            //    xmlHttp.send(JSON.stringify(user));
            //    xmlHttp.onreadystatechange = function () {
            //        if (xmlHttp.readyState == 4 && xmlHttp.status == 200) {
            //            debugger;
            //            if (xmlHttp.responseText == "true") {
            //                window.location.href = Param.Parameters.GetAbsoulutePath('../../View/Layout/Layout.html');
            //            } else {
            //                alert("Kullanıcı adı veya şifreniz hatalıdır!");
            //            }
            //        }
            //    }
            //}
        })
    }
}
