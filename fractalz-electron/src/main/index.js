import {app, BrowserWindow, Tray} from 'electron'
const nativeImage = require('electron').nativeImage
import '../renderer/store'
import { ipcMain } from "electron";
ipcMain.on('flash-noty', (event, data) => {
  mainWindow.flashFrame(true);
})
/**
 * Set `__static` path to static files in production
 * https://simulatedgreg.gitbooks.io/electron-vue/content/en/using-static-assets.html
 */
if (process.env.NODE_ENV !== 'development') {
  global.__static = require('path').join(__dirname, '/static').replace(/\\/g, '\\\\')
}

let mainWindow
const winURL = process.env.NODE_ENV === 'development'
  ? `http://localhost:9080`
  : `file://${__dirname}/index.html`


function createWindow () {
  /**
   * Initial window options
   */
  mainWindow = new BrowserWindow({
    width: 526,
    height: 742,
    minWidth : 386,
    minHeight : 360,
    useContentSize: true,
    resizable: true,
    autoHideMenuBar: true,
    // Here
  })


  var iconc = nativeImage.createFromPath('../renderer/assets/images/logo-img.png');
  console.log("ICON");
  mainWindow.setIcon(iconc);
  // new Tray('.//renderer/images/logo-img.ico')

  mainWindow.loadURL(winURL)

  mainWindow.on('closed', () => {
    mainWindow = null
  })

}

app.on('ready', createWindow)

app.on('window-all-closed', () => {
  if (process.platform !== 'darwin') {
    app.quit()
  }
})

app.on('activate', () => {
  if (mainWindow === null) {
    createWindow()
  }
})

