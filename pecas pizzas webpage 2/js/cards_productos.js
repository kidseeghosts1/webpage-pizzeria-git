const card_producto = document.querySelectorAll('.card-producto');
const descp_producto = document.querySelectorAll('.desc-producto');

card_producto.forEach((cadaCard, i) => {
    card_producto[i].addEventListener('mouseover', () => {
        cadaCard.classList.add('card-producto-efect');
     });

     card_producto[i].addEventListener('mouseout', () => {
        cadaCard.classList.remove('card-producto-efect');
     })
})

descp_producto.forEach((cadaDescp, i) => {
    descp_producto[i].addEventListener('mouseover', () => {
        cadaDescp.style.opacity = 1;
    })

    descp_producto[i].addEventListener('mouseout', () => {
        cadaDescp.style.opacity = 0;
    })
})