
const { app, screen, Menu, BrowserWindow, ipcMain, nativeTheme } = require('electron')
const Param = require("../../Fragments/Parameters/Parameters.js");

let mainWindow;
app.on('ready', () => {
    const primaryDisplay = screen.getPrimaryDisplay()
    const { width, height } = primaryDisplay.workAreaSize
    mainWindow = new BrowserWindow({
        width: width,
        height: height,
        webPreferences: {
            nodeIntegration: false, enableRemoteModule: true, contextIsolation: false, preload: Param.Parameters.GetAbsoulutePath('../../Module/Login/Login.js')
        }
    })
    mainWindow.webContents.openDevTools()
    mainWindow.loadURL(Param.Parameters.GetAbsoulutePath('../../View/Login/Login.html'))
    nativeTheme.themeSource = 'dark'
    mainWindow.setMenu(null)
});