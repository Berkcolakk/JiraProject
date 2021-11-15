const { app, BrowserWindow, ipcMain, nativeTheme } = require('electron')
const path = require('path')


function createWindow() {
    const win = new BrowserWindow({
        width: 800,
        height: 600,
        webPreferences: {
            preload: path.join(__dirname, 'preload.js')
        }
    })
    win.loadFile(path.join(__dirname, '../../View/Index/index.html'))
    nativeTheme.themeSource = 'dark'
    const INCREMENT = 0.03
    const INTERVAL_DELAY = 100 // ms

    let c = 0
    progressInterval = setInterval(() => {
        // update progress bar to next value
        // values between 0 and 1 will show progress, >1 will show indeterminate or stick at 100%
        win.setProgressBar(c)

        // increment or reset progress bar
        if (c < 2) {
            c += INCREMENT
        } else {
            c = (-INCREMENT * 5) // reset to a bit less than 0 to show reset state
        }
    }, INTERVAL_DELAY)
}
let progressInterval

app.whenReady().then(() => {
    createWindow()

    app.on('activate', () => {
        if (BrowserWindow.getAllWindows().length === 0) {
            createWindow()
        }
    })
})

app.on('window-all-closed', () => {
    if (process.platform !== 'darwin') {
        app.quit()
    }
})