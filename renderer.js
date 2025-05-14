// ==============================
// Déclarations globales
// ==============================
let countdownInterval = null;

// ==============================
// Récupère les éléments du DOM
// ==============================
const loginForm = document.getElementById('login-form');
const registerLink = document.getElementById('register-link');
const registerFormContainer = document.getElementById('register-form-container');
const backToLoginLink = document.getElementById('back-to-login');
const registerForm = document.getElementById('register-form');
const registerErrorMessage = document.getElementById('register-error-message');
const errorMessage = document.getElementById('error-message');
const welcomeContainer = document.getElementById('welcome-container');
const welcomeMessage = document.getElementById('welcome-message');
const userPointsBanner = document.getElementById('user-points'); // ⚠️ Peut être null ici

// ==============================
// Formulaire de connexion
// ==============================
loginForm.addEventListener('submit', (event) => {
    event.preventDefault();
    errorMessage.textContent = '';
    const email = document.getElementById('email').value;
    const password = document.getElementById('password').value;
    window.electron.loginUser({ email, password });
});

// ==============================
// Navigation vers formulaire d'inscription
// ==============================
registerLink.addEventListener('click', () => {
    document.querySelector('.login-container').classList.add('hidden');
    registerFormContainer.classList.remove('hidden');
});

// ==============================
// Retour au formulaire de connexion
// ==============================
backToLoginLink.addEventListener('click', (event) => {
    event.preventDefault();
    document.querySelector('.login-container').classList.remove('hidden');
    document.getElementById('register-section').classList.remove('hidden');
    registerFormContainer.classList.add('hidden');

    setTimeout(() => {
        const emailInput = document.getElementById('email');
        if (emailInput) {
            emailInput.focus();
        }

        const forceRepaint = document.createElement('div');
        forceRepaint.style.position = 'absolute';
        forceRepaint.style.top = '-9999px';
        document.body.appendChild(forceRepaint);
        requestAnimationFrame(() => {
            document.body.removeChild(forceRepaint);
        });
    }, 50);
});

// ==============================
// Soumission du formulaire d'inscription
// ==============================
registerForm.addEventListener('submit', (event) => {
    event.preventDefault();
    const name = document.getElementById('register-name').value;
    const email = document.getElementById('register-email').value;
    const password = document.getElementById('register-password').value;
    window.electron.registerUser({ name, email, password });
});

// ==============================
// Succès de l'inscription
// ==============================
window.electron.onRegisterSuccess((event, userId) => {
    alert('Inscription réussie !');
    if (countdownInterval) clearInterval(countdownInterval);

    const countdownElement = document.getElementById("countdown");
    if (countdownElement) countdownElement.remove();

    document.getElementById('email').disabled = false;
    document.getElementById('password').disabled = false;

    document.querySelector('.login-container').classList.remove('hidden');
    document.getElementById('login-form').style.display = 'block';
    document.getElementById('register-section').classList.remove('hidden');
    registerFormContainer.classList.add('hidden');

    setTimeout(() => {
        const emailInput = document.getElementById('email');
        if (emailInput) emailInput.focus();
    }, 50);
});

// ==============================
// Succès de la connexion
// ==============================
window.electron.onLoginSuccess((event, user) => {
    afficherBienvenue(user);
});

// ==============================
// Fonction pour afficher message + points + redirection
// ==============================
function afficherBienvenue(user) {
    console.log("✅ afficherBienvenue lancé !");
    localStorage.setItem('user', JSON.stringify(user));

    // 🔁 Redirection immédiate vers accueil.html
    window.location.href = "accueil.html";
}


// ==============================
// Échec de la connexion
// ==============================
window.electron.onLoginFailed((event, message) => {
    errorMessage.textContent = message;
    errorMessage.classList.add('shake');

    setTimeout(() => {
        errorMessage.classList.remove('shake');
    }, 600);
});

// ==============================
// DOM Ready : Vérification
// ==============================
document.addEventListener("DOMContentLoaded", () => {
    console.log("✅ Script chargé et DOM prêt !");
});
