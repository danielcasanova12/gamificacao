# Projeto de OO - E-commerce
## Bernard Moreno, Tassi, Daniel casnova

Desafio de e-commerce de roupas A sua equipe foi contratada para desenvolver um sistema de e-commerce de roupas. O sistema deve permitir aos usuários comprar roupas de diferentes tipos, tais como camisetas, calças, sapatos, entre outros. Além disso, o sistema deve oferecer descontos e promoções especiais para determinados produtos e categorias de produtos. Para implementar esse sistema, a equipe decidiu usar conceitos de herança, polimorfismo, composição e enumeradores. Cada tipo de roupa deve ser representado por uma classe, que herda as propriedades básicas de uma classe Produto. Além disso, cada tipo de roupa pode ter suas próprias propriedades e métodos específicos.

Algumas categorias de produtos, como calçados e acessórios, têm propriedades em comum, como tamanho e cor. Para evitar duplicação de código, a equipe decidiu criar uma classe abstrata Acessorio para representar essas categorias de produtos. As classes Sapato e Bolsa herdam dessa classe, e adicionam suas próprias propriedades e métodos específicos.

Para representar as categorias de produtos, a equipe decidiu usar enumeradores. O enum CategoriaProduto define as diferentes categorias de produtos, como Camiseta, Calca, Sapato, Bolsa e Acessorio. Cada tipo de roupa é representado por uma constante do enum.

Além disso, o sistema deve oferecer descontos e promoções especiais para determinados produtos e categorias de produtos. Para implementar essa funcionalidade, a equipe decidiu criar uma classe Promocao que representa uma promoção, e compor essa classe com as classes de produtos ou categorias de produtos que devem receber a promoção. A classe Promocao possui uma propriedade que indica o tipo de desconto que deve ser aplicado (porcentagem ou valor fixo), e um método que calcula o valor total do desconto a ser aplicado.

O sistema também deve permitir aos usuários adicionar produtos ao carrinho de compras, e o carrinho deve ser capaz de calcular o valor total dos produtos e descontos aplicados. Para implementar essa funcionalidade, a equipe decidiu criar uma classe CarrinhoDeCompras que compõe as classes de produtos adicionadas pelo usuário e as classes Promocao aplicadas.

Por fim, o sistema deve permitir aos usuários realizar o pagamento dos produtos, e deve ser capaz de gerar uma nota fiscal com os produtos comprados e os descontos aplicados. A equipe decidiu implementar essa funcionalidade criando uma classe Pagamento que recebe como parâmetros o carrinho de compras e os dados do cliente, e retorna uma nota fiscal com as informações da compra.

Requisitos mínimos do sistema

•O sistema deve permitir aos usuários comprar roupas de diferentes tipos, como camisetas, calças, sapatos, entre outros. •O sistema deve oferecer descontos e promoções especiais para determinados produtos e categorias de produtos. •O sistema deve permitir aos usuários adicionar produtos ao carrinho de compras,
