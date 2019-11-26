$(document).ready(carregarDados);

function AdicionarCliente(dados) {

    var cliente = document.querySelector("#tabela");
    var tr = document.createElement("tr");

    tr.appendChild(criarTd(dados.titulo, "titulo"));
    tr.appendChild(criarTd(dados.cliente, "cliente"));
    tr.appendChild(criarTd(dados.d_Entrada, "d-entraga"));
    tr.appendChild(criarTd(dados.d_Entrega, "d-retirada"));

    cliente.appendChild(tr);
    return cliente;
}

function criarTd(dado, classe) {
    var td = document.createElement("td");
    td.textContent = dado;
    td.classList.add(classe);
    return td;
}

function carregarDados() {

    console.log("Buscando pacientes .....");

    var xhr = new XMLHttpRequest();
    xhr.open("POST", "https://localhost:44348/pedido/listar");
    xhr.addEventListener("load", function () {

        if (xhr.status == 200) {
            var resposta = xhr.responseText;
            var clientes = JSON.parse(resposta);
            clientes.forEach(cliente => {
                AdicionarCliente(cliente);
            });
        } else {
            console.log(xhr.status);
            console.log(xhr.responseText);
        }
    })

    xhr.send();
}