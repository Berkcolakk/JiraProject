const { app, screen, Menu, BrowserWindow, ipcMain, nativeTheme } = require('electron')
const path = require('path')


function createWindow() {
    const primaryDisplay = screen.getPrimaryDisplay()
    const { width, height } = primaryDisplay.workAreaSize
    const win = new BrowserWindow({
        width: width ,
        height: height
    })
    win.webContents.openDevTools()
    win.loadFile(path.join(__dirname, '../../View/Login/Login.html'))
    nativeTheme.themeSource = 'dark'
    //const INCREMENT = 0.03
    //const INTERVAL_DELAY = 100 // ms
    //let progressInterval
    //let c = 0
    //progressInterval = setInterval(() => {
    //    // update progress bar to next value
    //    // values between 0 and 1 will show progress, >1 will show indeterminate or stick at 100%
    //    win.setProgressBar(c)

    //    // increment or reset progress bar
    //    if (c < 2) {
    //        c += INCREMENT
    //    } else {
    //        c = (-INCREMENT * 5) // reset to a bit less than 0 to show reset state
    //    }
    //}, INTERVAL_DELAY)
    win.setMenu(null)
    
}

app.whenReady().then(() => {
    createWindow()
    app.on('activate', () => {
        if (BrowserWindow.getAllWindows().length === 0) {
            createWindow()
        }
    })
    ipcMain.on('error-in-window', function (event, data) {
        console.log(data);
    });
})

app.on('window-all-closed', () => {
    if (process.platform !== 'darwin') {
        app.quit()
    }
})