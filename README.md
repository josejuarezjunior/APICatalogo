# API Catalogo

## Escopo

Web API para um catálogo de produtos/categorias que pode atender uma rede de lojas ou supermercados.
**Serviço RESTful* que permite que aplicativos clientes gerenciem o catálogo de produtos e categorias.
**Endpoints** para *criar, ler, editar e excluir* produtos e também para consultar produtos e um produto específico.
**Endpoints** para *criar, ler, editar e excluir* categorias e também consultar categorias, uma categoria e os produtos de uma categoria.
Para **categorias**, será armazenado *nome e o caminho da imagem*.
Para **Produtos**, será armazenado *nome, descrição, valor unitário, caminho da imagem, estoque, data do cadastro e categoria*.

## Endpoints

Endpoint da API: /v1/api/produtos

- GET /v1/api/produtos
- GET /v1/api/produtos/1
- POST /v1/api/produtos
- PUT /v1/api/produtos/1
- DELETE /v1/api/produtos/1

Endpoint da API: /v1/api/categorias

- GET /v1/api/categorias
- GET /v1/api/categorias/1
- GET /v1/api/categorias/1/produtos
- POST /v1/api/categorias
- PUT /v1/api/categorias/1
- DELETE /v1/api/categorias/1

## Segurança

- Permitir o acesso à API somente a **usuários autenticados**.

**Endpoints** para *criar, ler, editar e excluir* usuários e também para consultar usuários e um usuário específico.
- Para os usuários, é armazenado: *nome, email, senha*.

Endpoint da API: /v1/api/usuarios

- GET /v1/api/usuarios
- GET /v1/api/usuarios/1
- POST /v1/api/usuarios
- PUT /v1/api/usuarios/1
- DELETE /v1/api/usuarios/1

## Persistência dos dados

- Banco de dados relacional: **MySql**.
- *Pomelo.EntityFrameworkCore.MySql*.
- *Entity Framework Core*.
- Abordagem *Code-First* - Parte das entidades para criar as tabelas e o banco de dados.
- Padrão Repositório (*Desacoplar o acesso aos dados da aplicação*).
