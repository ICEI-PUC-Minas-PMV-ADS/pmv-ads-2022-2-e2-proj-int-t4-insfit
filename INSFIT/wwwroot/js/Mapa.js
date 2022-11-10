let h2 = document.querySelector('h2');
var map;

// Captando a latidude e longitude do usuário
function success(pos) {
    console.log(pos.coords.latitude, pos.coords.longitude);
    //h2.textContent = `Latitude:${pos.coords.latitude}, Longitude:${pos.coords.longitude}`;

    if (map === undefined) {
        map = L.map('mapid').setView([pos.coords.latitude, pos.coords.longitude], 15);
    } else {
        map.remove();
        map = L.map('mapid').setView([pos.coords.latitude, pos.coords.longitude], 15);
    }

    //função para renderizar o mapa
    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(map);

    //função para criar o marcador do mapa
    L.marker([pos.coords.latitude, pos.coords.longitude]).addTo(map)
        .bindPopup('Esta é minha localização.')
        .openPopup();

}

 navigator.geolocation.getCurrentPosition(success);


   



