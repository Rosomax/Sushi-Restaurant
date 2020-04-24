// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$("#StartMenu").click(function () {
    $('html, body').animate({
        scrollTop: '0px',
    }, 1100);
});



$("#KontaktMenu").click(function () {
    $('html, body').animate({
        scrollTop: '1100px',
    }, 1100);
});

$("#DostawaMenu").click(function () {
    $('html, body').animate({
        scrollTop: '1800px',
    }, 1100);
});

$("#OpinieMenu").click(function () {
    $('html, body').animate({
        scrollTop: '2300px',
    }, 1100);
});

$("#Onas").click(function ToggleMenu() {

    x = document.getElementsByClassName("spanContent")[0];

    if (x.style.height == "0px") {
        $('#description').animate({
            height: '50vh',
            padding: '10px',
        }, 1500);
    }
    else {
        $('#description').animate({
            height: '0px',
            padding: '0px',
        }, 1500);
    }
});

/// Opinion JS
const spnText = document.querySelector('.text');
const spnCursor = document.querySelector('.cursor');
const txt = ['Zawsze chętnie tu wracam Janek', 'Lepszego sushi nie jadłem Marek', 'Jeżeli nachodzi mnie ochota na sushi to zawsze wiem gdzie jechać Mariusz']

let activeLetter = -15;
let activeText = 0;


// Implementacja
const addLetter = () => {
    if (activeLetter >= 0) {
        spnText.textContent += txt[activeText][activeLetter];
    }
    activeLetter++;
    if (activeLetter === txt[activeText].length) {

        activeText++;
        if (activeText === txt.length) return;

        return setTimeout(() => {
            activeLetter = -15;
            spnText.textContent = '';
            addLetter();
        }, 2000)


    }
    setTimeout(addLetter, 100)

}


addLetter(); //pierwsze wywołanie


// Animacja kursora
const cursorAnimation = () => {
    spnCursor.classList.toggle('active');
}
setInterval(cursorAnimation, 400);