function SendNotification(Notificationtitle, NotificationBody, ClickedMsg) {
    new Notification(Notificationtitle, { body: NotificationBody })
        .onclick = () => document.getElementById("output").innerText = ClickedMsg
}
