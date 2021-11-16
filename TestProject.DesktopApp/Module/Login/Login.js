const Param = require("../../Fragments/Parameters/Parameters.js");
const axios = require('axios')
var app = new Vue({
    el: '#loginForm',
    data: {
        username: '',
        password: ''
    },
    methods: {
        IsLogin() {
            if (this.username != "" && this.password != "") {
                let user = {
                    Email: this.username,
                    Password: this.password
                }
                axios
                    .post(Param.Parameters.GetRequestName() + "/User/Login", JSON.stringify(user), {
                        headers: {
                            'Content-Type': 'application/json',
                        }
                    })
                    .then(function (response) {
                        if (response.data) {
                            window.location.href = Param.Parameters.GetAbsoulutePath('../../View/Layout/Layout.html');
                        } else {
                            alert("Kullanıcı adı veya şifreniz hatalıdır!");
                        }
                    })
            }
        }
    }

});