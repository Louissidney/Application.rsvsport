const { app, BrowserWindow, ipcMain } = require('electron');
const { db, registerUser, loginUser } = require('./database.js');
const path = require('path');

let mainWindow;

// Créer la fenêtre principale
app.whenReady().then(() => {
    mainWindow = new BrowserWindow({
        width: 1500,
        height: 900,
        webPreferences: {
            nodeIntegration: false,  // Désactivation de nodeIntegration pour des raisons de sécurité
            contextIsolation: true,  // Activation de contextIsolation pour sécuriser le contexte
            preload: path.join(__dirname, 'preload.js')  // Chargement du fichier preload.js
        },
    });

    mainWindow.loadFile('index.html');


    // Fermer l'application lorsque toutes les fenêtres sont fermées
    app.on('window-all-closed', () => {
        if (process.platform !== 'darwin') {
            app.quit();
        }
    });
});

// Gérer l'activation de l'application sur macOS (pour rouvrir une fenêtre si nécessaire)
app.on('activate', () => {
    if (BrowserWindow.getAllWindows().length === 0) {
        app.whenReady().then(() => {
            mainWindow = new BrowserWindow({
                width: 1500,
                height: 900,
                webPreferences: {
                    nodeIntegration: false,
                    contextIsolation: true,
                    preload: path.join(__dirname, 'preload.js')
                },
            });
            mainWindow.loadFile('index.html');
        });
    }
});

// Événements pour la gestion de la connexion et de l'inscription
ipcMain.on('login-user', (event, credentials) => {
    loginUser(credentials.email, credentials.password, (err, user) => {
        if (err || !user) {
            event.reply('login-failed', 'Email ou mot de passe incorrect');
        } else {
            event.reply('login-success', user);
        }
    });
});

ipcMain.on('register-user', (event, userData) => {
    const { name, email, password } = userData;
    registerUser(name, email, password, (err, userId) => {
        if (err) {
            event.reply('register-failed', err.message);
        } else {
            event.reply('register-success', userId);
        }
    });
});

// Fermeture de l'application
app.on('window-all-closed', () => {
    if (process.platform !== 'darwin') {
        app.quit();
    }
});

app.on('activate', () => {
    if (BrowserWindow.getAllWindows().length === 0) {
        createWindow();
    }
});

ipcMain.on('go-to-accueil', () => {
    if (mainWindow) {
        const fs = require('fs');
        const path = require('path');
        const accueilPath = path.join(__dirname, 'accueil.html');

        // Vérifie si le fichier existe avant de charger
        if (fs.existsSync(accueilPath)) {
            console.log("🔁 Redirection via main vers accueil.html");
            mainWindow.loadFile(accueilPath);
        } else {
            console.warn("⚠️ accueil.html non trouvé. Vérifie le chemin.");
        }
    } else {
        console.error("❌ mainWindow non initialisé !");
    }
});
