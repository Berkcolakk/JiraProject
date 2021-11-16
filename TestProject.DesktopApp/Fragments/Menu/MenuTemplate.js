const { nativeTheme } = require('electron')

exports.MenuTemplate = new class Parameters {
    Electron = null;
    constructor(Electron) {
        this.Electron = Electron
    }
    Template = [
        {
            label: "Geliştirici Menüsünü Aç", click: (item, focusedWindow) => {
                focusedWindow.toggleDevTools();
            }
        },
        {
            label: "Dark Moda Çevir", click: (item, focusedWindow) => {
                if (nativeTheme.themeSource == 'light') {
                    nativeTheme.themeSource = 'dark'
                } else {
                    nativeTheme.themeSource = 'light'
                }
            }
        }
    ];
}