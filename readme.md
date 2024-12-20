# DOQR Application

Este repositório contém a aplicação DOQR com um back-end em .NET e front-end em React. Para rodar a aplicação localmente, você precisará do Docker e Docker Compose instalados.

## Estrutura do Repositório

A aplicação está dividida nas seguintes pastas:

- **doqr-back**: Contém o código do back-end em .NET.
   [Repositório Original](https://github.com/nt-pissarra/doqr-back)
  
- **next-app**: Contém o código do front-end em React (Next.js).
   [Repositório Original](https://github.com/nt-pissarra/doqr-front)
   
## Requisitos

Antes de rodar a aplicação, certifique-se de que você tem as seguintes ferramentas instaladas:

- **[Docker](https://www.docker.com/get-started)** (versão 20.10 ou superior)
- **[Docker Compose](https://docs.docker.com/compose/install/)** (versão 1.29 ou superior)

## Como Instalar o Docker

### No Windows ou Mac:

1. Acesse a página oficial do Docker: [https://www.docker.com/get-started](https://www.docker.com/get-started)
2. Baixe e instale o Docker Desktop
3. Após a instalação, inicie o Docker

### No Linux:

Siga as instruções específicas para sua distribuição na [documentação oficial](https://docs.docker.com/engine/install/).

### Verificar a Instalação

Após a instalação, você pode verificar se o Docker foi instalado corretamente com o seguinte comando:

```bash
docker --version
```

## Rodando a Aplicação

A aplicação é composta por um backend em .NET, um banco de dados MySQL e um frontend em React (Next.js). O frontend estará disponível na porta 3000 (http://localhost:3000) após a inicialização. Siga os passos abaixo para rodar a aplicação localmente.

### No Docker Desktop (Windows ou Mac):

1. Abra o Docker Desktop e certifique-se de que o Docker está em execução
2. Acesse a pasta do projeto onde o arquivo `docker-compose.yml` está localizado:
   ```bash
   cd doqr-teste
   ```
3. Suba os containers com o comando:
   ```bash
   docker-compose up
   ```
   Isso irá construir e iniciar todos os serviços no Docker automaticamente

4. Após a inicialização, acesse:
   - Frontend: http://localhost:3000
   
5. Para parar a aplicação, execute:
   ```bash
   docker-compose down
   ```

### No Linux:

1. Abra o terminal e acesse a pasta do projeto onde o arquivo `docker-compose.yml` está localizado:
   ```bash
   cd doqr-teste
   ```
2. Suba os containers com o comando:
   ```bash
   sudo docker-compose up
   ```
   Isso irá construir e iniciar todos os serviços no Docker automaticamente

3. Após a inicialização, acesse:
   - Frontend: http://localhost:3000
   
4. Para parar a aplicação, execute:
   ```bash
   sudo docker-compose down
   ```
