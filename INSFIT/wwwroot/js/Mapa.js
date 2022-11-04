let h2 = document.querySelector('h2');

// Captando a latidude e longitude do usuário
function success(pos) {
    console.log(pos.coords.latitude, pos.coords.longitude);
    //h2.textContent = `Latitude:${pos.coords.latitude}, Longitude:${pos.coords.longitude}`;
}

function error(err) {
    console.log(err);
}

navigator.geolocation.getCurrentPosition(success, error); 