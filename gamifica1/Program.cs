using gamifica.Models;
using gamifica.UI;
CategoriaUI categoriaUI = new CategoriaUI();
ClienteUI clienteUI = new ClienteUI();
VendaUI vendaUI = new VendaUI();
ProdutoUI produtoUI = new ProdutoUI();
bool sair = false;
while (!sair)
{
    Console.WriteLine("Sistema de Gerenciamento de Vendas de Loja de Roupas");
    Console.WriteLine("1. Gerenciar Categorias");
    Console.WriteLine("2. Gerenciar Produtos");
    Console.WriteLine("3. Gerenciar Clientes");
    Console.WriteLine("4. Gerenciar Vendas");
    Console.WriteLine("5. Sair");
    Console.Write("Escolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:

            bool sairCategoria = false;
            while (!sairCategoria)
            {
                Console.WriteLine("Gerenciar Categorias");
                Console.WriteLine("1. Registrar Categoria");
                Console.WriteLine("2. Alterar Categoria");
                Console.WriteLine("3. Buscar Todas Categorias");
                Console.WriteLine("4. Buscar Categoria por ID");
                Console.WriteLine("5. Remover Categoria");
                Console.WriteLine("6. Voltar");
                Console.Write("Escolha uma opção: ");
                int opcaoCategoria = int.Parse(Console.ReadLine());

                switch (opcaoCategoria)
                {
                    case 1:
                        Console.Write("Digite o id: ");
                        int idcategoria = int.Parse(Console.ReadLine());

                        Console.Write("Digite o nome da categoria: ");
                        string nomeCategoria = Console.ReadLine();

                        Console.Write("Digite a descrição da categoria: ");
                        string descricaoCategoria = Console.ReadLine();

                        Categoria novaCategoria = new Categoria
                        {
                            IdCategoria = idcategoria,
                            Nome = nomeCategoria,
                            Descricao = descricaoCategoria
                        };

                        categoriaUI.RegistrarCategoria(novaCategoria);

                        Console.WriteLine("Categoria registrada com sucesso!");
                        break;
                    case 2:
                        Console.Write("Digite o ID da categoria que deseja alterar:");
                        int idCategoriaAlterar = int.Parse(Console.ReadLine());

                        // Busca a categoria pelo ID informado
                        Categoria categoriaAlterar = categoriaUI.BuscarCategoriaPorId(idCategoriaAlterar);

                        if (categoriaAlterar != null)
                        {
                            Console.WriteLine($"Categoria encontrada: {categoriaAlterar.Nome}");

                            Console.WriteLine("Digite o novo nome da categoria:");
                            nomeCategoria = Console.ReadLine();

                            Console.WriteLine("Digite a nova descrição da categoria:");
                            descricaoCategoria = Console.ReadLine();

                            // Atualiza os dados da categoria com as informações inseridas pelo usuário
                            categoriaAlterar.Nome = nomeCategoria;
                            categoriaAlterar.Descricao = descricaoCategoria;

                            // Salva as alterações na lista de categorias
                            categoriaUI.AlterarCategoria(categoriaAlterar);

                            Console.WriteLine($"Categoria {categoriaAlterar.Nome} atualizada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine($"Categoria com ID {idCategoriaAlterar} não encontrada!");
                        }
                        break;
                    case 3:
                        List<Categoria> categorias = categoriaUI.BuscarTodasCategorias();
                        foreach (Categoria categoria in categorias)
                        {
                            Console.WriteLine($"ID: {categoria.IdCategoria}, Nome: {categoria.Nome}, Descrição: {categoria.Descricao}");
                        }
                        break;
                    case 4:
                        Console.Write("Informe o ID da categoria: ");
                        int idCategoria = int.Parse(Console.ReadLine());

                        Categoria categoriaEncontrada = categoriaUI.BuscarCategoriaPorId(idCategoria);

                        if (categoriaEncontrada == null)
                        {
                            Console.WriteLine("Categoria não encontrada.");
                        }
                        else
                        {
                            Console.WriteLine($"ID: {categoriaEncontrada.IdCategoria}, Nome: {categoriaEncontrada.Nome}, Descrição: {categoriaEncontrada.Descricao}");
                        }
                        break;
                    case 5:
                        Console.Write("Informe o ID da categoria a ser removida: ");
                        int idCategoriaRemover = int.Parse(Console.ReadLine());

                        bool categoriaRemovida = categoriaUI.RemoverCategoria(idCategoriaRemover);

                        if (categoriaRemovida)
                        {
                            Console.WriteLine("Categoria removida com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Categoria não encontrada.");
                        }
                        break;
                    case 6:
                        sairCategoria = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            break;
        case 2:
            bool sairProduto = false;
            while (!sairProduto)
            {
                Console.WriteLine("Gerenciar Produtos");
                Console.WriteLine("1. Registrar Produto");
                Console.WriteLine("2. Alterar Produto");
                Console.WriteLine("3. Buscar Todos Produtos");
                Console.WriteLine("4. Buscar Produto por ID");
                Console.WriteLine("5. Remover Produto");
                Console.WriteLine("6. Voltar");
                Console.Write("Escolha uma opção: ");
                int opcaoProduto = int.Parse(Console.ReadLine());

                switch (opcaoProduto)
                {
                    case 1:
                        Console.Write("Digite o id: ");
                        int idProduto = int.Parse(Console.ReadLine());
                        Console.Write("Digite o nome do produto: ");
                        string nomeProduto = Console.ReadLine();

                        Console.Write("Digite a descrição do produto: ");
                        string descricaoProduto = Console.ReadLine();

                        Console.Write("Digite o preço do produto: ");
                        double precoProduto = double.Parse(Console.ReadLine());

                        Console.Write("Digite o ID da categoria do produto: ");
                        int idCategoriaProduto = int.Parse(Console.ReadLine());

                        // Verifica se a categoria existe
                        Categoria categoriaProduto = categoriaUI.BuscarCategoriaPorId(idCategoriaProduto);
                        if (categoriaProduto == null)
                        {
                            Console.WriteLine("Categoria não encontrada!");
                        }
                        else
                        {
                            // Cria um novo produto com as informações fornecidas e adiciona à lista de produtos
                            Produto novoProduto = new Produto
                            {
                                IdProduto = idProduto,
                                Nome = nomeProduto,
                                Descricao = descricaoProduto,
                                Preco = precoProduto,
                                Categoria = categoriaProduto
                            };

                            produtoUI.RegistrarProduto(novoProduto);

                            Console.WriteLine("Produto registrado com sucesso!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite o ID do produto que deseja alterar:");
                        int idProdutoAlterar = int.Parse(Console.ReadLine());

                        // Busca o produto pelo ID informado
                        Produto produtoAlterar = produtoUI.BuscarProdutoPorId(idProdutoAlterar);

                        if (produtoAlterar != null)
                        {
                            Console.WriteLine($"Produto encontrado: {produtoAlterar.Nome}");

                            Console.WriteLine("Digite o novo nome do produto:");
                             nomeProduto = Console.ReadLine();

                            Console.WriteLine("Digite a nova descrição do produto:");
                             descricaoProduto = Console.ReadLine();

                            Console.WriteLine("Digite o novo preço do produto:");
                             precoProduto = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o ID da categoria do produto:");
                             idCategoriaProduto = int.Parse(Console.ReadLine());

                            // Busca a categoria pelo ID informado
                             categoriaProduto = categoriaUI.BuscarCategoriaPorId(idCategoriaProduto);

                            if (categoriaProduto != null)
                            {
                                // Atualiza os dados do produto com as informações inseridas pelo usuário
                                produtoAlterar.Nome = nomeProduto;
                                produtoAlterar.Descricao = descricaoProduto;
                                produtoAlterar.Preco = precoProduto;
                                produtoAlterar.Categoria = categoriaProduto;

                                // Salva as alterações na lista de produtos
                                produtoUI.AtualizarProduto(produtoAlterar);

                                Console.WriteLine($"Produto {produtoAlterar.Nome} atualizado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine($"Categoria com ID {idCategoriaProduto} não encontrada!");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Produto com ID {idProdutoAlterar} não encontrado!");
                        }
                        break;

                    case 3:
                        List<Produto> produtos = produtoUI.BuscarTodosProdutos();
                        foreach (Produto produto in produtos)
                        {
                            Console.WriteLine($"ID: {produto.IdProduto}, Nome: {produto.Nome}, Descrição: {produto.Descricao}, Preço: {produto.Preco}, Categoria: {produto.Categoria.Nome}");
                        }
                        break;
                    case 4:
                        Console.Write("Informe o ID do produto: ");
                         idProduto = int.Parse(Console.ReadLine()); 

                        Produto produtoEncontrado = produtoUI.BuscarProdutoPorId(idProduto);

                        if (produtoEncontrado == null)
                        {
                            Console.WriteLine("Produto não encontrado.");
                        }
                        else
                        {
                            Console.WriteLine($"ID: {produtoEncontrado.IdProduto}, Nome: {produtoEncontrado.Nome}, Descrição: {produtoEncontrado.Descricao}, Preço: {produtoEncontrado.Preco}, Categoria: {produtoEncontrado.Categoria.Nome}");
                        }
                        break;
                    case 5:
                        Console.Write("Informe o ID do produto a ser removido: ");
                        int idProdutoRemover = int.Parse(Console.ReadLine());

                        bool produtoRemovido = produtoUI.RemoverProduto(idProdutoRemover);

                        if (produtoRemovido)
                        {
                            Console.WriteLine("Produto removido com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado.");
                        }
                        break;
                    case 6:
                        sairProduto = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            break;
        case 3:
            bool sairCliente = false;
            while (!sairCliente)
            {
                Console.WriteLine("Gerenciar Clientes");
                Console.WriteLine("1. Registrar Cliente");
                Console.WriteLine("2. Alterar Cliente");
                Console.WriteLine("3. Buscar Todos Clientes");
                Console.WriteLine("4. Buscar Cliente por ID");
                Console.WriteLine("5. Remover Cliente");
                Console.WriteLine("6. Voltar");
                Console.Write("Escolha uma opção: ");
                int opcaoCliente = int.Parse(Console.ReadLine());

                switch (opcaoCliente)
                {
                    case 1:
                        Console.Write("Digite o nome do cliente: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o sobrenome do cliente: ");
                        string sobrenome = Console.ReadLine();
                        Console.Write("Digite o endereço do cliente: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Digite o telefone do cliente: ");
                        string telefone = Console.ReadLine();
                        clienteUI.RegistrarCliente(nome, sobrenome, endereco, telefone);
                        break;
                    case 2:
                        Console.Write("Digite o ID do cliente que deseja alterar: ");
                        int idCliente = int.Parse(Console.ReadLine());
                        Cliente clienteExistente = clienteUI.BuscarClientePorId(idCliente);

                        if (clienteExistente != null)
                        {
                            Console.Write("Digite o novo nome do cliente: ");
                            string novoNome = Console.ReadLine();
                            Console.Write("Digite o novo sobrenome do cliente: ");
                            string novoSobrenome = Console.ReadLine();
                            Console.Write("Digite o novo endereço do cliente: ");
                            string novoEndereco = Console.ReadLine();
                            Console.Write("Digite o novo telefone do cliente: ");
                            string novoTelefone = Console.ReadLine();

                            clienteUI.AlterarCliente(idCliente, novoNome, novoSobrenome, novoEndereco, novoTelefone);
                            Console.WriteLine("Cliente alterado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Cliente não encontrado!");
                        }
                        break;

                    case 3:
                        //List<Venda> vendas = vendaUI.BuscarTodasVendas();
                        List<Cliente> clientes = clienteUI.BuscarTodosClientes();
                        foreach (Cliente cliente in clientes)
                        {
                            Console.WriteLine($"ID: {cliente.IdCliente}, Nome: {cliente.Nome}, Sobrenome: {cliente.Sobrenome}, Endereço: {cliente.Endereco}, Telefone: {cliente.Telefone}");
                        }
                        break;
                    case 4:
                        Console.Write("Digite o ID do cliente que deseja buscar: "); 
                        idCliente = int.Parse(Console.ReadLine());
                        Cliente clienteEncontrado = clienteUI.BuscarClientePorId(idCliente);

                        if (clienteEncontrado != null)
                        {
                            Console.WriteLine($"ID: {clienteEncontrado.IdCliente}, Nome: {clienteEncontrado.Nome}, Sobrenome: {clienteEncontrado.Sobrenome}, Endereço: {clienteEncontrado.Endereco}, Telefone: {clienteEncontrado.Telefone}");
                        }
                        else
                        {
                            Console.WriteLine("Cliente não encontrado!");
                        }
                        break;

                    case 5:
                        Console.Write("Digite o ID do cliente que deseja remover: ");
                        idCliente = int.Parse(Console.ReadLine());
                        clienteExistente = clienteUI.BuscarClientePorId(idCliente);

                        if (clienteExistente != null)
                        {
                            clienteUI.RemoverCliente(idCliente);
                            Console.WriteLine("Cliente removido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Cliente não encontrado!");
                        }
                        break;

                    case 6:
                        sairCliente = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            break;
        
        case 4:
            bool sairVenda = false;
            while (!sairVenda)
            {
                Console.WriteLine("Gerenciar Vendas");
                Console.WriteLine("1. Registrar Venda");
                Console.WriteLine("2. Alterar Venda");
                Console.WriteLine("3. Buscar Todas Vendas");
                Console.WriteLine("4. Buscar Venda por ID");
                Console.WriteLine("5. Remover Venda");
                Console.WriteLine("6. Voltar");
                Console.Write("Escolha uma opção: ");
                int opcaoVenda = int.Parse(Console.ReadLine());

                switch (opcaoVenda)
                {
                    case 1:
                        Console.WriteLine("Registrar Venda");

                        // Lê o id do cliente
                        Console.Write("Digite o ID do cliente: ");
                        int idCliente = int.Parse(Console.ReadLine());

                        // Encontra o cliente pelo seu id
                        Cliente cliente = clienteUI.BuscarClientePorId(idCliente);
                        if (cliente == null)
                        {
                            Console.WriteLine("Cliente não encontrado!");
                            break;
                        }

                        // Lê os ids dos produtos a serem vendidos
                        Console.Write("Digite os IDs dos produtos a serem vendidos separados por vírgula: ");
                        string inputProdutos = Console.ReadLine();
                        int[] idsProdutos = inputProdutos.Split(',').Select(int.Parse).ToArray();

                        // Encontra os produtos pelos seus ids
                        List<Produto> produtosVendidos = new List<Produto>();
                        foreach (int idProduto in idsProdutos)
                        {
                            Produto produto = produtoUI.BuscarProdutoPorId(idProduto);
                            if (produto == null)
                            {
                                Console.WriteLine($"Produto com ID {idProduto} não encontrado!");
                            }
                            else
                            {
                                produtosVendidos.Add(produto);
                            }
                        }

                        // Registra a venda
                        vendaUI.RegistrarVenda(cliente, produtosVendidos);
                        
                        break;

                    case 2:
                        Console.WriteLine("Alterar Venda");

                        // Lê o id da venda a ser alterada
                        Console.Write("Digite o ID da venda a ser alterada: ");
                        int idVenda = int.Parse(Console.ReadLine());

                        // Encontra a venda pelo seu id
                        Venda vendaEncontrada = vendaUI.BuscarVendaPorId(idVenda);
                        if (vendaEncontrada == null)
                        {
                            Console.WriteLine("Venda não encontrada!");
                            break;
                        }

                        // Lê os novos dados da venda
                        Console.Write("Digite o novo ID do cliente: ");
                        int novoIdCliente = int.Parse(Console.ReadLine());

                        // Encontra o novo cliente pelo seu id
                        Cliente novoCliente = clienteUI.BuscarClientePorId(novoIdCliente);
                        if (novoCliente == null)
                        {
                            Console.WriteLine("Novo cliente não encontrado!");
                            break;
                        }

                        Console.Write("Digite os novos IDs dos produtos a serem vendidos separados por vírgula: ");
                        string inputNovosProdutos = Console.ReadLine();
                        int[] novosIdsProdutos = inputNovosProdutos.Split(',').Select(int.Parse).ToArray();

                        // Encontra os novos produtos pelos seus ids
                        List<Produto> novosProdutosVendidos = new List<Produto>();
                        foreach (int idProduto in novosIdsProdutos)
                        {
                            Produto novoProduto = produtoUI.BuscarProdutoPorId(idProduto);
                            if (novoProduto == null)
                            {
                                Console.WriteLine($"Produto com ID {idProduto} não encontrado!");
                            }
                            else
                            {
                                novosProdutosVendidos.Add(novoProduto);
                            }
                        }

                        // Altera a venda
                        vendaUI.AlterarVenda(idVenda, novoCliente, novosProdutosVendidos);
                        Console.WriteLine("Venda alterada com sucesso!");
                        break;
                    case 3:
                        List<Venda> vendas = vendaUI.BuscarTodasVendas();
                        foreach (Venda venda in vendas)
                        {
                            Console.WriteLine($"ID: {venda.IdVenda}, Cliente: {venda.Cliente.Nome}, Data: {venda.DataVenda}, Valor Total: {venda.ValorTotalCompra}");
                        }
                        break;
                    case 4:
                        Console.Write("Digite o ID da venda que deseja buscar: ");
                        int idVendas = int.Parse(Console.ReadLine());
                        Venda vendaEncontradaa = vendaUI.BuscarVendaPorId(idVendas);
                        if (vendaEncontradaa != null)
                        {
                            Console.WriteLine($"ID: {vendaEncontradaa.IdVenda}, Cliente: {vendaEncontradaa.Cliente.Nome}, Data: {vendaEncontradaa.DataVenda}, Valor Total: {vendaEncontradaa.ValorTotalCompra}");
                        }
                        else
                        {
                            Console.WriteLine("Venda não encontrada!");
                        }
                        break;
                    case 5:
                        Console.Write("Digite o ID da venda que deseja remover: ");
                        int idVendaRemover = int.Parse(Console.ReadLine());
                        idVendas = int.Parse(Console.ReadLine());
                        vendaUI.RemoverVenda(idVendas);
                        Console.WriteLine("Venda removida com sucesso!");
                        
                        break;
                    case 6:
                        sairVenda = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            break;
        case 5:
            sair = true;
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}