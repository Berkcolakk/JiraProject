const path = require('path')
exports.Parameters = new class Parameters {
    GetRequestName() {
        debugger;
        return process.env.REQUEST_URL;
    }
    Version() {
        return process.env.VERSION;
    }
    ApplicationType() {
        return (process.env.APPLICATION_TYPE == "DEVELOPMENT") ? true : false;
    }
    GetAbsoulutePath(param) {
        return path.join(__dirname, param)
    }
}