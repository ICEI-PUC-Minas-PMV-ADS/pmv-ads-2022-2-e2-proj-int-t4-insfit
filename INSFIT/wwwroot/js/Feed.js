const button = document.querySelector('#curtir');
const number = document.querySelector('#number');

button.addEventListener('click', () => {
    let curtirValue = document.querySelector('#number').textContent;
    let newValue = number(curtirValue) + 1;
    button.classList.add('curtir');
    number.innerHTML = newValue;
});


   



