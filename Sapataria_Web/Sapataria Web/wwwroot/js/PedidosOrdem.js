$(document).ready(function () {
    console.log("buscando pedidos .....");

    var xhr = new XMLHttpRequest();
    xhr.open("POST", "https://localhost:44348/pedido/listar");
    xhr.addEventListener("load", function () {

        if (xhr.status == 200) {
            var resposta = xhr.responseText;
            var pedidos = JSON.parse(resposta);
            pedidos.forEach(pedido => {
                var data = new Data();

                if (data.OrganizarDatas(pedido.d_Entrega)) {
                    criarBlocoPedido(pedido);
                }
            });
        } else {
            console.log(xhr.status);
            console.log(xhr.responseText);
        }
    })

    xhr.send();

});

function criarBlocoPedido(pedido) {
    var blocoPrincipal = document.querySelector("#bloco-principal");

    var bloco = document.createElement("div");
    bloco.classList.add("panel-body");
    bloco.classList.add("msg_panel");
    bloco.classList.add("alert");
    bloco.classList.add("alert-danger");
    bloco.classList.add("bloco-pedido");

    var titulo = document.createElement("p");
    titulo.textContent = "Titulo : " + pedido.titulo;

    var data = new Data();
    var dataEntrega = document.createElement("p");
    dataEntrega.textContent = "Data Entrega: " + data.ArrumarData(pedido.d_Entrega);

    bloco.appendChild(titulo);
    bloco.appendChild(dataEntrega);
    blocoPrincipal.appendChild(bloco);
}


