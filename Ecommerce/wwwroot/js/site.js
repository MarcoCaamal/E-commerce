document.addEventListener('DOMContentLoaded', () => {
    initApp();
});

function initApp() {
    initMenuBtn();
}

function initMenuBtn() {
    const menuBtn = document.querySelector('i.menu__btn');
    const menuBtnX = document.querySelector('i.menu__btn--x');

    const btnCategories = document.querySelector('.categories');
    const searchBar = document.querySelector('.search-bar');
    const navbar = document.querySelector('.navbar');

    menuBtn.addEventListener('click', () => {
        menuBtn.style.display = 'none';
        menuBtnX.style.display = 'block';
        btnCategories.classList.remove('d-none');
        searchBar.classList.remove('d-none');
        navbar.classList.remove('d-none');
    });

    menuBtnX.addEventListener('click', () => {
        menuBtn.style.display = 'block';
        menuBtnX.style.display = 'none';
        btnCategories.classList.add('d-none');
        searchBar.classList.add('d-none');
        navbar.classList.add('d-none');
    });
}