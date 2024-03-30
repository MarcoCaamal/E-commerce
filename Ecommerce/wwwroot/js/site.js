document.addEventListener('DOMContentLoaded', () => {
    initApp();
});

/* GLOBAL */
const menuBtn = document.querySelector('i.menu__btn');
const menuBtnX = document.querySelector('i.menu__btn--x');

const navbarResponsive = document.querySelector('.bar__responsive-menu');

function initApp() {
    initMenuBtn();
    addResizeEvent();
}

function addResizeEvent() {
    window.addEventListener('resize', (e) => {
        if (e.target.innerWidth == 768) {
            menuBtn.style.display = 'none';
            menuBtnX.style.display = 'none';

        }  

        if (e.target.innerWidth < 768) {
            menuBtn.style.display = null;
            menuBtnX.style.display = null;

            if (!navbarResponsive.classList.contains('mostrar')) return;

            navbarResponsive.classList.remove('mostrar');
        }

        
    });
}

function initMenuBtn() {
    menuBtn.addEventListener('click', () => {
        menuBtn.style.display = 'none';
        menuBtnX.style.display = 'block';
        showOrHiddenMenuResponsive();
    });
    menuBtnX.addEventListener('click', () => {
        menuBtn.style.display = 'block';
        menuBtnX.style.display = 'none';
        showOrHiddenMenuResponsive();
    });
}

function showOrHiddenMenuResponsive() {
    navbarResponsive.classList.toggle('mostrar');
}