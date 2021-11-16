const { app, screen, Menu, BrowserWindow, ipcMain, nativeTheme } = require('electron')
const Parameters = require("../../Fragments/Parameters/Parameters.js");
const menuTemplate = require("../../Fragments/Menu/MenuTemplate.js");

let  mainWindow;
app.on('ready', () => {
    /* Initiliaze Screen */
    const primaryDisplay = screen.getPrimaryDisplay()
    const { width, height } = primaryDisplay.workAreaSize
    mainWindow = new BrowserWindow({
        width: width,
        height: height,
        webPreferences: {
            nodeIntegration: true,
            nodeIntegrationInWorker: true,
            enableRemoteModule: true,
            contextIsolation: false
        }
    })
    mainWindow.loadURL(Parameters.Parameters.GetAbsoulutePath('../../View/Login/Login.html'))
    /* Initiliaze Screen */

    /* Initiliaze Menu */
    const mainMenu = Menu.buildFromTemplate(menuTemplate.MenuTemplate.Template);
    Menu.setApplicationMenu(mainMenu);
    /* Initiliaze Menu */

    /*All Functions*/
    //Login Redirect..
    ipcMain.on("LoginRedirectToMain", (err, data) => {
        mainWindow.loadURL(LoginRedirectToMainPage());
    })
    //Login Redirect..

    /*All Functions*/
});
function LoginRedirectToMainPage() {
    return Parameters.Parameters.GetAbsoulutePath('../../View/Layout/Layout.html');
}
