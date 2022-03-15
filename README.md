# Projeto 
Projeto e-commerce do curso feito no Desenvolvedor.io chamado ASP.NET Core Enterprise Applications.

# Introdução
Aplicações N camadas utilizando uma arquitetura robusta modelada com DDD, CQRS e EventSourcing.

#Comando para rodar o projeto no docker
Acessar diretório docker e executar o comando abaixo:
docker-compose -f nerdstore_producao.yml up -d

# Microserviços
Desenvolvido com as seguintes descrições:
-	API de Identidade
-	API de Catalogo
-	Aplicação Web
-	API de Clientes
-	Comunicação entre API's com RabbitMQ
-   API de Carrinho
-   API de Pedido
-   API de Pagamentos
-   API Gateway de Compras
-   Docker