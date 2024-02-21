function somar() {
    var num1 = parseFloat(document.getElementById('numero1').value);
    var num2 = parseFloat(document.getElementById('numero2').value);

    if (isNaN(num1) || isNaN(num2)) {
      document.getElementById('resultado').textContent = 'Por favor, preencha ambos os campos com números válidos.';
      return;
    }

    var resultado = num1 + num2;
    document.getElementById('resultado').textContent = 'Resultado: ' + resultado;
  }

  function subtrair() {
    var num1 = parseFloat(document.getElementById('numero1').value);
    var num2 = parseFloat(document.getElementById('numero2').value);

    if (isNaN(num1) || isNaN(num2)) {
      document.getElementById('resultado').textContent = 'Por favor, preencha ambos os campos com números válidos.';
      return;
    }

    var resultado = num1 - num2;
    document.getElementById('resultado').textContent = 'Resultado: ' + resultado;
  }

  function multiplicar() {
    var num1 = parseFloat(document.getElementById('numero1').value);
    var num2 = parseFloat(document.getElementById('numero2').value);

    if (isNaN(num1) || isNaN(num2)) {
      document.getElementById('resultado').textContent = 'Por favor, preencha ambos os campos com números válidos.';
      return;
    }

    var resultado = num1 * num2;
    document.getElementById('resultado').textContent = 'Resultado: ' + resultado;
  }

  function dividir() {
    var num1 = parseFloat(document.getElementById('numero1').value);
    var num2 = parseFloat(document.getElementById('numero2').value);

    if (isNaN(num1) || isNaN(num2)) {
      document.getElementById('resultado').textContent = 'Por favor, preencha ambos os campos com números válidos.';
      return;
    }

    if (num2 === 0) {
      document.getElementById('resultado').textContent = 'Não é possível dividir por zero.';
      return;
    }

    var resultado = num1 / num2;
    document.getElementById('resultado').textContent = 'Resultado: ' + resultado;
  }

  function limpar() {
    document.getElementById('numero1').value = '';
    document.getElementById('numero2').value = '';
    document.getElementById('resultado').textContent = '';
  }