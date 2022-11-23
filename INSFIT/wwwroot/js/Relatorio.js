function calculate() {

    var altura = (document.getElementById("altura").value)/100

    var peso = document.getElementById("peso").value

    var imc = peso / (altura) ** 2

    console.log(imc)
    if (imc < 18.5) {
        window.alert("Você está magro, visite a pagina dietas")
    } else if (imc < 24.9) {
        window.alert("Você está normal, visite a pagina dietas")
    }  else if (imc < 29.9) {
        window.alert("Você está com sobrepeso, visite a pagina dietas")
    } else if (imc < 39.9) {
        window.alert("Você está com obesidade, visite a pagina dietas")
    } else if (imc > 39.9) {
        window.alert("Você está com obesidade mórbida, visite a pagina dietas")
    }


}