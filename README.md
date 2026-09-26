IfoodClone — Web Restaurante

Sistema web desenvolvido para a primeira avaliação da disciplina, replicando
partes do iFood Web Restaurante ([ifood.com.br](https://www.ifood.com.br/restaurantes) com
alguns pontos simplificados e outros acrescentados.

O projeto implementa o cadastro de contas, restaurantes e refeições como CRUD
web completo, com persistência em banco de dados relacional, além dos módulos
de autenticação e de solicitação de pedidos documentados nesta entrega.

## Stack utilizada

| Camada | Tecnologia |
| Linguagem | C# (.NET 10) |
| Framework web | ASP.NET Core MVC |
| Acesso a dados | Entity Framework Core |
| Banco de dados | SQL Server (relacional) |
| Hash de senha | BCrypt.Net |
| Autenticação federada | OAuth 2.0 (Google / Facebook) |

## Funcionalidades implementadas

### CRUD de Contas
- Listagem, cadastro, edição, exclusão e consulta de contas
- E-mail único por conta (índice único no banco)
- Senha armazenada como hash BCrypt, nunca em texto puro
- Campo de papel do usuário: CLIENTE, RESTAURANTE, ENTREGADOR ou ADMIN
- Campos para login social: Provider e ProviderId

### CRUD de Restaurantes
- Listagem, cadastro, edição, exclusão e consulta de restaurantes
- CNPJ único (índice único no banco)
- Categoria, telefone, taxa de entrega, pedido mínimo e horário de funcionamento
- Vinculação a uma conta responsável (chave estrangeira)

### CRUD de Refeições
- Listagem, cadastro, edição, exclusão e consulta de refeições
- Nome, descrição, preço base, categoria e disponibilidade
- Vinculação a um restaurante (chave estrangeira, com deleção em cascata)

### Autenticação e Pedidos (documentados)
- Regras de negócio dos módulos de autenticação e de solicitação de pedidos
- Documento completo no PDF 
