'use strict';

const container_principal = document.querySelector('.container-principal');
const punto = document.querySelectorAll('.punto');

punto.forEach((cadaPunto, i) => {
    punto[i].addEventListener('click', () =>{

        let position = i;
        let operacion = position * -25;

        container_principal.style.transform = `translateX(${operacion}%)`;

        punto.forEach((cadaPunto, i) =>{
            punto[i].classList.remove('activo');
        });
        
        punto[i].classList.add('activo');
    })
})