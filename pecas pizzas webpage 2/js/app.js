// Función para el cambio de vista para las opciones del navbar
function mostrarSeccion(idSeleccion){

    // Oculta todas las secciones
    const secciones = document.querySelectorAll('.seccion');
    secciones.forEach(sec => sec.classList.remove('activa'));

    // Pone a la vista el loader (spinner)
    document.querySelector('.loader').style.display = "block";

    setTimeout(() =>{
        // Muestra la seccion seleccionada
        document.getElementById(idSeleccion).classList.add('activa');

        document.querySelector('.loader').style.display = "none";
    }, 1500);

}

// Cambio de foco a la hora de hacer scroll en el menu
const itemsMenu = document.querySelectorAll(".item");

window.addEventListener("scroll", () => {
    
    itemsMenu.forEach((cadaItem, i) => {
        cadaItem.classList.remove('enfocar');
        cadaItem.style.color = "#000000";
    });

    if(window.scrollY <= 1211){
        itemsMenu[0].style.color = "#fff";
        itemsMenu[0].classList.add('enfocar');
    } else if (window.scrollY <= 2212){
        itemsMenu[1].style.color = "#fff";
        itemsMenu[1].classList.add('enfocar');
    } else if (window.scrollY <= 3213){
        itemsMenu[2].style.color = "#fff";
        itemsMenu[2].classList.add('enfocar');
    } else if (window.scrollY <= 4210){
        itemsMenu[3].style.color = "#fff";
        itemsMenu[3].classList.add('enfocar');
    } else {
        itemsMenu[4].style.color = "#fff";
        itemsMenu[4].classList.add('enfocar');
    }
    
})