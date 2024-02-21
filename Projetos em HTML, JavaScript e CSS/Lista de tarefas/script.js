const tarefas = document.getElementById('task');

function adicionar() {
    const nomeTarefa = tarefas.value;
    const li = document.createElement('li');
    const btnRemover = document.createElement('button');
    btnRemover.style.marginLeft = '10px';
    btnRemover.innerText = 'Excluir';
    btnRemover.addEventListener('click', () => remover(li));

    const btnConcluir = document.createElement('button');
    btnConcluir.style.marginLeft = '10px';
    btnConcluir.innerText = 'Concluir';
    btnConcluir.addEventListener('click', () => concluir(li));

    li.innerText = nomeTarefa;
    li.appendChild(btnRemover);
    li.appendChild(btnConcluir);
    const ul = document.getElementById('tarefasPendentes');
    ul.appendChild(li);
    tarefas.value = '';
}

function remover(tarefa) {
    const ul = document.getElementById('tarefasPendentes');
    ul.removeChild(tarefa);
}

function concluir(tarefa) {
    tarefa.classList.add('completed');
    const ul = document.getElementById('tarefasConcluidas');
    ul.appendChild(tarefa);

    const btnRemover = tarefa.querySelector('button:first-child');
    btnRemover.removeEventListener('click', () => remover(tarefa));
    btnRemover.disabled = true;

    const btnConcluir = tarefa.querySelector('button:nth-child(2)');
    btnConcluir.disabled = true;
}