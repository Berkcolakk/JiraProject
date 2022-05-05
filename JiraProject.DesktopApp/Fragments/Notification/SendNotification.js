exports.Notification = new class Notification {
    ElementID
    constructor(elementID) {
        this.ElementID = elementID;
    }
    NotificationSend(Notificationtitle, NotificationBody, ClickedMsg) {
        new Notification(Notificationtitle, { body: NotificationBody })
            .onclick = () => document.getElementById(this.ElementID).innerText = ClickedMsg
    }
}