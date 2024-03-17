function cadastrarProduto(){
    var pro_codigo = document.getElementById('codigo').value
    var pro_descricao =  document.getElementById('descricao').value
    var pro_estoque = document.getElementById('estoque').value
    var pro_preco = document.getElementById('valor').value

    fetch(`http://localhost:5192/Produto/gravarProduto?codProd=${pro_codigo}&descricao=${pro_descricao}&preco=${pro_preco}&qtd_estoque=${pro_estoque}`,{
        method: 'POST',
        headers: {
        'Content-Type': 'application/json'
        },
    })
    .then(response => {
      if (!response.ok) {
        throw new Error('Erro ao obter os dados da API');
      }
      return response.json();
    })
    .then(data => {
      console.log('Dados recebidos:', data);
    })
    .catch(error => {
      console.error('Erro:', error);
    });

    event.preventDefault();
}

function verificarProduto(event){
  
  if (event.key === 'Enter') {
    var codigo = document.getElementById('codigo').value;
      fetch('http://localhost:5192/Produto/obterPorCodigo/'+codigo,{
        method: 'GET',
        headers: {
        'Content-Type': 'application/json'
        },
      })
      .then(response => {
        if (!response.ok) {
          throw new Error('Erro ao obter os dados da API');
        }
        return response.json();
      })
      .then(data => {
        document.getElementById('codigo').value = data.id;
        document.getElementById('descricao').value = data.descricao;
        document.getElementById('estoque').value = data.estoque;
        document.getElementById('valor').value = data.preco;
      })
      .catch(error => {
        console.error('Erro:', error);
      });

      event.preventDefault();
  }  
}

async function carregarProdutos() {
  try {
      const response = await fetch('http://localhost:5192/Produto/obterProdutos', {
          method: 'GET',
          headers: {
              'Content-Type': 'application/json'
          }
      });

      if (!response.ok) {
          throw new Error('Erro ao obter os dados da API');
      }

      const data = await response.json();
      console.log(data);

      var tabela = '';
      for (var i = 0; i < data.length; i++) {
          tabela +=
              `<div class="col-sm-12 col-md-6 col-lg-3 d-flex" onclick="chamarTela(${data[i].id})">
                  <div class="product d-flex flex-column">
                      <a href="#" class="img-prod"><img class="img-fluid" src="images/teste.png" alt="Colorlib Template">
                        <div class="overlay"></div>
                      </a>
                      <div class="text py-3 pb-4 px-3">
                          <div class="d-flex">
                              <div class="cat">
                                  <span>Casual</span>
                              </div>
                              <div class="rating">
                                  <p class="text-right mb-0">
                                      <a href="#"><span class="ion-ios-star-outline"></span></a>
                                      <a href="#"><span class="ion-ios-star-outline"></span></a>
                                      <a href="#"><span class="ion-ios-star-outline"></span></a>
                                      <a href="#"><span class="ion-ios-star-outline"></span></a>
                                      <a href="#"><span class="ion-ios-star-outline"></span></a>
                                  </p>
                              </div>
                          </div>
                          <h3><a href="#">${data[i].descricao}</a></h3>
                          <div class="pricing">
                              <p class="price"><span>R$ ${data[i].preco}</span></p>
                          </div>
                          <p class="bottom-area d-flex px-3">
                              <a href="#" class="add-to-cart text-center py-2 mr-1"><span>Carrinho<i class="ion-ios-add ml-1"></i></span></a>
                              <a href="#" class="buy-now text-center py-2">Comprar<span><i class="ion-ios-cart ml-1"></i></span></a>
                          </p>
                      </div>
                  </div>
              </div>`;
      }
      document.getElementById('produtos_index').innerHTML = tabela;
  } catch (error) {
      console.error('Erro:', error);
  }
}

function chamarTela(codigo){
  localStorage.setItem("codigo",codigo);
  window.location.href = "product-single.html";
}

function carregarDadosProduto(){
  var codigo = localStorage.getItem("codigo");
  fetch('http://localhost:5192/Produto/obterPorCodigo/'+codigo,{
        method: 'GET',
        headers: {
        'Content-Type': 'application/json'
        },
      })
      .then(response => {
        if (!response.ok) {
          throw new Error('Erro ao obter os dados da API');
        }
        return response.json();
      })
      .then(data => {     
      tabela = 
      `
      <div class="row">
      <div class="col-lg-6 mb-5">
        <a href="images/teste.png" class="image-popup prod-img-bg"><img src="images/teste.png" class="img-fluid" alt="Colorlib Template" style="margin-left: 30px; margin-top: 50px;"></a>
      </div>
      <div class="col-lg-6 product-details pl-md-5 ">
        <h3>${data.descricao}</h3>
        <div class="rating d-flex">
          <p class="text-left mr-4">
            <a href="#" class="mr-2">5.0</a>
            <a href="#"><span class="ion-ios-star-outline"></span></a>
            <a href="#"><span class="ion-ios-star-outline"></span></a>
            <a href="#"><span class="ion-ios-star-outline"></span></a>
            <a href="#"><span class="ion-ios-star-outline"></span></a>
            <a href="#"><span class="ion-ios-star-outline"></span></a>
          </p>
          <p class="text-left mr-4">
            <a href="#" class="mr-2" style="color: #000;">100 <span style="color: #bbb;">Avaliações</span></a>
          </p>
          <p class="text-left">
            <a href="#" class="mr-2" style="color: #000;">500 <span style="color: #bbb;">Vendidos</span></a>
          </p>
        </div>
        <p class="price"><span>R$ ${data.preco}</span></p>
        <p>O Invincible Run 3 possui amortecimento espesso para ajudar você a ficar atento e ativo hoje, amanhã e sempre. É super elástico e resiliente para você percorrer o seu caminho preferido e voltar para a próxima corrida sentindo-se pronto e revigorado.</p>
        <p>Quanto mais suporte oferece o tênis, mais estabilidade ele fornece à sua passada natural. A combinação de suporte ideal e amortecimento no local certo permite que segurança a cada passo. O Invincible 3 possui tecnologia de alto suporte, com amortecimento e estabilidade no local certo. Foi feito para proteger os seus pés dos efeitos da pronação..
        </p>
        <div class="row mt-4">
          <div class="col-md-6">
            <div class="form-group d-flex">
              <div class="select-wrap">
                <div class="icon"><span class="ion-ios-arrow-down"></span></div>
                <select name="" id="" class="form-control">
                  <option value="">34</option>
                  <option value="">35</option>
                  <option value="">37</option>
                  <option value="">42</option>
                </select>
              </div>
            </div>
          </div>
          <div class="w-100"></div>
          <div class="input-group col-md-6 d-flex mb-3">
             <span class="input-group-btn mr-2">
                <button type="button" class="quantity-left-minus btn"  data-type="minus" data-field="">
                 <i class="ion-ios-remove"></i>
                </button>
              </span>
             <input type="text" id="quantity" name="quantity" class="quantity form-control input-number" value="1" min="1" max="100">
             <span class="input-group-btn ml-2">
                <button type="button" class="quantity-right-plus btn" data-type="plus" data-field="">
                   <i class="ion-ios-add"></i>
               </button>
             </span>
          </div>
          <div class="w-100"></div>
          <div class="col-md-12">
            <p style="color: #000;">${data.estoque} unidades disponíveis</p>
          </div>
        </div>
        <p><a href="cart.html" class="btn btn-black py-3 px-5 mr-2">Adicionar ao Carrinho</a><a href="cart.html" class="btn btn-primary py-3 px-5">Comprar agora</a></p>
      </div>
    </div>
      `;
        
      document.getElementById('detalhes_produto').innerHTML = tabela;
      })
      .catch(error => {
        console.error('Erro:', error);
      });

      event.preventDefault();
}