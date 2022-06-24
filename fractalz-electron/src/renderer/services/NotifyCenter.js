import notifier from 'node-notifier';

export default class NotifyCenter {
    Show(notifyObject, optionsWindow = null)
    {
        new notifier.WindowsBalloon(optionsWindow).notify(notifyObject);
    }
}
