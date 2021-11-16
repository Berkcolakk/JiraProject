const Param = require("../../Fragments/Parameters/Parameters.js");

var app = new Vue({
    el: '#btnLogin',
    methods: {
        IsLogin() {
            debugger;
            window.location.href = Param.Parameters.GetAbsoulutePath('../../View/Layout/Layout.html');
        }
    }

});