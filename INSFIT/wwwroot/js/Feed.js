//botao curtir
//botao de curtir
const button = document.querySelector('#like');
const number = document.querySelector('#number');

button.addEventListener('click', () => {
    let likeValue = document.querySelector('#number').textContent;
    let newValue = Number(likeValue) + 1;
    button.classList.add('like');
    number.innerHTML = newValue;
});

//subir imagem pro feed
const inputFile = document.querySelector('#CampoImgem');
const pictureImage = document.querySelector('.picture_image');
const pictureImageTxt = 'Choose an image';
pictureImage.innerHTML = pictureImageTxt;

inputFile.addEventListener('change', function (e) {
    const inputTarget = e.target;
    const file = inputTarget.files[0];

    if (file) {
        const reader = new FileReader();

        reader.addEventListener("load", function (e) {
            const readerTarget = e.target;

            const img = document.createElement("img");
            img.src = readerTarget.result;
            img.classList.add("picture_img");

            pictureImage.innerHTML = "";
            pictureImage.appendChild(img);
        });

        reader.readAsDataURL(file);
    } else {
        pictureImage.innerHTML = pictureImageTxt;
    }
});
})
   



