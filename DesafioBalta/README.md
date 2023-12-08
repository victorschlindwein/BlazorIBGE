# Projeto de API com dados do IBGE.

Esse projeto tem como objetivo disponibilizar o acesso � dados p�blicos do IBGE via API.  

## Instru��es:
- Para os tipos de rota Create, Update e Delete � **obrigat�ria** autentica��o do usu�rio.
- O token de autentica��o deve ser gerado atrav�s da rota de cria��o de usu�rio.
- O token expira em 12 horas e � poss�vel gerar um novo token atrav�s da rota de login.
- As rotas do tipo GET s�o p�blicas e n�o precisam de autoriza��o para acesso.

## Rotas IBGE dispon�veis:
### Create
	Recebe um JSON com dados do IBGE (cidade e estado) e cria um novo registro.  
	Retorna o registro com os dados criados.

### GetById/:id
	Retorna o objeto com os dados do registro passado na url da requisi��o.

### GetByCity/:city
	Retorna o objeto ou uma lista com as cidades correspondentes ao nome passado na url.

### GetByState/:state
	Retorna uma lista com todas as cidades do estado passado na url.

### Update/:id
	Recebe um JSON do tipo IBGE e atualiza os dados do registro cujo ID corresponde ao da URL.  
	Retorna o registro modificado.

### Delete/:id
	Remove o registro enviado na URL do banco de dados da aplica��o.

## Rotas de Login

### Create
	Recebe um email e uma senha e grava esses registros no banco de dados.  
	Retorna um objeto com os dados do usu�rio criado e um token de acesso.

### Login
	Recebe um objeto com email e senha existentes e retorna os dados do usu�rio com o token.

# Desenvolvedores
[@jefersonquaiato](https://github.com/jefersonquaiato), 
[@teixeiralex](https://github.com/teixeiralex) e
[@victorschlindwein](https://github.com/victorschlindwein)  