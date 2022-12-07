function calculate() {

    var altura = (document.getElementById("altura").value)/100

    var peso = document.getElementById("peso").value

    var imc = peso / (altura) ** 2
    var text=""
    
    if (imc < 18.5) {
        text="Você está magro, visite a pagina dietas."
    } else if (imc < 24.9) {
        text="Você está normal, visite a pagina dietas."
    }  else if (imc < 29.9) {
        text="Você está com sobrepeso, visite a pagina dietas."
    } else if (imc < 39.9) {
        text="Você está com obesidade, visite a pagina dietas."
    } else if (imc > 39.9) {
        text="Você está com obesidade mórbida, visite a pagina dietas."
    }
    document.getElementById("text_area").innerText=text


}

var text1=""
function media() {
    var pesid = document.getElementById("pesid").value
    var pesoat = document.getElementById("pesoat").value
    var vlrmedia = (pesid - pesoat / pesoat) * 100 
    if (vlrmedia > pesid) {
        text1="Você está perto da sua meta de peso, visite dietas"
    } else if (vlrmedia < pesid) {
        text1="você esta longe da sua meta de peso, visite dietas"
    }
    document.getElementById("text_area1").innerText=text1
}
