
//botao de curtir
const button = document.querySelector('#like');
const number = document.querySelector('#number');

button.addEventListener('click', () => {
    let likeValue = document.querySelector('#number').textContent;
    let newValue = Number(likeValue) + 1;
    button.classList.add('like');
    number.innerHTML = newValue;
});

   



