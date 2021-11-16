exports.MenuTemplate = new class Parameters {
    Template = [
        {
            label: "Geliştirici Menüsünü Aç", click: (item, focusedWindow) => {
                focusedWindow.toggleDevTools();
            }
        }
    ];
}
