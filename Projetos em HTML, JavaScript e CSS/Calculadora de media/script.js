function calcular(){
    const ap1 = Number(document.getElementById('ap1').value)
    const ap2 = Number(document.getElementById('ap2').value)
    const as = Number(document.getElementById('as').value)
    let media = ap1 + ap2 + as
    if (media >= 6){
        document.getElementById('msg').innerHTML = 'nota: ' + media + ' aprovado'
    }
    if (media<= 6){
        document.getElementById('msg').innerHTML = 'nota: ' + media + ' reprovado, estude mais'
    }
}

function verificarAp1() {
    const ap1 = Number(document.getElementById('ap1').value)
    if (ap1 < 0 || ap1 > 1.5){
        alert('nota invalida')
    }

}

function verificarAp2() {
    const ap2 = Number(document.getElementById('ap2').value)
    if (ap2 < 0 || ap2 > 2.5){
        alert('nota invalida')
    }

}

function verificarAs() {
    const as = Number(document.getElementById('as').value)
    if (as < 0 || as > 6){
        alert('nota invalida')
    }

}