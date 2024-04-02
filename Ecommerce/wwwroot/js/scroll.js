
document.addEventListener('DOMContentLoaded', () => {
    initApp();
});
function initApp() {
    initScrollCategories();
}
function initScrollCategories() {
    let activeDrag = false;
    const categoriesList = document.querySelector('.categories__list');
    categoriesList.addEventListener('mousemove', (drag) => {
        if (!activeDrag) return;
        categoriesList.scrollLeft -= drag.movementX;
    });

    document.addEventListener('mouseup', () => {
        activeDrag = false;
    });

    categoriesList.addEventListener('mousedown', () => {
        activeDrag = true;

    });
}